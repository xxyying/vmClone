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
    public interface IVrlApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">CreateVrl Input</param>
        /// <returns>CreateVrlResult</returns>
        CreateVrlResult CreateVrl (CreateVrlInput input);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">CreateVrl Input</param>
        /// <returns>ApiResponse of CreateVrlResult</returns>
        ApiResponse<CreateVrlResult> CreateVrlWithHttpInfo (CreateVrlInput input);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vrl"></param>
        /// <returns>GetVrlResult</returns>
        GetVrlResult GetVrl (string vrl);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vrl"></param>
        /// <returns>ApiResponse of GetVrlResult</returns>
        ApiResponse<GetVrlResult> GetVrlWithHttpInfo (string vrl);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">CreateVrl Input</param>
        /// <returns>Task of CreateVrlResult</returns>
        System.Threading.Tasks.Task<CreateVrlResult> CreateVrlAsync (CreateVrlInput input);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">CreateVrl Input</param>
        /// <returns>Task of ApiResponse (CreateVrlResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<CreateVrlResult>> CreateVrlAsyncWithHttpInfo (CreateVrlInput input);
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vrl"></param>
        /// <returns>Task of GetVrlResult</returns>
        System.Threading.Tasks.Task<GetVrlResult> GetVrlAsync (string vrl);

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vrl"></param>
        /// <returns>Task of ApiResponse (GetVrlResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetVrlResult>> GetVrlAsyncWithHttpInfo (string vrl);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VrlApi : IVrlApi
    {
        private VmosoApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VrlApi"/> class.
        /// </summary>
        /// <param name="configuration">An ApiClient</param>
        /// <returns></returns>
        public VrlApi(ApiClient apiClient)
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
        /// Initializes a new instance of the <see cref="VrlApi"/> class.
        /// </summary>
        /// <param name="basePath">A base path</param>
        /// <returns></returns>
        public VrlApi(String basePath)
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
        /// Initializes a new instance of the <see cref="VrlApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VrlApi(Configuration configuration = null)
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
        /// <param name="input">CreateVrl Input</param>
        /// <returns>CreateVrlResult</returns>
        public CreateVrlResult CreateVrl (CreateVrlInput input)
        {
             ApiResponse<CreateVrlResult> localVarResponse = CreateVrlWithHttpInfo(input);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">CreateVrl Input</param>
        /// <returns>ApiResponse of CreateVrlResult</returns>
        public ApiResponse< CreateVrlResult > CreateVrlWithHttpInfo (CreateVrlInput input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling VrlApi->CreateVrl");

            var localVarPath = "/vrls";
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
                Exception exception = ExceptionFactory("CreateVrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateVrlResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateVrlResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateVrlResult)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">CreateVrl Input</param>
        /// <returns>Task of CreateVrlResult</returns>
        public async System.Threading.Tasks.Task<CreateVrlResult> CreateVrlAsync (CreateVrlInput input)
        {
             ApiResponse<CreateVrlResult> localVarResponse = await CreateVrlAsyncWithHttpInfo(input);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="input">CreateVrl Input</param>
        /// <returns>Task of ApiResponse (CreateVrlResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<CreateVrlResult>> CreateVrlAsyncWithHttpInfo (CreateVrlInput input)
        {
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling VrlApi->CreateVrl");

            var localVarPath = "/vrls";
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
                Exception exception = ExceptionFactory("CreateVrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<CreateVrlResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (CreateVrlResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(CreateVrlResult)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vrl"></param>
        /// <returns>GetVrlResult</returns>
        public GetVrlResult GetVrl (string vrl)
        {
             ApiResponse<GetVrlResult> localVarResponse = GetVrlWithHttpInfo(vrl);
             return localVarResponse.Data;
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vrl"></param>
        /// <returns>ApiResponse of GetVrlResult</returns>
        public ApiResponse< GetVrlResult > GetVrlWithHttpInfo (string vrl)
        {
            // verify the required parameter 'vrl' is set
            if (vrl == null)
                throw new ApiException(400, "Missing required parameter 'vrl' when calling VrlApi->GetVrl");

            var localVarPath = "/vrls";
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
            if (vrl != null) localVarQueryParams.Add("vrl", Configuration.ApiClient.ParameterToString(vrl)); // query parameter

            // authentication (vmoso_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-CV-Authorization")))
            {
                localVarHeaderParams["X-CV-Authorization"] = Configuration.GetApiKeyWithPrefix("X-CV-Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetVrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetVrlResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetVrlResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetVrlResult)));
            
        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vrl"></param>
        /// <returns>Task of GetVrlResult</returns>
        public async System.Threading.Tasks.Task<GetVrlResult> GetVrlAsync (string vrl)
        {
             ApiResponse<GetVrlResult> localVarResponse = await GetVrlAsyncWithHttpInfo(vrl);
             return localVarResponse.Data;

        }

        /// <summary>
        ///  
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="vrl"></param>
        /// <returns>Task of ApiResponse (GetVrlResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetVrlResult>> GetVrlAsyncWithHttpInfo (string vrl)
        {
            // verify the required parameter 'vrl' is set
            if (vrl == null)
                throw new ApiException(400, "Missing required parameter 'vrl' when calling VrlApi->GetVrl");

            var localVarPath = "/vrls";
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
            if (vrl != null) localVarQueryParams.Add("vrl", Configuration.ApiClient.ParameterToString(vrl)); // query parameter

            // authentication (vmoso_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-CV-Authorization")))
            {
                localVarHeaderParams["X-CV-Authorization"] = Configuration.GetApiKeyWithPrefix("X-CV-Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetVrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetVrlResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetVrlResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetVrlResult)));
            
        }

    }
}
