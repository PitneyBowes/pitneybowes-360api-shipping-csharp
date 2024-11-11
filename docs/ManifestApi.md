# com.pitneybowes.api360.Api.ManifestApi

All URIs are relative to *https://api-sandbox.sendpro360.pitneybowes.com/shipping*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateManifest**](ManifestApi.md#createmanifest) | **POST** /api/v1/manifests | Create Manifest |
| [**ReprintManifest**](ManifestApi.md#reprintmanifest) | **POST** /api/v1/manifests/reprint | Reprint manifest |

<a id="createmanifest"></a>
# **CreateManifest**
> CreateManifest200Response CreateManifest (string? xPBDeveloperPartnerID = null, bool? compactResponse = null, CreateManifestRequest? createManifestRequest = null)

Create Manifest

This operation creates an end-of-day manifest (a compilation of information about all shipments) that combines all shipments of the day into a single form or electronic record, depending on the carrier. For different carriers, the Manifest process varies, e.g., USPS use SCAN Form while FedEx has Manifest Form.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class CreateManifestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ManifestApi(config);
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 
            var compactResponse = false;  // bool? | This header defines if the response required is detailed or compact. When value is set to true, it will only return manifest details in response.  (optional) 
            var createManifestRequest = new CreateManifestRequest?(); // CreateManifestRequest? |  (optional) 

            try
            {
                // Create Manifest
                CreateManifest200Response result = apiInstance.CreateManifest(xPBDeveloperPartnerID, compactResponse, createManifestRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManifestApi.CreateManifest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateManifestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Manifest
    ApiResponse<CreateManifest200Response> response = apiInstance.CreateManifestWithHttpInfo(xPBDeveloperPartnerID, compactResponse, createManifestRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManifestApi.CreateManifestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **compactResponse** | **bool?** | This header defines if the response required is detailed or compact. When value is set to true, it will only return manifest details in response.  | [optional]  |
| **createManifestRequest** | [**CreateManifestRequest?**](CreateManifestRequest?.md) |  | [optional]  |

### Return type

[**CreateManifest200Response**](CreateManifest200Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Manifest has been generated for the given carrier. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reprintmanifest"></a>
# **ReprintManifest**
> CreateManifest200Response ReprintManifest (string? xPBDeveloperPartnerID = null, bool? compactResponse = null, ReprintManifestRequest? reprintManifestRequest = null)

Reprint manifest

This operation reprints a manifest for which the initial created manifest request was successful.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class ReprintManifestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ManifestApi(config);
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 
            var compactResponse = false;  // bool? | This header defines if the response required is detailed or compact. When value is set to true, it will only return manifest details in response. (optional) 
            var reprintManifestRequest = new ReprintManifestRequest?(); // ReprintManifestRequest? |  (optional) 

            try
            {
                // Reprint manifest
                CreateManifest200Response result = apiInstance.ReprintManifest(xPBDeveloperPartnerID, compactResponse, reprintManifestRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ManifestApi.ReprintManifest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReprintManifestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reprint manifest
    ApiResponse<CreateManifest200Response> response = apiInstance.ReprintManifestWithHttpInfo(xPBDeveloperPartnerID, compactResponse, reprintManifestRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ManifestApi.ReprintManifestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **compactResponse** | **bool?** | This header defines if the response required is detailed or compact. When value is set to true, it will only return manifest details in response. | [optional]  |
| **reprintManifestRequest** | [**ReprintManifestRequest?**](ReprintManifestRequest?.md) |  | [optional]  |

### Return type

[**CreateManifest200Response**](CreateManifest200Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Manifest has been printed successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

