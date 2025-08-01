# com.pitneybowes.api360.Api.MultipieceShipmentApi

All URIs are relative to *https://api-dev.sendpro360.pitneycloud.com/shipping*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MultipieceRates**](MultipieceShipmentApi.md#multipiecerates) | **POST** /api/v1/multipiece/rates | Multipiece Rates |
| [**MultipieceShipment**](MultipieceShipmentApi.md#multipieceshipment) | **POST** /api/v1/multipiece/shipments | Multipiece Shipment |
| [**MultipieceShipmentCancel**](MultipieceShipmentApi.md#multipieceshipmentcancel) | **PUT** /api/v1/multipiece/shipments/{shipmentId}/cancel | Cancel Multipiece Shipment |
| [**MultipieceShipmentReprint**](MultipieceShipmentApi.md#multipieceshipmentreprint) | **GET** /api/v1/multipiece/shipments/{shipmentId}/reprint | Reprint Multipiece Shipment |

<a id="multipiecerates"></a>
# **MultipieceRates**
> MultipieceRates200Response MultipieceRates (MultipieceRatesRequest multipieceRatesRequest, string xPBDeveloperPartnerId = null, string includeDeliveryCommitment = null)

Multipiece Rates

The operation is used for rateshop and to get specific rate based on serviceId for Multipiece.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **multipieceRatesRequest** | [**MultipieceRatesRequest**](MultipieceRatesRequest.md) |  |  |
| **xPBDeveloperPartnerId** | **string** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **includeDeliveryCommitment** | **string** | When set to true (default), the response includes delivery commitment information. Set to false to exclude delivery commitment details from the response. | [optional] [default to &quot;true&quot;] |

### Return type

[**MultipieceRates200Response**](MultipieceRates200Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Multipiece Rates created successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="multipieceshipment"></a>
# **MultipieceShipment**
> MultipieceShipment200Response MultipieceShipment (MultipieceShipmentRequest multipieceShipmentRequest, string xPBDeveloperPartnerId = null, string includeDeliveryCommitment = null, bool splitContent = null)

Multipiece Shipment

The operation creates Multipiece Shipments. Shipments with multiple parcels sent to the same destination can be grouped together in a multipiece shipment.   - UPS, FedEx, DHL Express, Suprmsys, Purolator and Apple Express are supported for Multipiece Shipments.   - Maximum Parcels Allowed per Carrier:     - DHL: 75     - FedEx: 40     - UPS: 50     - Purolator: 100     - Apple Express: 75      - For UPS- multipiece shipment with Envelopes (having parcel Type as LTR) is not supported.  - For FedEx Multipiece, all parcels must be of same packaging type while creating multipiece shipment  - USPS does not support multi-piece parcels in a single shipment at this time. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **multipieceShipmentRequest** | [**MultipieceShipmentRequest**](MultipieceShipmentRequest.md) |  |  |
| **xPBDeveloperPartnerId** | **string** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **includeDeliveryCommitment** | **string** | When set to true (default), the response includes delivery commitment information. Set to false to exclude delivery commitment details from the response. | [optional] [default to &quot;true&quot;] |
| **splitContent** | **bool** | Include this parameter only if you want to generate separate labels for each parcel in a multi-piece shipment. As of now, individual parcel labels supported for carriers FedEx and UPS. | [optional] [default to false] |

### Return type

[**MultipieceShipment200Response**](MultipieceShipment200Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Multipiece Shipment created successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="multipieceshipmentcancel"></a>
# **MultipieceShipmentCancel**
> CancelShipment MultipieceShipmentCancel (string shipmentId, string xPBDeveloperPartnerId = null)

Cancel Multipiece Shipment

The operation is used to cancel the multipiece label. It takes the shipmentId of the multipiece shipment done.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentId** | **string** | It specifies the shipmentId of onward shipment against which return label has to be created. |  |
| **xPBDeveloperPartnerId** | **string** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

### Return type

[**CancelShipment**](CancelShipment.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Multipiece Shipment created successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="multipieceshipmentreprint"></a>
# **MultipieceShipmentReprint**
> ReprintMultipieceShipmentResponse MultipieceShipmentReprint (string shipmentId, string xPBDeveloperPartnerId = null)

Reprint Multipiece Shipment

The operation is used to reprint the multipiece label. It takes the shipmentId of the multipiece shipment done. All supported carriers (UPS, FedEx, DHL Express, Suprmsys, Purolator, and Apple Express) allow up to 8 reprint.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentId** | **string** | It specifies the shipmentId of onward shipment against which return label has to be created. |  |
| **xPBDeveloperPartnerId** | **string** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

### Return type

[**ReprintMultipieceShipmentResponse**](ReprintMultipieceShipmentResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Multipiece Shipment created successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

