# com.pitneybowes.api360.Api.AddressApi

All URIs are relative to *https://api-sandbox.sendpro360.pitneybowes.com/shipping*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**AddressSuggest**](AddressApi.md#addresssuggest) | **POST** /api/v1/address/suggest | Address Suggest |
| [**AddressValidate**](AddressApi.md#addressvalidate) | **POST** /api/v1/address/verify | Address Validate |

<a id="addresssuggest"></a>
# **AddressSuggest**
> AddressSuggestResponse AddressSuggest (AddressSuggestRequest addressSuggestRequest)

Address Suggest

This operation displays a valid address to match the entered address, only if the address does not seem valid to the system address map. User can select the suggested address or edit the entered address to make it valid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class AddressSuggestExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressApi(config);
            var addressSuggestRequest = new AddressSuggestRequest(); // AddressSuggestRequest | 

            try
            {
                // Address Suggest
                AddressSuggestResponse result = apiInstance.AddressSuggest(addressSuggestRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressApi.AddressSuggest: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressSuggestWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Address Suggest
    ApiResponse<AddressSuggestResponse> response = apiInstance.AddressSuggestWithHttpInfo(addressSuggestRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressApi.AddressSuggestWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addressSuggestRequest** | [**AddressSuggestRequest**](AddressSuggestRequest.md) |  |  |

### Return type

[**AddressSuggestResponse**](AddressSuggestResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The address is suggested to use. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="addressvalidate"></a>
# **AddressValidate**
> AddressValidateResponse AddressValidate (AddressValidateRequest addressValidateRequest, bool? minimalAddressValidation = null)

Address Validate

This operation validates address. This improves postal addresses within the country (e.g., United States) to help ensure that parcels are rated accurately and shipments arrive at the final destination on time.<br> The verify address operation sends an address to be verified. The response indicates whether the address is valid.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class AddressValidateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new AddressApi(config);
            var addressValidateRequest = new AddressValidateRequest(); // AddressValidateRequest | 
            var minimalAddressValidation = true;  // bool? | If true, then only City, State, and PostalCode (zip) are validated. This option is specific for US domestic addresses only. (optional) 

            try
            {
                // Address Validate
                AddressValidateResponse result = apiInstance.AddressValidate(addressValidateRequest, minimalAddressValidation);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AddressApi.AddressValidate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the AddressValidateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Address Validate
    ApiResponse<AddressValidateResponse> response = apiInstance.AddressValidateWithHttpInfo(addressValidateRequest, minimalAddressValidation);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AddressApi.AddressValidateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **addressValidateRequest** | [**AddressValidateRequest**](AddressValidateRequest.md) |  |  |
| **minimalAddressValidation** | **bool?** | If true, then only City, State, and PostalCode (zip) are validated. This option is specific for US domestic addresses only. | [optional]  |

### Return type

[**AddressValidateResponse**](AddressValidateResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The address has been verified. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

