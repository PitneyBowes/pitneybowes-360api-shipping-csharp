# com.pitneybowes.api360.Api.PickupsApi

All URIs are relative to *https://api-dev.sendpro360.pitneycloud.com/shipping*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelPickups**](PickupsApi.md#cancelpickups) | **PUT** /api/v1/pickups/cancel | Cancel Pickups |
| [**CancelledPickupDocument**](PickupsApi.md#cancelledpickupdocument) | **POST** /api/v1/pickups/document | Cancelled Pickup Document |
| [**CheckPickupAvailability**](PickupsApi.md#checkpickupavailability) | **POST** /api/v1/pickups/availability | Check Pickup Availability |
| [**GetPickupDocument**](PickupsApi.md#getpickupdocument) | **GET** /api/v1/pickups/{pickupId}/document | Get Pickup Document |
| [**GetPickups**](PickupsApi.md#getpickups) | **GET** /api/v1/pickups | Get Pickups |
| [**SchedulePickup**](PickupsApi.md#schedulepickup) | **POST** /api/v1/pickups | Schedule Pickup |

<a id="cancelpickups"></a>
# **CancelPickups**
> SchedulePickupCancelResponse CancelPickups (SchedulePickupCancelRequest schedulePickupCancelRequest, string xPBDeveloperPartnerId = null)

Cancel Pickups

Cancel Pickups.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **schedulePickupCancelRequest** | [**SchedulePickupCancelRequest**](SchedulePickupCancelRequest.md) |  |  |
| **xPBDeveloperPartnerId** | **string** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

### Return type

[**SchedulePickupCancelResponse**](SchedulePickupCancelResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pick up cancelled successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="cancelledpickupdocument"></a>
# **CancelledPickupDocument**
> GetPickupCancelledDocumentResponse CancelledPickupDocument (string type, GetPickupCancelledDocumentRequest getPickupCancelledDocumentRequest, string xPBDeveloperPartnerId = null)

Cancelled Pickup Document

This operation generates a PDF receipt for pickup cancellations. It supports creating receipts for multiple cancelled pickups.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **string** | Specifies the type of document being retrieved. Use &#39;cancelled&#39; to generate a receipt for cancelled pickups. |  |
| **getPickupCancelledDocumentRequest** | [**GetPickupCancelledDocumentRequest**](GetPickupCancelledDocumentRequest.md) |  |  |
| **xPBDeveloperPartnerId** | **string** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

### Return type

[**GetPickupCancelledDocumentResponse**](GetPickupCancelledDocumentResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The pickup has been cancelled. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="checkpickupavailability"></a>
# **CheckPickupAvailability**
> PickupAvailabilityResponse CheckPickupAvailability (string acceptLanguage, PickupAvailabilityRequest pickupAvailabilityRequest)

Check Pickup Availability

Validates if the requested carrier can perform a pickup at the provided address, given the shipment details and requested pickup date/time.  The response also indicates: - If pickup is available at the location. - What types of pickup (residential, on-demand, scheduled) are supported. - Cutoff times and valid pickup time windows. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **acceptLanguage** | **string** | Locale for response messages, BCP-47 format (language-region), e.g., en-US.  |  |
| **pickupAvailabilityRequest** | [**PickupAvailabilityRequest**](PickupAvailabilityRequest.md) |  |  |

### Return type

[**PickupAvailabilityResponse**](PickupAvailabilityResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pickup availability details returned successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getpickupdocument"></a>
# **GetPickupDocument**
> GetPickupDocument GetPickupDocument (string pickupId, string xPBDeveloperPartnerId = null)

Get Pickup Document

The API retrieves the document for a scheduled pickup receipt using the pickupId, generated when the pickup is successfully scheduled.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pickupId** | **string** | Unique identifier for the scheduled pickup. |  |
| **xPBDeveloperPartnerId** | **string** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

### Return type

[**GetPickupDocument**](GetPickupDocument.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Pick up document have been fetched. |  * X-PB-TransactionId - A unique transaction Id provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. <br>  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getpickups"></a>
# **GetPickups**
> GetAllPickups GetPickups (string xPBDeveloperPartnerId = null, string carrier = null, string startDate = null, string endDate = null, string status = null)

Get Pickups

Get Pickups


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerId** | **string** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **carrier** | **string** | Name of the carrier to retrieve pickups for. | [optional]  |
| **startDate** | **string** | The start date for filtering pickups. Format: YYYY-MM-DD. | [optional]  |
| **endDate** | **string** | The end date for filtering pickups. Format: YYYY-MM-DD. | [optional]  |
| **status** | **string** | The status of the pickups to retrieve (scheduled or cancelled). | [optional]  |

### Return type

[**GetAllPickups**](GetAllPickups.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of pickups. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="schedulepickup"></a>
# **SchedulePickup**
> SchedulePickup200Response SchedulePickup (SchedulePickupRequest schedulePickupRequest, string xPBDeveloperPartnerId = null)

Schedule Pickup

Pickups endpoint allows you to schedule pickups with USPS, DHL Express, UPS and FedEx carriers for eligible shipments.  The pickup schedule scope is determined by what you provide in the request:   - **If pickupSummary is provided:** a pickup is scheduled for the packages described in the summary.   - **If ShipmentIds is provided:** a pickup is scheduled for the specified shipments.   - **If both pickupSummary and ShipmentIds are provided:** a pickup is scheduled for all shipments including by both inputs.   - **If neither is provided:** a pickup is scheduled for all shipments created on the given carrier account by that time of the day. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **schedulePickupRequest** | [**SchedulePickupRequest**](SchedulePickupRequest.md) |  |  |
| **xPBDeveloperPartnerId** | **string** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

### Return type

[**SchedulePickup200Response**](SchedulePickup200Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Pickup has been created successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

