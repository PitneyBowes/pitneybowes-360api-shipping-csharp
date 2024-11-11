# com.pitneybowes.api360.Api.MultipieceApi

All URIs are relative to *https://api-sandbox.sendpro360.pitneybowes.com/shipping*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**MultipieceRates**](MultipieceApi.md#multipiecerates) | **POST** /api/v1/multipiece/rates | Multipiece Rateshop and Rates |
| [**MultipieceShipment**](MultipieceApi.md#multipieceshipment) | **POST** /api/v1/multipiece/shipments | Multipiece Shipment |
| [**MultipieceShipmentCancel**](MultipieceApi.md#multipieceshipmentcancel) | **PUT** /api/v1/multipiece/shipments/{shipmentId}/cancel | Cancel Multipiece Shipment |
| [**MultipieceShipmentReprint**](MultipieceApi.md#multipieceshipmentreprint) | **GET** /api/v1/multipiece/shipments/{shipmentId}/reprint | Reprint Multipiece Shipment |

<a id="multipiecerates"></a>
# **MultipieceRates**
> MultipieceRates200Response MultipieceRates (MultipieceRatesRequest multipieceRatesRequest, string? xPBDeveloperPartnerID = null)

Multipiece Rateshop and Rates

This API contains 2 operations, rate shop and single rate. Rate shop will fetch rates for all carrier services based on the given addresses (From and To), weight, and dimension for given parcelType in multiPieceParcels object. Single rate will get rate for specific service and special service (if requested) based on the given addresses (From and To), weight, and dimension, parcelType and serviceId with or without specialServices. Single rate will be used mainly to a rate a shipment before creating shipment.  <br> For UPS- multipiece shipment with Envelopes (having parcel Type as LTR) is not supported.  <br> For FEDEX Multipiece, all parcels must be of same packaging type while creating multipiece shipment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class MultipieceRatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MultipieceApi(config);
            var multipieceRatesRequest = new MultipieceRatesRequest(); // MultipieceRatesRequest | 
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Develover Partner ID. When the developer is the only partner, this field is not required. (optional) 

            try
            {
                // Multipiece Rateshop and Rates
                MultipieceRates200Response result = apiInstance.MultipieceRates(multipieceRatesRequest, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MultipieceApi.MultipieceRates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MultipieceRatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Multipiece Rateshop and Rates
    ApiResponse<MultipieceRates200Response> response = apiInstance.MultipieceRatesWithHttpInfo(multipieceRatesRequest, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MultipieceApi.MultipieceRatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **multipieceRatesRequest** | [**MultipieceRatesRequest**](MultipieceRatesRequest.md) |  |  |
| **xPBDeveloperPartnerID** | **string?** | This is the Develover Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="multipieceshipment"></a>
# **MultipieceShipment**
> MultipieceShipment200Response MultipieceShipment (MultipieceShipmentRequest multipieceShipmentRequest, string? xPBDeveloperPartnerID = null)

Multipiece Shipment

This operation is used to create Multipiece Shipments. UPS, FedEx and DHL Express are supported for Multipiece Shipments.  <br> For UPS- multipiece shipment with Envelopes (having parcel Type as LTR) is not supported.  <br> For FEDEX Multipiece, all parcels must be of same packaging type while creating multipiece shipment

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class MultipieceShipmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MultipieceApi(config);
            var multipieceShipmentRequest = new MultipieceShipmentRequest(); // MultipieceShipmentRequest | 
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Develover Partner ID. When the developer is the only partner, this field is not required. (optional) 

            try
            {
                // Multipiece Shipment
                MultipieceShipment200Response result = apiInstance.MultipieceShipment(multipieceShipmentRequest, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MultipieceApi.MultipieceShipment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MultipieceShipmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Multipiece Shipment
    ApiResponse<MultipieceShipment200Response> response = apiInstance.MultipieceShipmentWithHttpInfo(multipieceShipmentRequest, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MultipieceApi.MultipieceShipmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **multipieceShipmentRequest** | [**MultipieceShipmentRequest**](MultipieceShipmentRequest.md) |  |  |
| **xPBDeveloperPartnerID** | **string?** | This is the Develover Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="multipieceshipmentcancel"></a>
# **MultipieceShipmentCancel**
> CancelShipment MultipieceShipmentCancel (string shipmentId, string? xPBDeveloperPartnerID = null)

Cancel Multipiece Shipment

This operation is used to cancel the multipiece label. It takes the shipmentId of the multipiece shipment done.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class MultipieceShipmentCancelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MultipieceApi(config);
            var shipmentId = "shipmentId_example";  // string | It specifies the shipmentId of onward shipment against which return label has to be created.
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Develover Partner ID. When the developer is the only partner, this field is not required. (optional) 

            try
            {
                // Cancel Multipiece Shipment
                CancelShipment result = apiInstance.MultipieceShipmentCancel(shipmentId, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MultipieceApi.MultipieceShipmentCancel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MultipieceShipmentCancelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel Multipiece Shipment
    ApiResponse<CancelShipment> response = apiInstance.MultipieceShipmentCancelWithHttpInfo(shipmentId, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MultipieceApi.MultipieceShipmentCancelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentId** | **string** | It specifies the shipmentId of onward shipment against which return label has to be created. |  |
| **xPBDeveloperPartnerID** | **string?** | This is the Develover Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="multipieceshipmentreprint"></a>
# **MultipieceShipmentReprint**
> MultipieceDomesticShipmentResponse MultipieceShipmentReprint (string shipmentId, string? xPBDeveloperPartnerID = null)

Reprint Multipiece Shipment

This operation is used to reprint the multipiece label. It takes the shipmentId of the multipiece shipment done.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class MultipieceShipmentReprintExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new MultipieceApi(config);
            var shipmentId = "shipmentId_example";  // string | It specifies the shipmentId of onward shipment against which return label has to be created.
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Develover Partner ID. When the developer is the only partner, this field is not required. (optional) 

            try
            {
                // Reprint Multipiece Shipment
                MultipieceDomesticShipmentResponse result = apiInstance.MultipieceShipmentReprint(shipmentId, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling MultipieceApi.MultipieceShipmentReprint: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the MultipieceShipmentReprintWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reprint Multipiece Shipment
    ApiResponse<MultipieceDomesticShipmentResponse> response = apiInstance.MultipieceShipmentReprintWithHttpInfo(shipmentId, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling MultipieceApi.MultipieceShipmentReprintWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentId** | **string** | It specifies the shipmentId of onward shipment against which return label has to be created. |  |
| **xPBDeveloperPartnerID** | **string?** | This is the Develover Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

### Return type

[**MultipieceDomesticShipmentResponse**](MultipieceDomesticShipmentResponse.md)

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

