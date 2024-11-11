# com.pitneybowes.api360.Api.PickupsApi

All URIs are relative to *https://api-sandbox.sendpro360.pitneybowes.com/shipping*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelPickups**](PickupsApi.md#cancelpickups) | **PUT** /api/v1/pickups/cancel | Cancel Pickups |
| [**CancelledPickupDocument**](PickupsApi.md#cancelledpickupdocument) | **POST** /api/v1/pickups/document | Cancelled Pickup Document |
| [**GetPickupDocument**](PickupsApi.md#getpickupdocument) | **GET** /api/v1/pickups/{pickupId}/document | Get Pickup Document |
| [**GetPickups**](PickupsApi.md#getpickups) | **GET** /api/v1/pickups | Get Pickups |
| [**SchedulePickup**](PickupsApi.md#schedulepickup) | **POST** /api/v1/pickups | Schedule Pickup |

<a id="cancelpickups"></a>
# **CancelPickups**
> SchedulePickupCancelResponse CancelPickups (SchedulePickupCancelRequest schedulePickupCancelRequest, string? xPBDeveloperPartnerID = null)

Cancel Pickups

This operation is used to Cancel the scheduled pickup.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class CancelPickupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PickupsApi(config);
            var schedulePickupCancelRequest = new SchedulePickupCancelRequest(); // SchedulePickupCancelRequest | 
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 

            try
            {
                // Cancel Pickups
                SchedulePickupCancelResponse result = apiInstance.CancelPickups(schedulePickupCancelRequest, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickupsApi.CancelPickups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelPickupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel Pickups
    ApiResponse<SchedulePickupCancelResponse> response = apiInstance.CancelPickupsWithHttpInfo(schedulePickupCancelRequest, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PickupsApi.CancelPickupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **schedulePickupCancelRequest** | [**SchedulePickupCancelRequest**](SchedulePickupCancelRequest.md) |  |  |
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cancelledpickupdocument"></a>
# **CancelledPickupDocument**
> GetPickupCancelledDocumentResponse CancelledPickupDocument (string type, GetPickupCancelledDocumentRequest getPickupCancelledDocumentRequest, string? xPBDeveloperPartnerID = null)

Cancelled Pickup Document

This operation is used to get receipt for pickup cancellation. The receipt generated is in PDF format. <br> This operation can create receipt for multiple pickups which are cancelled.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class CancelledPickupDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PickupsApi(config);
            var type = cancelled;  // string | Indicates type of pickup. Supported value is `cancelled`.
            var getPickupCancelledDocumentRequest = new GetPickupCancelledDocumentRequest(); // GetPickupCancelledDocumentRequest | 
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 

            try
            {
                // Cancelled Pickup Document
                GetPickupCancelledDocumentResponse result = apiInstance.CancelledPickupDocument(type, getPickupCancelledDocumentRequest, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickupsApi.CancelledPickupDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelledPickupDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancelled Pickup Document
    ApiResponse<GetPickupCancelledDocumentResponse> response = apiInstance.CancelledPickupDocumentWithHttpInfo(type, getPickupCancelledDocumentRequest, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PickupsApi.CancelledPickupDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **type** | **string** | Indicates type of pickup. Supported value is &#x60;cancelled&#x60;. |  |
| **getPickupCancelledDocumentRequest** | [**GetPickupCancelledDocumentRequest**](GetPickupCancelledDocumentRequest.md) |  |  |
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

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
| **200** | The pick up has been cancelled. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpickupdocument"></a>
# **GetPickupDocument**
> GetPickupDocument GetPickupDocument (string pickupId, string? xPBDeveloperPartnerID = null)

Get Pickup Document

This operation returns the scheduled pickup or cancellation receipt in PDF format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class GetPickupDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PickupsApi(config);
            var pickupId = "pickupId_example";  // string | It specified the pickupId for which PDF receipt is needed.
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 

            try
            {
                // Get Pickup Document
                GetPickupDocument result = apiInstance.GetPickupDocument(pickupId, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickupsApi.GetPickupDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPickupDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Pickup Document
    ApiResponse<GetPickupDocument> response = apiInstance.GetPickupDocumentWithHttpInfo(pickupId, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PickupsApi.GetPickupDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **pickupId** | **string** | It specified the pickupId for which PDF receipt is needed. |  |
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

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
| **200** | Pick up document have been fetched. |  * X-Pb-Transactionid - The X-PB-TransactionId is unique id for this request. <br>  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpickups"></a>
# **GetPickups**
> GetAllPickups GetPickups (string? xPBDeveloperPartnerID = null, string? carrier = null, string? startDate = null, string? endDate = null, string? status = null, decimal? page = null, decimal? size = null)

Get Pickups

This operation is used to view the history of pickups scheduled or cancelled for your packages.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class GetPickupsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PickupsApi(config);
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 
            var carrier = "carrier_example";  // string? | Indicates CarrierID. If not provided, it would show pickups for all the carriers. (optional) 
            var startDate = "startDate_example";  // string? | Indicates start date from when you want to see the history. If not provided, it will take today's date. (optional) 
            var endDate = "endDate_example";  // string? | Indicates end date till you want to see the pickups history. If not provide, it will take today's date. (optional) 
            var status = "scheduled";  // string? | Indicates status of the pickup(schedule or cancel). If not provided, it will show the response for both status. (optional) 
            var page = 8.14D;  // decimal? | Indicates page number, if not provided page would be 1. (optional) 
            var size = 8.14D;  // decimal? | Indicates size of records, if not provided size would be 20 (optional) 

            try
            {
                // Get Pickups
                GetAllPickups result = apiInstance.GetPickups(xPBDeveloperPartnerID, carrier, startDate, endDate, status, page, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickupsApi.GetPickups: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPickupsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Pickups
    ApiResponse<GetAllPickups> response = apiInstance.GetPickupsWithHttpInfo(xPBDeveloperPartnerID, carrier, startDate, endDate, status, page, size);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PickupsApi.GetPickupsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **carrier** | **string?** | Indicates CarrierID. If not provided, it would show pickups for all the carriers. | [optional]  |
| **startDate** | **string?** | Indicates start date from when you want to see the history. If not provided, it will take today&#39;s date. | [optional]  |
| **endDate** | **string?** | Indicates end date till you want to see the pickups history. If not provide, it will take today&#39;s date. | [optional]  |
| **status** | **string?** | Indicates status of the pickup(schedule or cancel). If not provided, it will show the response for both status. | [optional]  |
| **page** | **decimal?** | Indicates page number, if not provided page would be 1. | [optional]  |
| **size** | **decimal?** | Indicates size of records, if not provided size would be 20 | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="schedulepickup"></a>
# **SchedulePickup**
> SchedulePickup200Response SchedulePickup (SchedulePickupRequest schedulePickupRequest, string? xPBDeveloperPartnerID = null)

Schedule Pickup

This operation allows to schedule Pickups with USPS, UPS, FedEx and DHLExpress for eligible shipments. <br> Below are four possible combinations for scheduling pickup <br>  <br> 1. When request does not specify `pickupSummary` and `shipmentIds`- The system would consider all eligible shipments created in a current day. <br> 2. When request specifies only `shipmentIds`- Pickup will be created for the shipmentIds mentioned <br> 3. When request specifies only `pickupSummary`- Pickup will be created for the pickup details mentioned in the pickupSummary <br> 4. When request specifies both `pickupSummary` and `shipmentIds`- Pickup will be created including details mentioned in both objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class SchedulePickupExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PickupsApi(config);
            var schedulePickupRequest = new SchedulePickupRequest(); // SchedulePickupRequest | 
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 

            try
            {
                // Schedule Pickup
                SchedulePickup200Response result = apiInstance.SchedulePickup(schedulePickupRequest, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PickupsApi.SchedulePickup: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SchedulePickupWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Schedule Pickup
    ApiResponse<SchedulePickup200Response> response = apiInstance.SchedulePickupWithHttpInfo(schedulePickupRequest, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PickupsApi.SchedulePickupWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **schedulePickupRequest** | [**SchedulePickupRequest**](SchedulePickupRequest.md) |  |  |
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

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
| **200** | The Pick up has been created successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

