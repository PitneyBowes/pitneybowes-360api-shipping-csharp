# com.pitneybowes.api360.Api.PrintApi

All URIs are relative to *https://api-sandbox.sendpro360.pitneybowes.com/shipping*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeletePrinterMapping**](PrintApi.md#deleteprintermapping) | **DELETE** /api/v1/printer/mapping | Delete Printer mapping |
| [**GetPrinterMapping**](PrintApi.md#getprintermapping) | **GET** /api/v1/printer/mapping | Get Printer mapping |
| [**JobStatus**](PrintApi.md#jobstatus) | **GET** /api/v1/jobs/{jobId} | Job status |
| [**PrintDocument**](PrintApi.md#printdocument) | **POST** /api/v1/document/print | Print Document |
| [**PrinterMapping**](PrintApi.md#printermapping) | **POST** /api/v1/printer/mapping | Printer mapping |

<a id="deleteprintermapping"></a>
# **DeletePrinterMapping**
> void DeletePrinterMapping (string alias, string? xPBDeveloperPartnerId = null, string? xPBLocationId = null, string? xPBTransactionId = null)

Delete Printer mapping

delete printer mapping document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class DeletePrinterMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PrintApi(config);
            var alias = "alias_example";  // string | Refers to a printer connected (directly or via network) to a computer.
            var xPBDeveloperPartnerId = "xPBDeveloperPartnerId_example";  // string? | The Developer Partner ID is assigned by PB to uniquely identify a Developer's strategic business partners. If the developer is the sole business partner, this field isn't required. (optional) 
            var xPBLocationId = "xPBLocationId_example";  // string? | This is the Location ID assigned as per the Developer's and Partner's parsed locations, to which all transactions will be billed. <br /> Partner's location will be used for billing if it is configured, however, in case Partner's location is not given, then the Developer's location will be taken. Developer's location will be the default value. <br /> Additionally, Developers and Partners can use carriers belong to this location only. (optional) 
            var xPBTransactionId = "xPBTransactionId_example";  // string? | A unique transaction Id provided by the partner which is used to enable debugging and linking between the client's transaction and the system. (optional) 

            try
            {
                // Delete Printer mapping
                apiInstance.DeletePrinterMapping(alias, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PrintApi.DeletePrinterMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePrinterMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Delete Printer mapping
    apiInstance.DeletePrinterMappingWithHttpInfo(alias, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PrintApi.DeletePrinterMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alias** | **string** | Refers to a printer connected (directly or via network) to a computer. |  |
| **xPBDeveloperPartnerId** | **string?** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **xPBLocationId** | **string?** | This is the Location ID assigned as per the Developer&#39;s and Partner&#39;s parsed locations, to which all transactions will be billed. &lt;br /&gt; Partner&#39;s location will be used for billing if it is configured, however, in case Partner&#39;s location is not given, then the Developer&#39;s location will be taken. Developer&#39;s location will be the default value. &lt;br /&gt; Additionally, Developers and Partners can use carriers belong to this location only. | [optional]  |
| **xPBTransactionId** | **string?** | A unique transaction Id provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. | [optional]  |

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
| **200** | Successfully deleted printer mapping |  -  |
| **401** | The request could not be authorized. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getprintermapping"></a>
# **GetPrinterMapping**
> PrinterMappingGetResponse GetPrinterMapping (string alias, string? xPBDeveloperPartnerId = null, string? xPBLocationId = null, string? xPBTransactionId = null)

Get Printer mapping

Get printer mapping document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class GetPrinterMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PrintApi(config);
            var alias = "alias_example";  // string | Refers to a printer connected (directly or via network) to a computer.
            var xPBDeveloperPartnerId = "xPBDeveloperPartnerId_example";  // string? | The Developer Partner ID is assigned by PB to uniquely identify a Developer's strategic business partners. If the developer is the sole business partner, this field isn't required. (optional) 
            var xPBLocationId = "xPBLocationId_example";  // string? | This is the Location ID assigned as per the Developer's and Partner's parsed locations, to which all transactions will be billed. <br /> Partner's location will be used for billing if it is configured, however, in case Partner's location is not given, then the Developer's location will be taken. Developer's location will be the default value. <br /> Additionally, Developers and Partners can use carriers belong to this location only. (optional) 
            var xPBTransactionId = "xPBTransactionId_example";  // string? | A unique transaction Id provided by the partner which is used to enable debugging and linking between the client's transaction and the system. (optional) 

            try
            {
                // Get Printer mapping
                PrinterMappingGetResponse result = apiInstance.GetPrinterMapping(alias, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PrintApi.GetPrinterMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPrinterMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Printer mapping
    ApiResponse<PrinterMappingGetResponse> response = apiInstance.GetPrinterMappingWithHttpInfo(alias, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PrintApi.GetPrinterMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alias** | **string** | Refers to a printer connected (directly or via network) to a computer. |  |
| **xPBDeveloperPartnerId** | **string?** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **xPBLocationId** | **string?** | This is the Location ID assigned as per the Developer&#39;s and Partner&#39;s parsed locations, to which all transactions will be billed. &lt;br /&gt; Partner&#39;s location will be used for billing if it is configured, however, in case Partner&#39;s location is not given, then the Developer&#39;s location will be taken. Developer&#39;s location will be the default value. &lt;br /&gt; Additionally, Developers and Partners can use carriers belong to this location only. | [optional]  |
| **xPBTransactionId** | **string?** | A unique transaction Id provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. | [optional]  |

### Return type

[**PrinterMappingGetResponse**](PrinterMappingGetResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Mapping printer Get Successfully |  -  |
| **401** | The request could not be authorized. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="jobstatus"></a>
# **JobStatus**
> JobStatus JobStatus (string jobId, string? xPBDeveloperPartnerId = null, string? xPBLocationId = null, string? xPBTransactionId = null)

Job status

job status

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class JobStatusExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PrintApi(config);
            var jobId = "jobId_example";  // string | The jobId, a unique identifier assigned for the job.
            var xPBDeveloperPartnerId = "xPBDeveloperPartnerId_example";  // string? | The Developer Partner ID is assigned by PB to uniquely identify a Developer's strategic business partners. If the developer is the sole business partner, this field isn't required. (optional) 
            var xPBLocationId = "xPBLocationId_example";  // string? | This is the Location ID assigned as per the Developer's and Partner's parsed locations, to which all transactions will be billed. <br /> Partner's location will be used for billing if it is configured, however, in case Partner's location is not given, then the Developer's location will be taken. Developer's location will be the default value. <br /> Additionally, Developers and Partners can use carriers belong to this location only. (optional) 
            var xPBTransactionId = "xPBTransactionId_example";  // string? | A unique transaction Id provided by the partner which is used to enable debugging and linking between the client's transaction and the system. (optional) 

            try
            {
                // Job status
                JobStatus result = apiInstance.JobStatus(jobId, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PrintApi.JobStatus: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the JobStatusWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Job status
    ApiResponse<JobStatus> response = apiInstance.JobStatusWithHttpInfo(jobId, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PrintApi.JobStatusWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **string** | The jobId, a unique identifier assigned for the job. |  |
| **xPBDeveloperPartnerId** | **string?** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **xPBLocationId** | **string?** | This is the Location ID assigned as per the Developer&#39;s and Partner&#39;s parsed locations, to which all transactions will be billed. &lt;br /&gt; Partner&#39;s location will be used for billing if it is configured, however, in case Partner&#39;s location is not given, then the Developer&#39;s location will be taken. Developer&#39;s location will be the default value. &lt;br /&gt; Additionally, Developers and Partners can use carriers belong to this location only. | [optional]  |
| **xPBTransactionId** | **string?** | A unique transaction Id provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. | [optional]  |

### Return type

[**JobStatus**](JobStatus.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The document has been printed successfully. |  -  |
| **401** | The request could not be authorized. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="printdocument"></a>
# **PrintDocument**
> PrintDocumentResponse PrintDocument (PrintDocumentRequest printDocumentRequest, string? xPBDeveloperPartnerId = null, string? xPBLocationId = null, string? xPBTransactionId = null)

Print Document

It contains information about a label or a document, e.g. a shipping label, a customs form, manifest report etc., that pertains to a shipment or manifest.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class PrintDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PrintApi(config);
            var printDocumentRequest = new PrintDocumentRequest(); // PrintDocumentRequest | 
            var xPBDeveloperPartnerId = "xPBDeveloperPartnerId_example";  // string? | The Developer Partner ID is assigned by PB to uniquely identify a Developer's strategic business partners. If the developer is the sole business partner, this field isn't required. (optional) 
            var xPBLocationId = "xPBLocationId_example";  // string? | This is the Location ID assigned as per the Developer's and Partner's parsed locations, to which all transactions will be billed. <br /> Partner's location will be used for billing if it is configured, however, in case Partner's location is not given, then the Developer's location will be taken. Developer's location will be the default value. <br /> Additionally, Developers and Partners can use carriers belong to this location only. (optional) 
            var xPBTransactionId = "xPBTransactionId_example";  // string? | A unique Transaction ID provided by the partner, which is used to enable debugging and linking between the client's transaction and the system. (optional) 

            try
            {
                // Print Document
                PrintDocumentResponse result = apiInstance.PrintDocument(printDocumentRequest, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PrintApi.PrintDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrintDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Print Document
    ApiResponse<PrintDocumentResponse> response = apiInstance.PrintDocumentWithHttpInfo(printDocumentRequest, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PrintApi.PrintDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **printDocumentRequest** | [**PrintDocumentRequest**](PrintDocumentRequest.md) |  |  |
| **xPBDeveloperPartnerId** | **string?** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **xPBLocationId** | **string?** | This is the Location ID assigned as per the Developer&#39;s and Partner&#39;s parsed locations, to which all transactions will be billed. &lt;br /&gt; Partner&#39;s location will be used for billing if it is configured, however, in case Partner&#39;s location is not given, then the Developer&#39;s location will be taken. Developer&#39;s location will be the default value. &lt;br /&gt; Additionally, Developers and Partners can use carriers belong to this location only. | [optional]  |
| **xPBTransactionId** | **string?** | A unique Transaction ID provided by the partner, which is used to enable debugging and linking between the client&#39;s transaction and the system. | [optional]  |

### Return type

[**PrintDocumentResponse**](PrintDocumentResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The document has been printed successfully. |  -  |
| **401** | The request could not be authorized. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="printermapping"></a>
# **PrinterMapping**
> PrinterMappingResponse PrinterMapping (PrinterMappingRequest printerMappingRequest, string? xPBDeveloperPartnerId = null, string? xPBLocationId = null, string? xPBTransactionId = null)

Printer mapping

printer mapping document

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class PrinterMappingExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new PrintApi(config);
            var printerMappingRequest = new PrinterMappingRequest(); // PrinterMappingRequest | 
            var xPBDeveloperPartnerId = "xPBDeveloperPartnerId_example";  // string? | The Developer Partner ID is assigned by PB to uniquely identify a Developer's strategic business partners. If the developer is the sole business partner, this field isn't required. (optional) 
            var xPBLocationId = "xPBLocationId_example";  // string? | This is the Location ID assigned as per the Developer's and Partner's parsed locations, to which all transactions will be billed. <br /> Partner's location will be used for billing if it is configured, however, in case Partner's location is not given, then the Developer's location will be taken. Developer's location will be the default value. <br /> Additionally, Developers and Partners can use carriers belong to this location only. (optional) 
            var xPBTransactionId = "xPBTransactionId_example";  // string? | A unique transaction Id provided by the partner which is used to enable debugging and linking between the client's transaction and the system. (optional) 

            try
            {
                // Printer mapping
                PrinterMappingResponse result = apiInstance.PrinterMapping(printerMappingRequest, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PrintApi.PrinterMapping: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the PrinterMappingWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Printer mapping
    ApiResponse<PrinterMappingResponse> response = apiInstance.PrinterMappingWithHttpInfo(printerMappingRequest, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PrintApi.PrinterMappingWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **printerMappingRequest** | [**PrinterMappingRequest**](PrinterMappingRequest.md) |  |  |
| **xPBDeveloperPartnerId** | **string?** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **xPBLocationId** | **string?** | This is the Location ID assigned as per the Developer&#39;s and Partner&#39;s parsed locations, to which all transactions will be billed. &lt;br /&gt; Partner&#39;s location will be used for billing if it is configured, however, in case Partner&#39;s location is not given, then the Developer&#39;s location will be taken. Developer&#39;s location will be the default value. &lt;br /&gt; Additionally, Developers and Partners can use carriers belong to this location only. | [optional]  |
| **xPBTransactionId** | **string?** | A unique transaction Id provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. | [optional]  |

### Return type

[**PrinterMappingResponse**](PrinterMappingResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Successfully mapped printer |  -  |
| **401** | The request could not be authorized. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

