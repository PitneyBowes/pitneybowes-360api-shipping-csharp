# com.pitneybowes.api360.Api.DefaultsApi

All URIs are relative to *https://api-sandbox.sendpro360.pitneybowes.com/shipping*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDefaults**](DefaultsApi.md#createdefaults) | **POST** /api/v1/defaults | Create Defaults |
| [**DeleteDefaultsById**](DefaultsApi.md#deletedefaultsbyid) | **DELETE** /api/v1/defaults/{defaultID} | Delete Defaults by ID |
| [**GetAllDefaults**](DefaultsApi.md#getalldefaults) | **GET** /api/v1/defaults | Get All Defaults |
| [**GetDefaultsById**](DefaultsApi.md#getdefaultsbyid) | **GET** /api/v1/defaults/{defaultID} | Get Defaults By ID |
| [**PutDefaultsById**](DefaultsApi.md#putdefaultsbyid) | **PUT** /api/v1/defaults/{defaultID} | Update Defaults |

<a id="createdefaults"></a>
# **CreateDefaults**
> CreateDefaultsResponse CreateDefaults (CreateDefaults createDefaults)

Create Defaults

While creating shipment, a few columns/ fields information are used mandatorily, and if the value for those columns are used repetitively, then it is always better to save last used values. And hence, this API has been introduced. Using this API, default values can be set up for frequently used columns/fields information like carrier, its linked services, and special services.  Setting up the defaults will save both time and efforts. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class CreateDefaultsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultsApi(config);
            var createDefaults = new CreateDefaults(); // CreateDefaults | 

            try
            {
                // Create Defaults
                CreateDefaultsResponse result = apiInstance.CreateDefaults(createDefaults);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultsApi.CreateDefaults: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDefaultsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Defaults
    ApiResponse<CreateDefaultsResponse> response = apiInstance.CreateDefaultsWithHttpInfo(createDefaults);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultsApi.CreateDefaultsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDefaults** | [**CreateDefaults**](CreateDefaults.md) |  |  |

### Return type

[**CreateDefaultsResponse**](CreateDefaultsResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Defaults (i.e., default values) have been created successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletedefaultsbyid"></a>
# **DeleteDefaultsById**
> void DeleteDefaultsById (string defaultID)

Delete Defaults by ID

This operation deletes the existing Defaults.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class DeleteDefaultsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultsApi(config);
            var defaultID = "defaultID_example";  // string | This is unique identifier assigned to Defaults while its creation using CreateDefaults API.

            try
            {
                // Delete Defaults by ID
                apiInstance.DeleteDefaultsById(defaultID);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultsApi.DeleteDefaultsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteDefaultsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Defaults by ID
    apiInstance.DeleteDefaultsByIdWithHttpInfo(defaultID);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultsApi.DeleteDefaultsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **defaultID** | **string** | This is unique identifier assigned to Defaults while its creation using CreateDefaults API. |  |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Defaults (i.e., default values) have been deleted successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getalldefaults"></a>
# **GetAllDefaults**
> AllDefaults GetAllDefaults (string? xPBDeveloperPartnerID = null, string? page = null, string? size = null)

Get All Defaults

The operation fetches all created Defaults. If query parameters are not provided, it will consider default page as 1 and default size as 10.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class GetAllDefaultsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultsApi(config);
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | The Developer Partner ID is assigned by PB to uniquely identify a Developer's strategic business partners. If the developer is the sole business partner, this field isn't required. (optional) 
            var page = "page_example";  // string? | The page of the Defaults search result list. (optional) 
            var size = "size_example";  // string? | The size/count of the searched result list. (optional) 

            try
            {
                // Get All Defaults
                AllDefaults result = apiInstance.GetAllDefaults(xPBDeveloperPartnerID, page, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultsApi.GetAllDefaults: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllDefaultsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get All Defaults
    ApiResponse<AllDefaults> response = apiInstance.GetAllDefaultsWithHttpInfo(xPBDeveloperPartnerID, page, size);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultsApi.GetAllDefaultsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerID** | **string?** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **page** | **string?** | The page of the Defaults search result list. | [optional]  |
| **size** | **string?** | The size/count of the searched result list. | [optional]  |

### Return type

[**AllDefaults**](AllDefaults.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Defaults. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdefaultsbyid"></a>
# **GetDefaultsById**
> DefaultResponse GetDefaultsById (string defaultID)

Get Defaults By ID

This operation fetches the values set for the Defaults.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class GetDefaultsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultsApi(config);
            var defaultID = "defaultID_example";  // string | This is unique identifier assigned to Defaults while its creation using CreateDefaults API.

            try
            {
                // Get Defaults By ID
                DefaultResponse result = apiInstance.GetDefaultsById(defaultID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultsApi.GetDefaultsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDefaultsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Defaults By ID
    ApiResponse<DefaultResponse> response = apiInstance.GetDefaultsByIdWithHttpInfo(defaultID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultsApi.GetDefaultsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **defaultID** | **string** | This is unique identifier assigned to Defaults while its creation using CreateDefaults API. |  |

### Return type

[**DefaultResponse**](DefaultResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Defaults values have been retrieved successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="putdefaultsbyid"></a>
# **PutDefaultsById**
> void PutDefaultsById (string defaultID, CreateDefaults createDefaults)

Update Defaults

This operation updates the values set for Defaults.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class PutDefaultsByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new DefaultsApi(config);
            var defaultID = "defaultID_example";  // string | This is unique identifier assigned to Defaults while its creation using CreateDefaults API.
            var createDefaults = new CreateDefaults(); // CreateDefaults | 

            try
            {
                // Update Defaults
                apiInstance.PutDefaultsById(defaultID, createDefaults);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DefaultsApi.PutDefaultsById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PutDefaultsByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Update Defaults
    apiInstance.PutDefaultsByIdWithHttpInfo(defaultID, createDefaults);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling DefaultsApi.PutDefaultsByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **defaultID** | **string** | This is unique identifier assigned to Defaults while its creation using CreateDefaults API. |  |
| **createDefaults** | [**CreateDefaults**](CreateDefaults.md) |  |  |

### Return type

void (empty response body)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Defaults (i.e., default values) have been updated successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

