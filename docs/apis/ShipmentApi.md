# com.pitneybowes.api360.Api.ShipmentApi

All URIs are relative to *https://api-dev.sendpro360.pitneycloud.com/shipping*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelShipmentByIdV2**](ShipmentApi.md#cancelshipmentbyidv2) | **POST** /api/v2/shipments/cancel | Cancel Shipment |
| [**CancelStampsERR**](ShipmentApi.md#cancelstampserr) | **POST** /api/v1/err/stamps/void | Cancel Stamps ERR |
| [**CreateErrCoversheet**](ShipmentApi.md#createerrcoversheet) | **POST** /api/v1/err/coverSheet | Create ERR Single Coversheet |
| [**CreateShipmentV2**](ShipmentApi.md#createshipmentv2) | **POST** /api/v2/shipments | Create Shipment |
| [**DownloadBpodFiles**](ShipmentApi.md#downloadbpodfiles) | **POST** /api/v1/err/shipments/bpod | Download BPOD Files |
| [**GetAllShipments**](ShipmentApi.md#getallshipments) | **GET** /api/v1/shipments | Get All Shipments |
| [**GetCarrierAccount**](ShipmentApi.md#getcarrieraccount) | **GET** /api/v1/carrierAccounts | Get Carrier Accounts |
| [**GetCarriers**](ShipmentApi.md#getcarriers) | **GET** /api/v1/carriers | Get Carriers |
| [**GetCountries**](ShipmentApi.md#getcountries) | **GET** /api/v1/countries | Get Countries |
| [**GetParcelTypes**](ShipmentApi.md#getparceltypes) | **GET** /api/v1/parcelTypes | Get Parcel Types |
| [**GetServices**](ShipmentApi.md#getservices) | **GET** /api/v1/services | Get Services |
| [**GetSignatureImageERR**](ShipmentApi.md#getsignatureimageerr) | **GET** /api/v1/err/shipments/{shipmentId}/signaturefile | Signature Image ERR |
| [**GetSpecialServices**](ShipmentApi.md#getspecialservices) | **GET** /api/v1/specialServices | Get Special Services |
| [**RateShipment**](ShipmentApi.md#rateshipment) | **POST** /api/v2/rates | Rate Shipment |
| [**ReprintShipmentByIdV2**](ShipmentApi.md#reprintshipmentbyidv2) | **POST** /api/v2/shipments/reprint | Reprint Shipment |
| [**ShipmentById**](ShipmentApi.md#shipmentbyid) | **GET** /api/v1/shipments/{shipmentId} | Get Shipment by Id |

<a id="cancelshipmentbyidv2"></a>
# **CancelShipmentByIdV2**
> CancelShipmentV2 CancelShipmentByIdV2 (ShipmentCancelV2 shipmentCancelV2, string xPBDeveloperPartnerId = null, string xPBLocationId = null, string xPBTransactionId = null)

Cancel Shipment

This operation cancels or voids a shipment label that has not been processed by the carrier. When you cancel an unused prepaid shipment label, the API initiates a request for an electronic refund.<br>  **Key Considerations** - Cancelation must occur before the shipment is picked up or processed by the carrier. - Refunds are only applicable for unused labels. Voiding a used label may result in penalties or billing.<br> - **USPS**:    - Cancel unused USPS prepaid labels within 30 days of printing to start the refund process.    - Refund requests are processed within 14 business days from the date the refund was requested, provided the label has not been used.    - Approved refunds are automatically credited to the account you used to pay for the label.    - **Note**: USPS considers it a federal offense to induct a label that has already been refunded.    - **Note**: Refunds are not available for First-Class Mail letters and flats.    - **Note**: Refunds are subject to the policies of the applicable carrier. - For unused post-paid labels, you must void them. Voiding avoids billing for the label and allows the carrier to maintain an accurate count for pickups. - Always destroy voided labels to prevent accidental use. If a voided label is shipped, you will be billed for the label. - Once a refund has been claimed, you cannot use the shipping label for sending packages. It will be rejected. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentCancelV2** | [**ShipmentCancelV2**](ShipmentCancelV2.md) |  |  |
| **xPBDeveloperPartnerId** | **string** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **xPBLocationId** | **string** | This is the Location ID assigned as per the Developer&#39;s and Partner&#39;s parsed locations, to which all transactions will be billed. &lt;br /&gt; Partner&#39;s location will be used for billing if it is configured, however, in case Partner&#39;s location is not given, then the Developer&#39;s location will be taken. Developer&#39;s location will be the default value. &lt;br /&gt; Additionally, Developers and Partners can use carriers belong to this location only. | [optional]  |
| **xPBTransactionId** | **string** | A unique Transaction ID provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. | [optional]  |

### Return type

[**CancelShipmentV2**](CancelShipmentV2.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Shipment has been cancelled. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cancelstampserr"></a>
# **CancelStampsERR**
> CancelStampsResponseERR CancelStampsERR (CancelStampsRequestERR cancelStampsRequestERR, string xPBDeveloperPartnerID = null)

Cancel Stamps ERR

This operation cancels (voids) stamps generated for ERR (Electronic Return Receipt).  - User needs to provide *Stamp IDs* to cancel those specific ERR stamps.  - User can download the *Refund Form* having details of generated Postage.  - At once, maximum 1000 stamps can be requested for cancelation. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cancelStampsRequestERR** | [**CancelStampsRequestERR**](CancelStampsRequestERR.md) |  |  |
| **xPBDeveloperPartnerID** | **string** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field is not required. | [optional]  |

### Return type

[**CancelStampsResponseERR**](CancelStampsResponseERR.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Stamps Refund Form has been generated. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createerrcoversheet"></a>
# **CreateErrCoversheet**
> ErrCoversheetResponse CreateErrCoversheet (ErrCoversheetRequest errCoversheetRequest)

Create ERR Single Coversheet

This API generates a single coversheet for a parcel, with support for Electronic Return Receipt (ERR) and other special services. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **errCoversheetRequest** | [**ErrCoversheetRequest**](ErrCoversheetRequest.md) |  |  |

### Return type

[**ErrCoversheetResponse**](ErrCoversheetResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The ERR coversheet has been successfully created. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="createshipmentv2"></a>
# **CreateShipmentV2**
> CreateShipmentV2200Response CreateShipmentV2 (bool isReturn, CreateShipmentV2Request createShipmentV2Request, string xPBDeveloperPartnerId = null, string xPBLocationId = null, string xPBTransactionId = null, string xPBDefaultID = null, string includeDeliveryCommitment = null)

Create Shipment

> **Note:** This Request sample includes the full set of supported fields across all carriers. However, not all fields are applicable to every carrier. When making API calls from the doc portal, ensure you include only the parameters supported by the specific carrier you are integrating with. If unsupported fields are included, the request may fail. <br/> To simplify integration and avoid errors, refer to the [Postman Collection](/docs/resources/postman/). <br/> To explore which label types, label formats, label sizes, parcel types, services, and special services are supported by each carrier, see the [Carrier Catalog](/docs/shipping/carriers/carrier-catalog/). Detailed field descriptions are also provided below.  The Create Shipment API is used to create shipments and generate shipment labels. A shipment refers to the process of packing and transporting an item from a source location to a destination location using a carrier service. The API supports both domestic and international shipments.<br>  **Domestic Shipments** <br>    - Both the `toAddress` and `fromAddress` addresses must be within the same country.   - Requires carrier services and associated special services.  **International Shipments**   - The `toAddress` must be in a different country than the `fromAddress`.   - Requires international carrier services, special services, and customs information.<br>  The V2 Create Shipment API compares shipping rates, services, and options across multiple carriers. It selects the best shipping solution based on criteria such as cost, delivery speed, or other business rules. This automates decision-making and eliminates the need for manual analysis of carrier data. It supports three RateShop types: <br>  **1. By Carrier:**<br>    - Manually specify the carrier and service for shipment creation.   - Provides more customization than V1 Create Shipment.  **2. By RuleSet**<br>    - Automatically select the best carrier and service based on predefined rules (e.g., cheapest, fastest). For example: <br>   - Shipments weighing up to 3kg use a \"Standard\" service type with carrier A.   - Shipments exceeding 3kg use an \"Over-weight\" service type with carrier B.   - Rules are fully client-defined, allowing for dynamic decision-making based on shipment parameters like weight, dimensions, and destination.  **3. By RateGroup**<br>    - Use predefined rate groups to select a carrier and service dynamically.For example:<br>   - Clients can choose between the fastest delivery or the cheapest service rate among a predefined group of carriers.   - The system automatically determines and selects the best carrier and service, without the need for manual comparisons.    **Notes**<br>    - The `rateShopBy` field determines the variant to use (`carrier`, `ruleset`, or `rategroup`).   - Ensure that variant-specific fields are correctly populated:     - **byCarrier:** `carrierAccountId`, `carrier`, and `service`     - **byRuleSet:** `ruleType` and `shipOption`     - **byRateGroup:** `ruleType` and `rateGroupId`    - Define special services in one of two ways - by using a `specialServiceId` or by specifying  special service objects such as `deliveryConfirmation`, `handling`, `insurance`, or `returnOptions`. These two cannot be used together in the same request. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **isReturn** | **bool** | Applies only to carriers UPS and FedEx; For UPS, if &#x60;isReturn&#x60; is passed, you must either include the &#x60;returnOptions&#x60; object (when using individual service objects) or specify the &#x60;serviceId:PRL&#x60; (when using specialService), or an error will occur. For FedEx, If &#x60;isReturn&#x60; is set to &#x60;true&#x60;, the &#x60;returnOptions&#x60; object is optional. |  |
| **createShipmentV2Request** | [**CreateShipmentV2Request**](CreateShipmentV2Request.md) |  |  |
| **xPBDeveloperPartnerId** | **string** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **xPBLocationId** | **string** | This is the Location ID assigned as per the Developer&#39;s and Partner&#39;s parsed locations, to which all transactions will be billed. &lt;br /&gt; Partner&#39;s location will be used for billing if it is configured, however, in case Partner&#39;s location is not given, then the Developer&#39;s location will be taken. Developer&#39;s location will be the default value. &lt;br /&gt; Additionally, Developers and Partners can use carriers belong to this location only. | [optional]  |
| **xPBTransactionId** | **string** | A unique Transaction ID provided by the partner, which is used to enable debugging and linking between the client&#39;s transaction and the system. | [optional]  |
| **xPBDefaultID** | **string** | A unique identifier assigned to the Default while its creation using CreateDefaults API. | [optional]  |
| **includeDeliveryCommitment** | **string** | When set to true (default), the response includes delivery commitment information. Set to false to exclude delivery commitment details from the response. | [optional] [default to &quot;true&quot;] |

### Return type

[**CreateShipmentV2200Response**](CreateShipmentV2200Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The shipment has been created successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="downloadbpodfiles"></a>
# **DownloadBpodFiles**
> BPODDownloadResponse DownloadBpodFiles (string xPBDeveloperPartnerID = null, string startDate = null, string endDate = null, BPODDownloadRequest body = null)

Download BPOD Files

This API operation is used to download bulk of ERR (*Electronic Return Receipt*) - POD (*Proof of Delivery*) files, which are specific to USPS carrier. <br />   User can download BPOD (*Bulk Proof of Delivery*) files either using *Shipment IDs* or *Date Range*.    If user wants to check records based on dates and download BPOD files accordingly, then *Start Date* and *End Date* need to be passed in the request body as filter. Else *Shipment IDs* will be used as default value when user does not provide *DateRange* filter. <br />   User is restricted to download 1000 BPOD files as max limit. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerID** | **string** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field is not required. | [optional]  |
| **startDate** | **string** | The BPOD files to be downloaded from which Date is the startDate in the Date Range filter. This field is not required if the Shipment IDs provided in the request body. | [optional]  |
| **endDate** | **string** | The BPOD files to be downloaded till which Date is the endDate in the Date Range filter. This field is not required if the Shipment IDs provided in the request body. | [optional]  |
| **body** | [**BPODDownloadRequest**](BPODDownloadRequest.md) | This is the request body to download BPOD files. Request body supports max of 1000 ShipmentIDs in a request. | [optional]  |

### Return type

[**BPODDownloadResponse**](BPODDownloadResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The ZIP URL for BPOD files has been created for download. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getallshipments"></a>
# **GetAllShipments**
> GetAllShipments GetAllShipments (string xPBDeveloperPartnerId = null, string startDate = null, string endDate = null, string page = null, string size = null)

Get All Shipments

The operation fetches all created Shipments. If query parameters are not provided, it will default endDate as current date, page as 1 and size as 10.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerId** | **string** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **startDate** | **string** | While searching shipments, user set a date range to get all created shipments. This indicatesthe start date of the set date range under shipment search criteria. The date format must be: YYYY-MM-DD. | [optional]  |
| **endDate** | **string** | While searching shipments, user set a date range to get all created shipments. This indicatesthe end date of the set date range under shipment search criteria. The date format must be: YYYY-MM-DD. | [optional]  |
| **page** | **string** | The page of the Shipments search result list. | [optional]  |
| **size** | **string** | The size/count of the searched result list. | [optional]  |

### Return type

[**GetAllShipments**](GetAllShipments.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of shipments. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcarrieraccount"></a>
# **GetCarrierAccount**
> GetCarrierAccount200Response GetCarrierAccount (string xPBDeveloperPartnerId = null)

Get Carrier Accounts

The operation retrieves onboarded Carriers with their Carrier Account IDs which uniquely identify multiple accounts of same carrier.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerId** | **string** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |

### Return type

[**GetCarrierAccount200Response**](GetCarrierAccount200Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Carrier Accounts has been fetched. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcarriers"></a>
# **GetCarriers**
> Carriers GetCarriers (string xPBDeveloperPartnerId = null)

Get Carriers

The operation fetches all supported carriers. This service is used to get list of supported carriers and their properties.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerId** | **string** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

### Return type

[**Carriers**](Carriers.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The available carriers have been fetched. |  * X-PB-TransactionId - A unique transaction Id provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. <br>  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getcountries"></a>
# **GetCountries**
> Countries GetCountries (string xPBDeveloperPartnerId = null, string carrier = null, string originCountryCode = null)

Get Countries

The operation fetches list of supported destination countries for a provided carrier and origin country. If query parameters are not provided, it will default to `USPS` as carrier and `US` as origin country.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerId** | **string** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **carrier** | **string** | The carrierID, a unique identifier given to an individual carrier. | [optional]  |
| **originCountryCode** | **string** | The Source Country. The two-character ISO country code for the country where the Shipment originates. | [optional]  |

### Return type

[**Countries**](Countries.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Countries has been fetched. |  * X-PB-TransactionId - A unique transaction Id provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. <br>  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getparceltypes"></a>
# **GetParcelTypes**
> ParcelTypes GetParcelTypes (string xPBDeveloperPartnerId = null, string carrier = null, string originCountryCode = null, string destinationCountryCode = null)

Get Parcel Types

The operation fetches Parcel Types based on the provided carrier, origin county, and the destination country. If query parameters are not provided, this will default to `USPS` as carrier, `US` as both origin and destination country code.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerId** | **string** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **carrier** | **string** | The CarrierID, a unique identifier given to an individual carrier. It can be referred from the response of Get Carriers API | [optional]  |
| **originCountryCode** | **string** | The Source Country. The two-character ISO country code for the country where the Shipment originates. | [optional]  |
| **destinationCountryCode** | **string** | The Destination Country for the Shipment. The two-character ISO country code for the country where the shipment is to be delivered. | [optional]  |

### Return type

[**ParcelTypes**](ParcelTypes.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Parcel Types has been fetched. |  * X-PB-TransactionId - A unique transaction Id provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. <br>  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getservices"></a>
# **GetServices**
> Services GetServices (string xPBDeveloperPartnerId = null, string carrier = null, string originCountryCode = null, string destinationCountryCode = null)

Get Services

The operation fetches a list of supported services for a carrier with respect to specific origin and destination country. If query parameters are not provided, this will default to `USPS` as carrier, `US` as both origin and destination country code.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerId** | **string** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **carrier** | **string** | The CarrierID, a unique identifier provided to an individual carrier. It can be referred from the response of Get Carriers API | [optional]  |
| **originCountryCode** | **string** | The Source Country. The two-character ISO country code for the country where the Shipment originates. | [optional]  |
| **destinationCountryCode** | **string** | The Destination Country for the Shipment. The two-character ISO country code for the country where the shipment is to be delivered. | [optional]  |

### Return type

[**Services**](Services.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of services has been fetched. |  * X-PB-TransactionId - A unique transaction Id provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. <br>  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getsignatureimageerr"></a>
# **GetSignatureImageERR**
> SignatureFileResponse GetSignatureImageERR (string shipmentId, string xPBDeveloperPartnerID = null)

Signature Image ERR

This API provides a downloadable link containing the signature image for a specific ERR (Electronic Return Receipt) shipment. This signature image serves as Proof of Delivery (POD). <br> **What is Proof of Delivery (POD)?**<br> Proof of Delivery is a document or file that acts as evidence of successful shipment delivery. This file contains a digital copy of the recipient's signature, provided as a downloadable link or URL.  **Key Considerations:** - It provides the recipient's signature image captured at the time of delivery as proof that the shipment was successfully delivered. - The API provides the recipient's signature image as Proof of Delivery (POD) to confirm successful shipment delivery. - A request requires the mandatory `shipmentId`. - If a signature is captured by the carrier, the API returns it as a downloadable link of the PDF in the `signatureFileURL` field. - The `signatureFileURL` provided in the API response expires after 60 minutes. - If no signature is available, the API returns an error. - Signature Image ERR is supported for USPS carrier only. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentId** | **string** | Shipment ID is a unique identifier for an individual shipment. |  |
| **xPBDeveloperPartnerID** | **string** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field is not required. | [optional]  |

### Return type

[**SignatureFileResponse**](SignatureFileResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Signature image as proof of delivered shipment. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getspecialservices"></a>
# **GetSpecialServices**
> SpecialServices GetSpecialServices (string xPBDeveloperPartnerId = null, string service = null, string parcel = null, string carrier = null, string originCountryCode = null, string destinationCountryCode = null)

Get Special Services

The operation fetches Special Services for a given carrier, service, origin country, and the destination country. If query parameters are not provided, it will default to `USPS` as carrier, `US` as both origin, and destination country and will show for all service and parcel types


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerId** | **string** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **service** | **string** | The serviceId. It can be referred from response of &#x60;Get Services&#x60; API | [optional]  |
| **parcel** | **string** | The parcel Id, a unique identifier named to individual package. It can be referred from response of &#x60;Get Parcel Types&#x60; API | [optional]  |
| **carrier** | **string** | The CarrierID, a unique identifier given to an individual carrier. It can be referred from response of &#x60;Get Carriers&#x60; API | [optional]  |
| **originCountryCode** | **string** | The Source Country. The two-character ISO country code for the country where the Shipment originates. | [optional]  |
| **destinationCountryCode** | **string** | The Destination Country for the Shipment. The two-character ISO country code for the country where the shipment is to be delivered. | [optional]  |

### Return type

[**SpecialServices**](SpecialServices.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Special Service has been fetched successfully. |  * X-PB-TransactionId - A unique transaction Id provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. <br>  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="rateshipment"></a>
# **RateShipment**
> RateShipment200Response RateShipment (RateShipmentRequest rateShipmentRequest)

Rate Shipment

This operation generates rate Shop for a specified shipment without generating the labels.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **rateShipmentRequest** | [**RateShipmentRequest**](RateShipmentRequest.md) |  |  |

### Return type

[**RateShipment200Response**](RateShipment200Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Rate Shop has been generated successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="reprintshipmentbyidv2"></a>
# **ReprintShipmentByIdV2**
> ReprintShipmentV2 ReprintShipmentByIdV2 (ShipmentReprintV2 shipmentReprintV2, string xPBDeveloperPartnerId = null, string xPBLocationId = null, string xPBTransactionId = null)

Reprint Shipment

This operation retrieves an existing shipping label associated with a shipment. The API uses the shipmentId returned by the original Create Shipment request. Use this API only if the original shipping label has been lost or damaged. <br>  **Key Considerations**:<br>     - This operation is applicable only if the original shipment was successfully created. It cannot be used if the initial Create Shipment request resulted in no response or encountered an error.    - USPS allows only 1 reprint.    - GoFor does not allow reprint.    - RMG allows 3 reprints.    - All other carriers allow up to 8 reprints.    - Reprints are valid for 24 hours from the time the label was first created.    - Reprinting should only be used when necessary. Excessive reprint attempts are restricted and monitored.    - Follow the [Troubleshooting](/docs/support/troubleshooting/) section in case you are facing any issues creating a shipment. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentReprintV2** | [**ShipmentReprintV2**](ShipmentReprintV2.md) |  |  |
| **xPBDeveloperPartnerId** | **string** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **xPBLocationId** | **string** | This is the Location ID assigned as per the Developer&#39;s and Partner&#39;s parsed locations, to which all transactions will be billed. &lt;br /&gt; Partner&#39;s location will be used for billing if it is configured, however, in case Partner&#39;s location is not given, then the Developer&#39;s location will be taken. Developer&#39;s location will be the default value. &lt;br /&gt; Additionally, Developers and Partners can use carriers belong to this location only. | [optional]  |
| **xPBTransactionId** | **string** | A unique transaction Id provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. | [optional]  |

### Return type

[**ReprintShipmentV2**](ReprintShipmentV2.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The shipment has been reprinted. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="shipmentbyid"></a>
# **ShipmentById**
> GetSingleShipment ShipmentById (string shipmentId, string xPBDeveloperPartnerId = null)

Get Shipment by Id

The operation retrieves shipment details using shipmentId.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentId** | **string** | The shipmentId, a unique identifier for an individual Shipment. |  |
| **xPBDeveloperPartnerId** | **string** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |

### Return type

[**GetSingleShipment**](GetSingleShipment.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The shipment has been retrieved. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

