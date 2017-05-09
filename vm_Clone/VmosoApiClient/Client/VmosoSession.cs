/* 
 * Vmoso API
 *
 * Vmoso API
 *
 * OpenAPI spec version: 2.2.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.Net;
using VmosoApiClient.Api;
using VmosoApiClient.Model;
using System.Security.Cryptography;
using System.Text;

namespace VmosoApiClient.Client
{
    /// <summary>
    /// Represents a Vmoso Session. It manages login and authentication
    /// </summary>
    public partial class VmosoSession
    {
        private static readonly DateTime Jan1st1970 = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

        private static String ATOKEN_TEMPLATE = "ATOKEN id=\"{0}\", token=\"{1}\", tstamp=\"{2}\", userid=\"{3}\"";
	    private static String OTP_TOKEN_TEMPLATE = "OTP token=\"{0}\", timestamp=\"{1}\", nonce=\"{2}\", code=\"{3}\"";

        /// <summary>
        /// Vmoso Host URL used in session
        /// </summary>
        public String Host { get; set; }
        private String ClientId;

        public String OriginalHost { get; set; }

        private String Username;
        public String UserKey { get; set; }
        private String Token;
        private String Secret;
        private String Who;
        
        private String OtpHeader;
        private String ATokenHeader;

        private ApiClient apiClient;

        private static String SERVICE_PATH = "/svc";

        /// <summary>
        /// Initializes a new instance of the <see cref="VmosoSession"/> class
        /// </summary>
        /// <param name="host">Host URL</param>
        /// <param name="clientId">Client Id</param>
        /// <returns></returns>
        public VmosoSession(String host, String clientId)
        {
            apiClient = new ApiClient();
            
            ClientId = clientId;
            if(host!= null) { 
                if(host.EndsWith("/"))
                {
                    host = host.Substring(0, host.Length - 1);
                }

                apiClient.Configuration.ApiClient.RestClient.BaseUrl = new Uri(host + "/" + SERVICE_PATH);
                Host = host;
            }

        }

        public void setProxy(String proxyHost, int proxyPort, String proxyUser, String proxyPassword)
        {
            if(proxyHost!=null)
            {
                WebProxy p = new WebProxy(proxyHost, proxyPort);
                p.BypassProxyOnLocal = false;
                if(proxyUser!=null && proxyPassword!=null)
                {
                    p.Credentials = new NetworkCredential(proxyUser, proxyPassword);
                }
                apiClient.Configuration.ApiClient.RestClient.Proxy = p;
            }
            else
            {
                return;
            }

        }

        /// <summary>
        /// Login action
        /// </summary>
        /// <param name="username">User name/email</param>
        /// <param name="password">User password</param>
        /// <returns></returns>
        public void Login(String username, String password) 
        {
            this.Username = username;

            var userApi = new UserApi(apiClient);

            var auth = new AuthnInfoRecord();
            auth.Type = "password";
            auth.Username = username;
            auth.Password = password;

            var loginInput = new LoginInput("", "", false, "", auth, "", "", ClientId, "", "");

            try
            {
                LoginResult loginResult = userApi.Login(loginInput);
                if (loginResult.Hdr.Rc == 0)
                {
                    SessionCredentialRecord cred = loginResult.Cred;
                    Token = cred.Token;
                    Secret = cred.Secret;
                    Who = cred.Who;
                    UserKey = loginResult.User.Key;
                    ClientId = Who;

                    RefreshToken();

                    var newHost = cred.Svcpoint;
                    if (newHost != null && newHost != "")
                    {
                        if (newHost.EndsWith("/"))
                        {
                            newHost = newHost.Substring(0, newHost.Length - 1);
                        }
                        apiClient.Configuration.ApiClient.RestClient.BaseUrl = new Uri(newHost + "/" + SERVICE_PATH);
                        OriginalHost = Host;
                        Host = newHost;
                    }
                }
                else
                {
                    throw new ApiException(0, "Login error " + loginResult.Hdr.Rc);
                }
            }
            catch (ApiException e)
            {
                throw e;
            }
        }

        /// <summary>
        /// Get Api client for the session. This ApiClient is used as constructor parameter when using Apis
        /// </summary>
        /// <returns>ApiClient</returns>
        public ApiClient GetApiClient()
        {
            return GetApiClient(true);
        }

        /// <summary>
        /// Get Api client for the session. This ApiClient is used as constructor parameter when using Apis
        /// </summary>
        /// <param name="refreshToken">Refresh Token</param>
        /// <returns>ApiClient</returns>
        public ApiClient GetApiClient(Boolean refreshToken)
        {
            if(refreshToken) RefreshToken();
            return apiClient;
        }

        /// <summary>
        /// Refresh token in session
        /// </summary>
        /// <returns></returns>
        public void RefreshToken()
        {
            generateOtpHeader();
            apiClient.Configuration.ApiKey.Remove("X-CV-Authorization");
            apiClient.Configuration.ApiKey.Add("X-CV-Authorization", GetAuthorizationHeader());
        }

        /// <summary>
        /// It returns the X-CV-Authorization header used to call private requests
        /// </summary>
        /// <returns>Header string</returns>
        public String GetAuthorizationHeader()
        {

            if (Who != null && !Who.StartsWith("GEN-") && !Who.StartsWith("CID-"))
            {
                return getOtpHeader();
            }
            else
            {
                return getATokenHeader();
            }
        }

        private String getOtpHeader()
        {
            if(OtpHeader == null) generateOtpHeader();
            return OtpHeader;
        }
        
        private String getATokenHeader()
        {
            if (ATokenHeader == null) generateATokenHeader();
            return ATokenHeader;
        }

        private void generateOtpHeader()
        {
            long now = currentTimeMillis();
            long tstamp = now / 1000L;

            long PRIME = 100003L;
            String nonce = "x-" + ((tstamp * 1000L) % PRIME); //Same as API Developer Guide

            String desc = tstamp
                + ":" + Secret
                + ":" + md5("OTP")
                + ":nonce=" + nonce;
            String code = sha1(desc);

            String tokenHeader = String.Format(OTP_TOKEN_TEMPLATE,
                    Token, tstamp, nonce, code);

            OtpHeader = tokenHeader;
        }


        private void generateATokenHeader()
        {
            long now = currentTimeMillis();
            long tstamp = now / 1000L;

            if (Token == null)
            {
                return;
            }

            String md5Token = Token + ":md5:" + md5(Token + tstamp + Secret);

            String tokenHeader = String.Format(ATOKEN_TEMPLATE,
                Who, md5Token, tstamp,
                Username);

            ATokenHeader = tokenHeader;
        }

        private static string md5(string input)
        {

            MD5 md5Hash = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();
        }

        private String sha1(String input)
        {
            SHA1 sha1Hash = SHA1.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha1Hash.ComputeHash(encoding.GetBytes(input));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();
        }

        private long currentTimeMillis()
        {
            return (long)(DateTime.UtcNow - Jan1st1970).TotalMilliseconds;
        }
    }



}
