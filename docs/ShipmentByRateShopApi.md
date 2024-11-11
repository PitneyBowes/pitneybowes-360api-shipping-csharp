# com.pitneybowes.api360.Api.ShipmentByRateShopApi

All URIs are relative to *https://api-sandbox.sendpro360.pitneybowes.com/shipping*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelShipmentByIdV2**](ShipmentByRateShopApi.md#cancelshipmentbyidv2) | **POST** /api/v2/shipments/cancel | Cancel Shipment |
| [**CreateShipmentV2**](ShipmentByRateShopApi.md#createshipmentv2) | **POST** /api/v2/shipments | Create Shipment |
| [**ReprintShipmentByIdV2**](ShipmentByRateShopApi.md#reprintshipmentbyidv2) | **POST** /api/v2/shipments/reprint | Reprint Shipment |

<a id="cancelshipmentbyidv2"></a>
# **CancelShipmentByIdV2**
> CancelShipmentV2 CancelShipmentByIdV2 (ShipmentCancelV2 shipmentCancelV2, string? xPBDeveloperPartnerId = null, string? xPBLocationId = null, string? xPBTransactionId = null)

Cancel Shipment

The operation cancel/void shipment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class CancelShipmentByIdV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentByRateShopApi(config);
            var shipmentCancelV2 = new ShipmentCancelV2(); // ShipmentCancelV2 | 
            var xPBDeveloperPartnerId = "xPBDeveloperPartnerId_example";  // string? | The Developer Partner ID is assigned by PB to uniquely identify a Developer's strategic business partners. If the developer is the sole business partner, this field isn't required. (optional) 
            var xPBLocationId = "xPBLocationId_example";  // string? | This is the Location ID assigned as per the Developer's and Partner's parsed locations, to which all transactions will be billed. <br /> Partner's location will be used for billing if it is configured, however, in case Partner's location is not given, then the Developer's location will be taken. Developer's location will be the default value. <br /> Additionally, Developers and Partners can use carriers belong to this location only. (optional) 
            var xPBTransactionId = "xPBTransactionId_example";  // string? | A unique Transaction ID provided by the partner which is used to enable debugging and linking between the client's transaction and the system. (optional) 

            try
            {
                // Cancel Shipment
                CancelShipmentV2 result = apiInstance.CancelShipmentByIdV2(shipmentCancelV2, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentByRateShopApi.CancelShipmentByIdV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelShipmentByIdV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel Shipment
    ApiResponse<CancelShipmentV2> response = apiInstance.CancelShipmentByIdV2WithHttpInfo(shipmentCancelV2, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentByRateShopApi.CancelShipmentByIdV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentCancelV2** | [**ShipmentCancelV2**](ShipmentCancelV2.md) |  |  |
| **xPBDeveloperPartnerId** | **string?** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **xPBLocationId** | **string?** | This is the Location ID assigned as per the Developer&#39;s and Partner&#39;s parsed locations, to which all transactions will be billed. &lt;br /&gt; Partner&#39;s location will be used for billing if it is configured, however, in case Partner&#39;s location is not given, then the Developer&#39;s location will be taken. Developer&#39;s location will be the default value. &lt;br /&gt; Additionally, Developers and Partners can use carriers belong to this location only. | [optional]  |
| **xPBTransactionId** | **string?** | A unique Transaction ID provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createshipmentv2"></a>
# **CreateShipmentV2**
> DomesticShipmentResponseV2 CreateShipmentV2 (CreateShipmentV2Request createShipmentV2Request, string? xPBDeveloperPartnerId = null, string? xPBLocationId = null, string? xPBTransactionId = null)

Create Shipment

The operation creates a new Shipment or generate a Shipment Label. - To create a domestic shipment, the operation requires   - Domestic addresses 'To' and 'From' locations respectively within the same country   - carrier services, and   - associated special services. - While for the International shipment, the operation requires   - International address(es) for delivery, that is 'To' address must be the international country location(s) and not the same country mentioned in 'From' address   - supported international carrier services   - associated special service(s), and    - customs information. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class CreateShipmentV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentByRateShopApi(config);
            var createShipmentV2Request = new CreateShipmentV2Request(); // CreateShipmentV2Request | 
            var xPBDeveloperPartnerId = "xPBDeveloperPartnerId_example";  // string? | The Developer Partner ID is assigned by PB to uniquely identify a Developer's strategic business partners. If the developer is the sole business partner, this field isn't required. (optional) 
            var xPBLocationId = "xPBLocationId_example";  // string? | This is the Location ID assigned as per the Developer's and Partner's parsed locations, to which all transactions will be billed. <br /> Partner's location will be used for billing if it is configured, however, in case Partner's location is not given, then the Developer's location will be taken. Developer's location will be the default value. <br /> Additionally, Developers and Partners can use carriers belong to this location only. (optional) 
            var xPBTransactionId = "xPBTransactionId_example";  // string? | A unique Transaction ID provided by the partner, which is used to enable debugging and linking between the client's transaction and the system. (optional) 

            try
            {
                // Create Shipment
                DomesticShipmentResponseV2 result = apiInstance.CreateShipmentV2(createShipmentV2Request, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentByRateShopApi.CreateShipmentV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateShipmentV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Shipment
    ApiResponse<DomesticShipmentResponseV2> response = apiInstance.CreateShipmentV2WithHttpInfo(createShipmentV2Request, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentByRateShopApi.CreateShipmentV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createShipmentV2Request** | [**CreateShipmentV2Request**](CreateShipmentV2Request.md) |  |  |
| **xPBDeveloperPartnerId** | **string?** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **xPBLocationId** | **string?** | This is the Location ID assigned as per the Developer&#39;s and Partner&#39;s parsed locations, to which all transactions will be billed. &lt;br /&gt; Partner&#39;s location will be used for billing if it is configured, however, in case Partner&#39;s location is not given, then the Developer&#39;s location will be taken. Developer&#39;s location will be the default value. &lt;br /&gt; Additionally, Developers and Partners can use carriers belong to this location only. | [optional]  |
| **xPBTransactionId** | **string?** | A unique Transaction ID provided by the partner, which is used to enable debugging and linking between the client&#39;s transaction and the system. | [optional]  |

### Return type

[**DomesticShipmentResponseV2**](DomesticShipmentResponseV2.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reprintshipmentbyidv2"></a>
# **ReprintShipmentByIdV2**
> ReprintShipmentV2 ReprintShipmentByIdV2 (ShipmentReprintV2 shipmentReprintV2, string? xPBDeveloperPartnerId = null, string? xPBLocationId = null, string? xPBTransactionId = null)

Reprint Shipment

The operation reprints Shipment by the shipmentId. It retrieves an existing shipping label to reprint. The API sends the shipmentID returned by the original created shipment request. Use this only if the shipping label in the Create Shipment response is missing or lost.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class ReprintShipmentByIdV2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentByRateShopApi(config);
            var shipmentReprintV2 = new ShipmentReprintV2(); // ShipmentReprintV2 | 
            var xPBDeveloperPartnerId = "xPBDeveloperPartnerId_example";  // string? | The Developer Partner ID is assigned by PB to uniquely identify a Developer's strategic business partners. If the developer is the sole business partner, this field isn't required. (optional) 
            var xPBLocationId = "xPBLocationId_example";  // string? | This is the Location ID assigned as per the Developer's and Partner's parsed locations, to which all transactions will be billed. <br /> Partner's location will be used for billing if it is configured, however, in case Partner's location is not given, then the Developer's location will be taken. Developer's location will be the default value. <br /> Additionally, Developers and Partners can use carriers belong to this location only. (optional) 
            var xPBTransactionId = "xPBTransactionId_example";  // string? | A unique transaction Id provided by the partner which is used to enable debugging and linking between the client's transaction and the system. (optional) 

            try
            {
                // Reprint Shipment
                ReprintShipmentV2 result = apiInstance.ReprintShipmentByIdV2(shipmentReprintV2, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentByRateShopApi.ReprintShipmentByIdV2: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReprintShipmentByIdV2WithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reprint Shipment
    ApiResponse<ReprintShipmentV2> response = apiInstance.ReprintShipmentByIdV2WithHttpInfo(shipmentReprintV2, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentByRateShopApi.ReprintShipmentByIdV2WithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentReprintV2** | [**ShipmentReprintV2**](ShipmentReprintV2.md) |  |  |
| **xPBDeveloperPartnerId** | **string?** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **xPBLocationId** | **string?** | This is the Location ID assigned as per the Developer&#39;s and Partner&#39;s parsed locations, to which all transactions will be billed. &lt;br /&gt; Partner&#39;s location will be used for billing if it is configured, however, in case Partner&#39;s location is not given, then the Developer&#39;s location will be taken. Developer&#39;s location will be the default value. &lt;br /&gt; Additionally, Developers and Partners can use carriers belong to this location only. | [optional]  |
| **xPBTransactionId** | **string?** | A unique transaction Id provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

