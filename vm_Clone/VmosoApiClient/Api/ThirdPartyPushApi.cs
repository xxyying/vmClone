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
    public interface IThirdPartyPushApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Set 3rd party receive push url
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceKey"></param>
        /// <param name="input">SetReceiveUrl Input</param>
        /// <returns>SetReceiveUrlResult</returns>
        SetReceiveUrlResult SetReceiveUrl (string spaceKey, SetReceiveUrlInput input);

        /// <summary>
        /// Set 3rd party receive push url
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceKey"></param>
        /// <param name="input">SetReceiveUrl Input</param>
        /// <returns>ApiResponse of SetReceiveUrlResult</returns>
        ApiResponse<SetReceiveUrlResult> SetReceiveUrlWithHttpInfo (string spaceKey, SetReceiveUrlInput input);
        /// <summary>
        /// Set 3rd party object to send push
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceKey"></param>
        /// <param name="objectKey"></param>
        /// <returns>SetRequesterResult</returns>
        SetRequesterResult SetRequester (string spaceKey, string objectKey);

        /// <summary>
        /// Set 3rd party object to send push
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceKey"></param>
        /// <param name="objectKey"></param>
        /// <returns>ApiResponse of SetRequesterResult</returns>
        ApiResponse<SetRequesterResult> SetRequesterWithHttpInfo (string spaceKey, string objectKey);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Set 3rd party receive push url
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceKey"></param>
        /// <param name="input">SetReceiveUrl Input</param>
        /// <returns>Task of SetReceiveUrlResult</returns>
        System.Threading.Tasks.Task<SetReceiveUrlResult> SetReceiveUrlAsync (string spaceKey, SetReceiveUrlInput input);

        /// <summary>
        /// Set 3rd party receive push url
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceKey"></param>
        /// <param name="input">SetReceiveUrl Input</param>
        /// <returns>Task of ApiResponse (SetReceiveUrlResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<SetReceiveUrlResult>> SetReceiveUrlAsyncWithHttpInfo (string spaceKey, SetReceiveUrlInput input);
        /// <summary>
        /// Set 3rd party object to send push
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceKey"></param>
        /// <param name="objectKey"></param>
        /// <returns>Task of SetRequesterResult</returns>
        System.Threading.Tasks.Task<SetRequesterResult> SetRequesterAsync (string spaceKey, string objectKey);

        /// <summary>
        /// Set 3rd party object to send push
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceKey"></param>
        /// <param name="objectKey"></param>
        /// <returns>Task of ApiResponse (SetRequesterResult)</returns>
        System.Threading.Tasks.Task<ApiResponse<SetRequesterResult>> SetRequesterAsyncWithHttpInfo (string spaceKey, string objectKey);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ThirdPartyPushApi : IThirdPartyPushApi
    {
        private VmosoApiClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThirdPartyPushApi"/> class.
        /// </summary>
        /// <param name="configuration">An ApiClient</param>
        /// <returns></returns>
        public ThirdPartyPushApi(ApiClient apiClient)
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
        /// Initializes a new instance of the <see cref="ThirdPartyPushApi"/> class.
        /// </summary>
        /// <param name="basePath">A base path</param>
        /// <returns></returns>
        public ThirdPartyPushApi(String basePath)
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
        /// Initializes a new instance of the <see cref="ThirdPartyPushApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ThirdPartyPushApi(Configuration configuration = null)
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
        /// Set 3rd party receive push url 
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceKey"></param>
        /// <param name="input">SetReceiveUrl Input</param>
        /// <returns>SetReceiveUrlResult</returns>
        public SetReceiveUrlResult SetReceiveUrl (string spaceKey, SetReceiveUrlInput input)
        {
             ApiResponse<SetReceiveUrlResult> localVarResponse = SetReceiveUrlWithHttpInfo(spaceKey, input);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Set 3rd party receive push url 
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceKey"></param>
        /// <param name="input">SetReceiveUrl Input</param>
        /// <returns>ApiResponse of SetReceiveUrlResult</returns>
        public ApiResponse< SetReceiveUrlResult > SetReceiveUrlWithHttpInfo (string spaceKey, SetReceiveUrlInput input)
        {
            // verify the required parameter 'spaceKey' is set
            if (spaceKey == null)
                throw new ApiException(400, "Missing required parameter 'spaceKey' when calling ThirdPartyPushApi->SetReceiveUrl");
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling ThirdPartyPushApi->SetReceiveUrl");

            var localVarPath = "/thirdPartyPush/{spaceKey}/setUrl";
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
            if (spaceKey != null) localVarPathParams.Add("spaceKey", Configuration.ApiClient.ParameterToString(spaceKey)); // path parameter
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SetReceiveUrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SetReceiveUrlResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SetReceiveUrlResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SetReceiveUrlResult)));
            
        }

        /// <summary>
        /// Set 3rd party receive push url 
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceKey"></param>
        /// <param name="input">SetReceiveUrl Input</param>
        /// <returns>Task of SetReceiveUrlResult</returns>
        public async System.Threading.Tasks.Task<SetReceiveUrlResult> SetReceiveUrlAsync (string spaceKey, SetReceiveUrlInput input)
        {
             ApiResponse<SetReceiveUrlResult> localVarResponse = await SetReceiveUrlAsyncWithHttpInfo(spaceKey, input);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Set 3rd party receive push url 
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceKey"></param>
        /// <param name="input">SetReceiveUrl Input</param>
        /// <returns>Task of ApiResponse (SetReceiveUrlResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SetReceiveUrlResult>> SetReceiveUrlAsyncWithHttpInfo (string spaceKey, SetReceiveUrlInput input)
        {
            // verify the required parameter 'spaceKey' is set
            if (spaceKey == null)
                throw new ApiException(400, "Missing required parameter 'spaceKey' when calling ThirdPartyPushApi->SetReceiveUrl");
            // verify the required parameter 'input' is set
            if (input == null)
                throw new ApiException(400, "Missing required parameter 'input' when calling ThirdPartyPushApi->SetReceiveUrl");

            var localVarPath = "/thirdPartyPush/{spaceKey}/setUrl";
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
            if (spaceKey != null) localVarPathParams.Add("spaceKey", Configuration.ApiClient.ParameterToString(spaceKey)); // path parameter
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
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SetReceiveUrl", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SetReceiveUrlResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SetReceiveUrlResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SetReceiveUrlResult)));
            
        }

        /// <summary>
        /// Set 3rd party object to send push 
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceKey"></param>
        /// <param name="objectKey"></param>
        /// <returns>SetRequesterResult</returns>
        public SetRequesterResult SetRequester (string spaceKey, string objectKey)
        {
             ApiResponse<SetRequesterResult> localVarResponse = SetRequesterWithHttpInfo(spaceKey, objectKey);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Set 3rd party object to send push 
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceKey"></param>
        /// <param name="objectKey"></param>
        /// <returns>ApiResponse of SetRequesterResult</returns>
        public ApiResponse< SetRequesterResult > SetRequesterWithHttpInfo (string spaceKey, string objectKey)
        {
            // verify the required parameter 'spaceKey' is set
            if (spaceKey == null)
                throw new ApiException(400, "Missing required parameter 'spaceKey' when calling ThirdPartyPushApi->SetRequester");
            // verify the required parameter 'objectKey' is set
            if (objectKey == null)
                throw new ApiException(400, "Missing required parameter 'objectKey' when calling ThirdPartyPushApi->SetRequester");

            var localVarPath = "/thirdPartyPush/{spaceKey}/setRequester/{objectKey}";
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
            if (spaceKey != null) localVarPathParams.Add("spaceKey", Configuration.ApiClient.ParameterToString(spaceKey)); // path parameter
            if (objectKey != null) localVarPathParams.Add("objectKey", Configuration.ApiClient.ParameterToString(objectKey)); // path parameter

            // authentication (vmoso_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-CV-Authorization")))
            {
                localVarHeaderParams["X-CV-Authorization"] = Configuration.GetApiKeyWithPrefix("X-CV-Authorization");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SetRequester", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SetRequesterResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SetRequesterResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SetRequesterResult)));
            
        }

        /// <summary>
        /// Set 3rd party object to send push 
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceKey"></param>
        /// <param name="objectKey"></param>
        /// <returns>Task of SetRequesterResult</returns>
        public async System.Threading.Tasks.Task<SetRequesterResult> SetRequesterAsync (string spaceKey, string objectKey)
        {
             ApiResponse<SetRequesterResult> localVarResponse = await SetRequesterAsyncWithHttpInfo(spaceKey, objectKey);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Set 3rd party object to send push 
        /// </summary>
        /// <exception cref="VmosoApiClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceKey"></param>
        /// <param name="objectKey"></param>
        /// <returns>Task of ApiResponse (SetRequesterResult)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<SetRequesterResult>> SetRequesterAsyncWithHttpInfo (string spaceKey, string objectKey)
        {
            // verify the required parameter 'spaceKey' is set
            if (spaceKey == null)
                throw new ApiException(400, "Missing required parameter 'spaceKey' when calling ThirdPartyPushApi->SetRequester");
            // verify the required parameter 'objectKey' is set
            if (objectKey == null)
                throw new ApiException(400, "Missing required parameter 'objectKey' when calling ThirdPartyPushApi->SetRequester");

            var localVarPath = "/thirdPartyPush/{spaceKey}/setRequester/{objectKey}";
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
            if (spaceKey != null) localVarPathParams.Add("spaceKey", Configuration.ApiClient.ParameterToString(spaceKey)); // path parameter
            if (objectKey != null) localVarPathParams.Add("objectKey", Configuration.ApiClient.ParameterToString(objectKey)); // path parameter

            // authentication (vmoso_auth) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("X-CV-Authorization")))
            {
                localVarHeaderParams["X-CV-Authorization"] = Configuration.GetApiKeyWithPrefix("X-CV-Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SetRequester", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<SetRequesterResult>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (SetRequesterResult) Configuration.ApiClient.Deserialize(localVarResponse, typeof(SetRequesterResult)));
            
        }

    }
}
