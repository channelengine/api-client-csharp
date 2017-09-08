/* 
 * ChannelEngine API V2
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: 2.3.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using ChannelEngine.Api.Client.Client;

namespace ChannelEngine.Api.Client.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IClientApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get API Client
        /// </summary>
        /// <remarks>
        /// This call generates a Swagger API client and returns it as a ZIP
        /// </remarks>
        /// <exception cref="ChannelEngine.Api.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The programming language</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream ClientGet (string language);

        /// <summary>
        /// Get API Client
        /// </summary>
        /// <remarks>
        /// This call generates a Swagger API client and returns it as a ZIP
        /// </remarks>
        /// <exception cref="ChannelEngine.Api.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The programming language</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> ClientGetWithHttpInfo (string language);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get API Client
        /// </summary>
        /// <remarks>
        /// This call generates a Swagger API client and returns it as a ZIP
        /// </remarks>
        /// <exception cref="ChannelEngine.Api.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The programming language</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> ClientGetAsync (string language);

        /// <summary>
        /// Get API Client
        /// </summary>
        /// <remarks>
        /// This call generates a Swagger API client and returns it as a ZIP
        /// </remarks>
        /// <exception cref="ChannelEngine.Api.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The programming language</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> ClientGetAsyncWithHttpInfo (string language);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class ClientApi : IClientApi
    {
        private ChannelEngine.Api.Client.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientApi"/> class.
        /// </summary>
        /// <returns></returns>
        public ClientApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = ChannelEngine.Api.Client.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ClientApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public ClientApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = ChannelEngine.Api.Client.Client.Configuration.DefaultExceptionFactory;

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
        public ChannelEngine.Api.Client.Client.ExceptionFactory ExceptionFactory
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
        /// Get API Client This call generates a Swagger API client and returns it as a ZIP
        /// </summary>
        /// <exception cref="ChannelEngine.Api.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The programming language</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream ClientGet (string language)
        {
             ApiResponse<System.IO.Stream> localVarResponse = ClientGetWithHttpInfo(language);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get API Client This call generates a Swagger API client and returns it as a ZIP
        /// </summary>
        /// <exception cref="ChannelEngine.Api.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The programming language</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse< System.IO.Stream > ClientGetWithHttpInfo (string language)
        {
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling ClientApi->ClientGet");

            var localVarPath = "/v2/clients/{language}";
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
                "application/zip"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (language != null) localVarPathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarQueryParams["apikey"] = Configuration.GetApiKeyWithPrefix("apikey");
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ClientGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
            
        }

        /// <summary>
        /// Get API Client This call generates a Swagger API client and returns it as a ZIP
        /// </summary>
        /// <exception cref="ChannelEngine.Api.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The programming language</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> ClientGetAsync (string language)
        {
             ApiResponse<System.IO.Stream> localVarResponse = await ClientGetAsyncWithHttpInfo(language);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get API Client This call generates a Swagger API client and returns it as a ZIP
        /// </summary>
        /// <exception cref="ChannelEngine.Api.Client.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="language">The programming language</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> ClientGetAsyncWithHttpInfo (string language)
        {
            // verify the required parameter 'language' is set
            if (language == null)
                throw new ApiException(400, "Missing required parameter 'language' when calling ClientApi->ClientGet");

            var localVarPath = "/v2/clients/{language}";
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
                "application/zip"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // set "format" to json by default
            // e.g. /pet/{petId}.{format} becomes /pet/{petId}.json
            localVarPathParams.Add("format", "json");
            if (language != null) localVarPathParams.Add("language", Configuration.ApiClient.ParameterToString(language)); // path parameter

            // authentication (apikey) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("apikey")))
            {
                localVarQueryParams["apikey"] = Configuration.GetApiKeyWithPrefix("apikey");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("ClientGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (System.IO.Stream) Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
            
        }

    }
}
