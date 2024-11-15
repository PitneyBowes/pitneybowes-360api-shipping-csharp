/*
 * Shipping APIs
 *
 * ### Introduction  The Shipping APIs include a variety of operations that allow users to manage and track their shipping requests.   Some of the key API operations available in the Shipping API includes: ### Shipment API  | Operation      | Description | | - -- -- -- -- -- | - -- -- -- -- -- |  | Get Carriers    | This operation fetches all onboarded carriers. Typically, user will use this service to get list of onboarded carriers and supported properties for those carriers.  |  | Get Countries | This operation fetches list of supported destination countries for a provided carrier and origin country.  |  | Get Services | This operation fetches a list of supported services for a carrier with respect to specific origin and destination country. |  | Get ParcelTypes| This operation fetches ParcelTypes based on carrier, origin and destination country. |  | Get Special Services| This operation fetches Special Services for a given carrier, service, origin and destination country. |  | Get Carrier Accounts| This operation retrieves onboarded Carriers with their Carrier Account Ids which uniquely identify multiple accounts of same carrier.  |  | Rate Shop and Get Single Rate| This API contains 2 operations, rate shop and single rate. Rate shop will fetch rates for all carrier services based on the given addresses (From and To), weight, and dimension for given parcelType. Single rate will get rate for specific service and special service (if requested) based on the given addresses (From and To), weight, and dimension, parcelType and serviceId with or without specialServices. Single rate will be used mainly to a rate a shipment before creating shipment.  |  | Create Shipment| This operation creates a new Shipment or Shipment Label. This is for both Domestic and International. | | Get All Shipments| This operation fetches all created Shipments. |  | Get Shipment by Id| Retrieves single shipment using Shipment Id. |  | Reprint Shipment| This operation reprints Shipment by the shipmentId. It retrieves an existing shipping label to reprint. The API sends the shipmentId returned by the original Created Shipment request. Use this only if the shipping label in the Create Shipment response was spoilt or lost. |  | Cancel Shipment| This operation cancels previously created shipment. |  
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace com.pitneybowes.api360.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddressApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Address Suggest
        /// </summary>
        /// <remarks>
        /// This operation displays a valid address to match the entered address, only if the address does not seem valid to the system address map. User can select the suggested address or edit the entered address to make it valid.
        /// </remarks>
        /// <exception cref="com.pitneybowes.api360.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressSuggestRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AddressSuggestResponse</returns>
        AddressSuggestResponse AddressSuggest(AddressSuggestRequest addressSuggestRequest, int operationIndex = 0);

        /// <summary>
        /// Address Suggest
        /// </summary>
        /// <remarks>
        /// This operation displays a valid address to match the entered address, only if the address does not seem valid to the system address map. User can select the suggested address or edit the entered address to make it valid.
        /// </remarks>
        /// <exception cref="com.pitneybowes.api360.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressSuggestRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AddressSuggestResponse</returns>
        ApiResponse<AddressSuggestResponse> AddressSuggestWithHttpInfo(AddressSuggestRequest addressSuggestRequest, int operationIndex = 0);
        /// <summary>
        /// Address Validate
        /// </summary>
        /// <remarks>
        /// This operation validates address. This improves postal addresses within the country (e.g., United States) to help ensure that parcels are rated accurately and shipments arrive at the final destination on time.&lt;br&gt; The verify address operation sends an address to be verified. The response indicates whether the address is valid.
        /// </remarks>
        /// <exception cref="com.pitneybowes.api360.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressValidateRequest"></param>
        /// <param name="minimalAddressValidation">If true, then only City, State, and PostalCode (zip) are validated. This option is specific for US domestic addresses only. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AddressValidateResponse</returns>
        AddressValidateResponse AddressValidate(AddressValidateRequest addressValidateRequest, bool? minimalAddressValidation = default(bool?), int operationIndex = 0);

        /// <summary>
        /// Address Validate
        /// </summary>
        /// <remarks>
        /// This operation validates address. This improves postal addresses within the country (e.g., United States) to help ensure that parcels are rated accurately and shipments arrive at the final destination on time.&lt;br&gt; The verify address operation sends an address to be verified. The response indicates whether the address is valid.
        /// </remarks>
        /// <exception cref="com.pitneybowes.api360.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressValidateRequest"></param>
        /// <param name="minimalAddressValidation">If true, then only City, State, and PostalCode (zip) are validated. This option is specific for US domestic addresses only. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AddressValidateResponse</returns>
        ApiResponse<AddressValidateResponse> AddressValidateWithHttpInfo(AddressValidateRequest addressValidateRequest, bool? minimalAddressValidation = default(bool?), int operationIndex = 0);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddressApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// Address Suggest
        /// </summary>
        /// <remarks>
        /// This operation displays a valid address to match the entered address, only if the address does not seem valid to the system address map. User can select the suggested address or edit the entered address to make it valid.
        /// </remarks>
        /// <exception cref="com.pitneybowes.api360.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressSuggestRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AddressSuggestResponse</returns>
        System.Threading.Tasks.Task<AddressSuggestResponse> AddressSuggestAsync(AddressSuggestRequest addressSuggestRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Address Suggest
        /// </summary>
        /// <remarks>
        /// This operation displays a valid address to match the entered address, only if the address does not seem valid to the system address map. User can select the suggested address or edit the entered address to make it valid.
        /// </remarks>
        /// <exception cref="com.pitneybowes.api360.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressSuggestRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AddressSuggestResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddressSuggestResponse>> AddressSuggestWithHttpInfoAsync(AddressSuggestRequest addressSuggestRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// Address Validate
        /// </summary>
        /// <remarks>
        /// This operation validates address. This improves postal addresses within the country (e.g., United States) to help ensure that parcels are rated accurately and shipments arrive at the final destination on time.&lt;br&gt; The verify address operation sends an address to be verified. The response indicates whether the address is valid.
        /// </remarks>
        /// <exception cref="com.pitneybowes.api360.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressValidateRequest"></param>
        /// <param name="minimalAddressValidation">If true, then only City, State, and PostalCode (zip) are validated. This option is specific for US domestic addresses only. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AddressValidateResponse</returns>
        System.Threading.Tasks.Task<AddressValidateResponse> AddressValidateAsync(AddressValidateRequest addressValidateRequest, bool? minimalAddressValidation = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// Address Validate
        /// </summary>
        /// <remarks>
        /// This operation validates address. This improves postal addresses within the country (e.g., United States) to help ensure that parcels are rated accurately and shipments arrive at the final destination on time.&lt;br&gt; The verify address operation sends an address to be verified. The response indicates whether the address is valid.
        /// </remarks>
        /// <exception cref="com.pitneybowes.api360.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressValidateRequest"></param>
        /// <param name="minimalAddressValidation">If true, then only City, State, and PostalCode (zip) are validated. This option is specific for US domestic addresses only. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AddressValidateResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<AddressValidateResponse>> AddressValidateWithHttpInfoAsync(AddressValidateRequest addressValidateRequest, bool? minimalAddressValidation = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAddressApi : IAddressApiSync, IAddressApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AddressApi : IAddressApi
    {
        private com.pitneybowes.api360.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AddressApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AddressApi(string basePath)
        {
            this.Configuration = com.pitneybowes.api360.Client.Configuration.MergeConfigurations(
                com.pitneybowes.api360.Client.GlobalConfiguration.Instance,
                new com.pitneybowes.api360.Client.Configuration { BasePath = basePath }
            );
            this.Client = new com.pitneybowes.api360.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new com.pitneybowes.api360.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = com.pitneybowes.api360.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AddressApi(com.pitneybowes.api360.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = com.pitneybowes.api360.Client.Configuration.MergeConfigurations(
                com.pitneybowes.api360.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new com.pitneybowes.api360.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new com.pitneybowes.api360.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = com.pitneybowes.api360.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AddressApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public AddressApi(com.pitneybowes.api360.Client.ISynchronousClient client, com.pitneybowes.api360.Client.IAsynchronousClient asyncClient, com.pitneybowes.api360.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = com.pitneybowes.api360.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public com.pitneybowes.api360.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public com.pitneybowes.api360.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public com.pitneybowes.api360.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public com.pitneybowes.api360.Client.ExceptionFactory ExceptionFactory
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
        /// Address Suggest This operation displays a valid address to match the entered address, only if the address does not seem valid to the system address map. User can select the suggested address or edit the entered address to make it valid.
        /// </summary>
        /// <exception cref="com.pitneybowes.api360.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressSuggestRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AddressSuggestResponse</returns>
        public AddressSuggestResponse AddressSuggest(AddressSuggestRequest addressSuggestRequest, int operationIndex = 0)
        {
            com.pitneybowes.api360.Client.ApiResponse<AddressSuggestResponse> localVarResponse = AddressSuggestWithHttpInfo(addressSuggestRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Address Suggest This operation displays a valid address to match the entered address, only if the address does not seem valid to the system address map. User can select the suggested address or edit the entered address to make it valid.
        /// </summary>
        /// <exception cref="com.pitneybowes.api360.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressSuggestRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AddressSuggestResponse</returns>
        public com.pitneybowes.api360.Client.ApiResponse<AddressSuggestResponse> AddressSuggestWithHttpInfo(AddressSuggestRequest addressSuggestRequest, int operationIndex = 0)
        {
            // verify the required parameter 'addressSuggestRequest' is set
            if (addressSuggestRequest == null)
            {
                throw new com.pitneybowes.api360.Client.ApiException(400, "Missing required parameter 'addressSuggestRequest' when calling AddressApi->AddressSuggest");
            }

            com.pitneybowes.api360.Client.RequestOptions localVarRequestOptions = new com.pitneybowes.api360.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = com.pitneybowes.api360.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = com.pitneybowes.api360.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = addressSuggestRequest;

            localVarRequestOptions.Operation = "AddressApi.AddressSuggest";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AddressSuggestResponse>("/api/v1/address/suggest", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddressSuggest", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Address Suggest This operation displays a valid address to match the entered address, only if the address does not seem valid to the system address map. User can select the suggested address or edit the entered address to make it valid.
        /// </summary>
        /// <exception cref="com.pitneybowes.api360.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressSuggestRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AddressSuggestResponse</returns>
        public async System.Threading.Tasks.Task<AddressSuggestResponse> AddressSuggestAsync(AddressSuggestRequest addressSuggestRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            com.pitneybowes.api360.Client.ApiResponse<AddressSuggestResponse> localVarResponse = await AddressSuggestWithHttpInfoAsync(addressSuggestRequest, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Address Suggest This operation displays a valid address to match the entered address, only if the address does not seem valid to the system address map. User can select the suggested address or edit the entered address to make it valid.
        /// </summary>
        /// <exception cref="com.pitneybowes.api360.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressSuggestRequest"></param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AddressSuggestResponse)</returns>
        public async System.Threading.Tasks.Task<com.pitneybowes.api360.Client.ApiResponse<AddressSuggestResponse>> AddressSuggestWithHttpInfoAsync(AddressSuggestRequest addressSuggestRequest, int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'addressSuggestRequest' is set
            if (addressSuggestRequest == null)
            {
                throw new com.pitneybowes.api360.Client.ApiException(400, "Missing required parameter 'addressSuggestRequest' when calling AddressApi->AddressSuggest");
            }


            com.pitneybowes.api360.Client.RequestOptions localVarRequestOptions = new com.pitneybowes.api360.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = com.pitneybowes.api360.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = com.pitneybowes.api360.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            localVarRequestOptions.Data = addressSuggestRequest;

            localVarRequestOptions.Operation = "AddressApi.AddressSuggest";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<AddressSuggestResponse>("/api/v1/address/suggest", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddressSuggest", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Address Validate This operation validates address. This improves postal addresses within the country (e.g., United States) to help ensure that parcels are rated accurately and shipments arrive at the final destination on time.&lt;br&gt; The verify address operation sends an address to be verified. The response indicates whether the address is valid.
        /// </summary>
        /// <exception cref="com.pitneybowes.api360.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressValidateRequest"></param>
        /// <param name="minimalAddressValidation">If true, then only City, State, and PostalCode (zip) are validated. This option is specific for US domestic addresses only. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>AddressValidateResponse</returns>
        public AddressValidateResponse AddressValidate(AddressValidateRequest addressValidateRequest, bool? minimalAddressValidation = default(bool?), int operationIndex = 0)
        {
            com.pitneybowes.api360.Client.ApiResponse<AddressValidateResponse> localVarResponse = AddressValidateWithHttpInfo(addressValidateRequest, minimalAddressValidation);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Address Validate This operation validates address. This improves postal addresses within the country (e.g., United States) to help ensure that parcels are rated accurately and shipments arrive at the final destination on time.&lt;br&gt; The verify address operation sends an address to be verified. The response indicates whether the address is valid.
        /// </summary>
        /// <exception cref="com.pitneybowes.api360.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressValidateRequest"></param>
        /// <param name="minimalAddressValidation">If true, then only City, State, and PostalCode (zip) are validated. This option is specific for US domestic addresses only. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <returns>ApiResponse of AddressValidateResponse</returns>
        public com.pitneybowes.api360.Client.ApiResponse<AddressValidateResponse> AddressValidateWithHttpInfo(AddressValidateRequest addressValidateRequest, bool? minimalAddressValidation = default(bool?), int operationIndex = 0)
        {
            // verify the required parameter 'addressValidateRequest' is set
            if (addressValidateRequest == null)
            {
                throw new com.pitneybowes.api360.Client.ApiException(400, "Missing required parameter 'addressValidateRequest' when calling AddressApi->AddressValidate");
            }

            com.pitneybowes.api360.Client.RequestOptions localVarRequestOptions = new com.pitneybowes.api360.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = com.pitneybowes.api360.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = com.pitneybowes.api360.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (minimalAddressValidation != null)
            {
                localVarRequestOptions.QueryParameters.Add(com.pitneybowes.api360.Client.ClientUtils.ParameterToMultiMap("", "minimalAddressValidation", minimalAddressValidation));
            }
            localVarRequestOptions.Data = addressValidateRequest;

            localVarRequestOptions.Operation = "AddressApi.AddressValidate";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = this.Client.Post<AddressValidateResponse>("/api/v1/address/verify", localVarRequestOptions, this.Configuration);
            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddressValidate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

        /// <summary>
        /// Address Validate This operation validates address. This improves postal addresses within the country (e.g., United States) to help ensure that parcels are rated accurately and shipments arrive at the final destination on time.&lt;br&gt; The verify address operation sends an address to be verified. The response indicates whether the address is valid.
        /// </summary>
        /// <exception cref="com.pitneybowes.api360.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressValidateRequest"></param>
        /// <param name="minimalAddressValidation">If true, then only City, State, and PostalCode (zip) are validated. This option is specific for US domestic addresses only. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of AddressValidateResponse</returns>
        public async System.Threading.Tasks.Task<AddressValidateResponse> AddressValidateAsync(AddressValidateRequest addressValidateRequest, bool? minimalAddressValidation = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            com.pitneybowes.api360.Client.ApiResponse<AddressValidateResponse> localVarResponse = await AddressValidateWithHttpInfoAsync(addressValidateRequest, minimalAddressValidation, operationIndex, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// Address Validate This operation validates address. This improves postal addresses within the country (e.g., United States) to help ensure that parcels are rated accurately and shipments arrive at the final destination on time.&lt;br&gt; The verify address operation sends an address to be verified. The response indicates whether the address is valid.
        /// </summary>
        /// <exception cref="com.pitneybowes.api360.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="addressValidateRequest"></param>
        /// <param name="minimalAddressValidation">If true, then only City, State, and PostalCode (zip) are validated. This option is specific for US domestic addresses only. (optional)</param>
        /// <param name="operationIndex">Index associated with the operation.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (AddressValidateResponse)</returns>
        public async System.Threading.Tasks.Task<com.pitneybowes.api360.Client.ApiResponse<AddressValidateResponse>> AddressValidateWithHttpInfoAsync(AddressValidateRequest addressValidateRequest, bool? minimalAddressValidation = default(bool?), int operationIndex = 0, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'addressValidateRequest' is set
            if (addressValidateRequest == null)
            {
                throw new com.pitneybowes.api360.Client.ApiException(400, "Missing required parameter 'addressValidateRequest' when calling AddressApi->AddressValidate");
            }


            com.pitneybowes.api360.Client.RequestOptions localVarRequestOptions = new com.pitneybowes.api360.Client.RequestOptions();

            string[] _contentTypes = new string[] {
                "application/json"
            };

            // to determine the Accept header
            string[] _accepts = new string[] {
                "application/json"
            };

            var localVarContentType = com.pitneybowes.api360.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);
            }

            var localVarAccept = com.pitneybowes.api360.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null)
            {
                localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);
            }

            if (minimalAddressValidation != null)
            {
                localVarRequestOptions.QueryParameters.Add(com.pitneybowes.api360.Client.ClientUtils.ParameterToMultiMap("", "minimalAddressValidation", minimalAddressValidation));
            }
            localVarRequestOptions.Data = addressValidateRequest;

            localVarRequestOptions.Operation = "AddressApi.AddressValidate";
            localVarRequestOptions.OperationIndex = operationIndex;

            // authentication (bearerAuth) required
            // bearer authentication required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken) && !localVarRequestOptions.HeaderParameters.ContainsKey("Authorization"))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            // make the HTTP request
            var localVarResponse = await this.AsynchronousClient.PostAsync<AddressValidateResponse>("/api/v1/address/verify", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("AddressValidate", localVarResponse);
                if (_exception != null)
                {
                    throw _exception;
                }
            }

            return localVarResponse;
        }

    }
}
