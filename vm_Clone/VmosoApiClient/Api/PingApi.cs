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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using VmosoApiClient.Client;
using VmosoApiClient.Model;

namespace VmosoApiClient.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IPingApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">PerformAction Input</param>
        /// <returns>PerformActionResult</returns>
        PerformActionResult PerformAction (PerformActionInput input);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">PerformAction Input</param>
        /// <returns>ApiResponse of PerformActionResult</returns>
        ApiResponse<PerformActionResult> PerformActionWithHttpInfo (PerformActionInput input);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">PerformAction Input</param>
        /// <returns>Task of PerformActionResult</returns>
        System.Threading.Tasks.Task<PerformActionResult> PerformActionAsync (PerformActionInput input);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">PerformAction Input</param>
        /// <returns>Task of ApiResponse (PerformActionResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<PerformActionResult>> PerformActionAsyncWithHttpInfo (PerformActionInput input);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class PingApi : IPingApi
    {
        private VmosoApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="PingApi"/> class.
        /// </summary>
        /// <param name="configuration">An ApiClient</param>
        /// <returns></returns>
        public PingApi(ApiClient apiClient)
        {
            this.Configuration = apiClient.Configuration;

            ExceptionFactory = VmosoApiClient.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            //if (Configuration.ApiClient.Configuration == null)
            //{
            this.Configuration.ApiClient.Configuration = this.Configuration;
            //}
        }
 
        /// <summary>
        /// Initializes a new instance of the <see cref="PingApi"/> class.
        /// </summary>
        /// <param name="basePath">A base path</param>
        /// <returns></returns>
        public PingApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = VmosoApiClient.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PingApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public PingApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = VmosoApiClient.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public VmosoApiClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">PerformAction Input</param>
        /// <returns>PerformActionResult</returns>
        public PerformActionResult PerformAction (PerformActionInput input)
        {
             ApiResponse<PerformActionResult> localVarResponse = PerformActionWithHttpInfo(input);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">PerformAction Input</param>
        /// <returns>ApiResponse of PerformActionResult</returns>
        public ApiResponse< PerformActionResult > PerformActionWithHttpInfo (PerformActionInput input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling PingApi->PerformAction");

            var localVarPath = "/ping";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
            }

            // authentication (vmoso_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-CV-Authorization")))
            {
                localVarHeaderParams["X-CV-Authorization"] = Configuration.GetApiKeyWithPrefix("X-CV-Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PerformAction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PerformActionResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PerformActionResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformActionResult)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">PerformAction Input</param>
        /// <returns>Task of PerformActionResult</returns>
        public async System.Threading.Tasks.Task<PerformActionResult> PerformActionAsync (PerformActionInput input)
        {
             ApiResponse<PerformActionResult> localVarResponse = await PerformActionAsyncWithHttpInfo(input);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">PerformAction Input</param>
        /// <returns>Task of ApiResponse (PerformActionResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<PerformActionResult>> PerformActionAsyncWithHttpInfo (PerformActionInput input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling PingApi->PerformAction");

            var localVarPath = "/ping";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (input != null && input.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(input); // http body (model) parameter
            }
            else
            {
                localVarPostBody = input; // byte array
            }

            // authentication (vmoso_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-CV-Authorization")))
            {
                localVarHeaderParams["X-CV-Authorization"] = Configuration.GetApiKeyWithPrefix("X-CV-Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("PerformAction", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<PerformActionResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (PerformActionResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(PerformActionResult)));
            
        }

    }
}
