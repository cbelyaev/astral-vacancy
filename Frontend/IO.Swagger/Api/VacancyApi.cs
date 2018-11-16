/* 
 * Vacancy API
 *
 * Web API for AstralVacancy task project.
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IVacancyApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Удаляет вакансию
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Идентификатор удаляемой вакансии</param>
        /// <returns></returns>
        void DeleteVacancy (int? id);

        /// <summary>
        /// Удаляет вакансию
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Идентификатор удаляемой вакансии</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> DeleteVacancyWithHttpInfo (int? id);
        /// <summary>
        /// Ищет вакансии в локальном хранилище
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text">Подстрока поиска (optional)</param>
        /// <returns>List&lt;VacancyDto&gt;</returns>
        List<VacancyDto> FindVacancies (string text = null);

        /// <summary>
        /// Ищет вакансии в локальном хранилище
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text">Подстрока поиска (optional)</param>
        /// <returns>ApiResponse of List&lt;VacancyDto&gt;</returns>
        ApiResponse<List<VacancyDto>> FindVacanciesWithHttpInfo (string text = null);
        /// <summary>
        /// Ищет вакансию по идентификатору
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Идентификатор вакансии</param>
        /// <returns>VacancyDto</returns>
        VacancyDto GetVacancy (int? id);

        /// <summary>
        /// Ищет вакансию по идентификатору
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Идентификатор вакансии</param>
        /// <returns>ApiResponse of VacancyDto</returns>
        ApiResponse<VacancyDto> GetVacancyWithHttpInfo (int? id);
        /// <summary>
        /// Добавляет в локальное хранилище новые вакансии из внешнего источника
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VacanciesUpdateResultDto</returns>
        VacanciesUpdateResultDto UpdateVacancies ();

        /// <summary>
        /// Добавляет в локальное хранилище новые вакансии из внешнего источника
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VacanciesUpdateResultDto</returns>
        ApiResponse<VacanciesUpdateResultDto> UpdateVacanciesWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Удаляет вакансию
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Идентификатор удаляемой вакансии</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task DeleteVacancyAsync (int? id);

        /// <summary>
        /// Удаляет вакансию
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Идентификатор удаляемой вакансии</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> DeleteVacancyAsyncWithHttpInfo (int? id);
        /// <summary>
        /// Ищет вакансии в локальном хранилище
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text">Подстрока поиска (optional)</param>
        /// <returns>Task of List&lt;VacancyDto&gt;</returns>
        System.Threading.Tasks.Task<List<VacancyDto>> FindVacanciesAsync (string text = null);

        /// <summary>
        /// Ищет вакансии в локальном хранилище
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text">Подстрока поиска (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;VacancyDto&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<VacancyDto>>> FindVacanciesAsyncWithHttpInfo (string text = null);
        /// <summary>
        /// Ищет вакансию по идентификатору
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Идентификатор вакансии</param>
        /// <returns>Task of VacancyDto</returns>
        System.Threading.Tasks.Task<VacancyDto> GetVacancyAsync (int? id);

        /// <summary>
        /// Ищет вакансию по идентификатору
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Идентификатор вакансии</param>
        /// <returns>Task of ApiResponse (VacancyDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<VacancyDto>> GetVacancyAsyncWithHttpInfo (int? id);
        /// <summary>
        /// Добавляет в локальное хранилище новые вакансии из внешнего источника
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VacanciesUpdateResultDto</returns>
        System.Threading.Tasks.Task<VacanciesUpdateResultDto> UpdateVacanciesAsync ();

        /// <summary>
        /// Добавляет в локальное хранилище новые вакансии из внешнего источника
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VacanciesUpdateResultDto)</returns>
        System.Threading.Tasks.Task<ApiResponse<VacanciesUpdateResultDto>> UpdateVacanciesAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class VacancyApi : IVacancyApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="VacancyApi"/> class.
        /// </summary>
        /// <returns></returns>
        public VacancyApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VacancyApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public VacancyApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
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
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        /// Удаляет вакансию 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Идентификатор удаляемой вакансии</param>
        /// <returns></returns>
        public void DeleteVacancy (int? id)
        {
             DeleteVacancyWithHttpInfo(id);
        }

        /// <summary>
        /// Удаляет вакансию 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Идентификатор удаляемой вакансии</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> DeleteVacancyWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling VacancyApi->DeleteVacancy");

            var localVarPath = "/api/vacancy/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteVacancy", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Удаляет вакансию 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Идентификатор удаляемой вакансии</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task DeleteVacancyAsync (int? id)
        {
             await DeleteVacancyAsyncWithHttpInfo(id);

        }

        /// <summary>
        /// Удаляет вакансию 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Идентификатор удаляемой вакансии</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> DeleteVacancyAsyncWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling VacancyApi->DeleteVacancy");

            var localVarPath = "/api/vacancy/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteVacancy", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Ищет вакансии в локальном хранилище 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text">Подстрока поиска (optional)</param>
        /// <returns>List&lt;VacancyDto&gt;</returns>
        public List<VacancyDto> FindVacancies (string text = null)
        {
             ApiResponse<List<VacancyDto>> localVarResponse = FindVacanciesWithHttpInfo(text);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Ищет вакансии в локальном хранилище 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text">Подстрока поиска (optional)</param>
        /// <returns>ApiResponse of List&lt;VacancyDto&gt;</returns>
        public ApiResponse< List<VacancyDto> > FindVacanciesWithHttpInfo (string text = null)
        {

            var localVarPath = "/api/vacancies";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (text != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "text", text)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FindVacancies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<VacancyDto>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<VacancyDto>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<VacancyDto>)));
        }

        /// <summary>
        /// Ищет вакансии в локальном хранилище 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text">Подстрока поиска (optional)</param>
        /// <returns>Task of List&lt;VacancyDto&gt;</returns>
        public async System.Threading.Tasks.Task<List<VacancyDto>> FindVacanciesAsync (string text = null)
        {
             ApiResponse<List<VacancyDto>> localVarResponse = await FindVacanciesAsyncWithHttpInfo(text);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Ищет вакансии в локальном хранилище 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="text">Подстрока поиска (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;VacancyDto&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<VacancyDto>>> FindVacanciesAsyncWithHttpInfo (string text = null)
        {

            var localVarPath = "/api/vacancies";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (text != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "text", text)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("FindVacancies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<VacancyDto>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<VacancyDto>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<VacancyDto>)));
        }

        /// <summary>
        /// Ищет вакансию по идентификатору 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Идентификатор вакансии</param>
        /// <returns>VacancyDto</returns>
        public VacancyDto GetVacancy (int? id)
        {
             ApiResponse<VacancyDto> localVarResponse = GetVacancyWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Ищет вакансию по идентификатору 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Идентификатор вакансии</param>
        /// <returns>ApiResponse of VacancyDto</returns>
        public ApiResponse< VacancyDto > GetVacancyWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling VacancyApi->GetVacancy");

            var localVarPath = "/api/vacancy/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetVacancy", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VacancyDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VacancyDto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VacancyDto)));
        }

        /// <summary>
        /// Ищет вакансию по идентификатору 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Идентификатор вакансии</param>
        /// <returns>Task of VacancyDto</returns>
        public async System.Threading.Tasks.Task<VacancyDto> GetVacancyAsync (int? id)
        {
             ApiResponse<VacancyDto> localVarResponse = await GetVacancyAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Ищет вакансию по идентификатору 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Идентификатор вакансии</param>
        /// <returns>Task of ApiResponse (VacancyDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VacancyDto>> GetVacancyAsyncWithHttpInfo (int? id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling VacancyApi->GetVacancy");

            var localVarPath = "/api/vacancy/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetVacancy", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VacancyDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VacancyDto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VacancyDto)));
        }

        /// <summary>
        /// Добавляет в локальное хранилище новые вакансии из внешнего источника 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>VacanciesUpdateResultDto</returns>
        public VacanciesUpdateResultDto UpdateVacancies ()
        {
             ApiResponse<VacanciesUpdateResultDto> localVarResponse = UpdateVacanciesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Добавляет в локальное хранилище новые вакансии из внешнего источника 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of VacanciesUpdateResultDto</returns>
        public ApiResponse< VacanciesUpdateResultDto > UpdateVacanciesWithHttpInfo ()
        {

            var localVarPath = "/api/vacancies/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateVacancies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VacanciesUpdateResultDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VacanciesUpdateResultDto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VacanciesUpdateResultDto)));
        }

        /// <summary>
        /// Добавляет в локальное хранилище новые вакансии из внешнего источника 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of VacanciesUpdateResultDto</returns>
        public async System.Threading.Tasks.Task<VacanciesUpdateResultDto> UpdateVacanciesAsync ()
        {
             ApiResponse<VacanciesUpdateResultDto> localVarResponse = await UpdateVacanciesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Добавляет в локальное хранилище новые вакансии из внешнего источника 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (VacanciesUpdateResultDto)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<VacanciesUpdateResultDto>> UpdateVacanciesAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/vacancies/update";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("UpdateVacancies", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<VacanciesUpdateResultDto>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (VacanciesUpdateResultDto) Configuration.ApiClient.Deserialize(localVarResponse, typeof(VacanciesUpdateResultDto)));
        }

    }
}