# com.pitneybowes.api360.Api.BatchApi

All URIs are relative to *https://api-sandbox.sendpro360.pitneybowes.com/shipping*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**BulkImportAPI**](BatchApi.md#bulkimportapi) | **POST** /api/v1/shipments/importUrl | Bulk Import Shipments |
| [**BulkImportAPIERR**](BatchApi.md#bulkimportapierr) | **POST** /api/v1/err/shipments/importUrl | Bulk Import Shipments ERR |
| [**CreateBulkShipmentsAPI**](BatchApi.md#createbulkshipmentsapi) | **POST** /api/v1/bulkShipments | Create Bulk Shipments |
| [**CreateBulkShipmentsAPIERR**](BatchApi.md#createbulkshipmentsapierr) | **POST** /api/v1/err/bulkShipments | Create Bulk Shipments ERR |
| [**GetBatchStatusAPI**](BatchApi.md#getbatchstatusapi) | **GET** /api/v1/shipments/batch/{batchId}/status | Get Batch Status |
| [**GetShipmentDetailsForBatchAPI**](BatchApi.md#getshipmentdetailsforbatchapi) | **GET** /api/v1/shipments/batch/{batchId}/shipments | Get Batch Shipment Details |
| [**ProcessBatchAPI**](BatchApi.md#processbatchapi) | **POST** /api/v1/shipments/batch/{batchId}/process | Process Batch |
| [**VoidShippingLabel**](BatchApi.md#voidshippinglabel) | **POST** /api/v1/shipments/batch/{batchId}/void | Void Batch Shipping Labels |

<a id="bulkimportapi"></a>
# **BulkImportAPI**
> ShipmentBatch BulkImportAPI (CreateBatchRequest body, string? xPBDeveloperPartnerID = null)

Bulk Import Shipments

This operation imports the .CSV file, which includes all the required fields to create shipments in bulk. The payload contains information about the shipments you want to import, such as `carrier account`, `label layout`, `service`, and any `special services` required for the shipments. After batch is submitted, user needs to upload csv file of shipment transactions to the uploadURL returned in response.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class BulkImportAPIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BatchApi(config);
            var body = new CreateBatchRequest(); // CreateBatchRequest |  This is the Request body to bulk import shipments.
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 

            try
            {
                // Bulk Import Shipments
                ShipmentBatch result = apiInstance.BulkImportAPI(body, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.BulkImportAPI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkImportAPIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Import Shipments
    ApiResponse<ShipmentBatch> response = apiInstance.BulkImportAPIWithHttpInfo(body, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.BulkImportAPIWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateBatchRequest**](CreateBatchRequest.md) |  This is the Request body to bulk import shipments. |  |
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

### Return type

[**ShipmentBatch**](ShipmentBatch.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  The bulk shipment has been successfully imported. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="bulkimportapierr"></a>
# **BulkImportAPIERR**
> ShipmentBatchResponseERR BulkImportAPIERR (CreateBatchRequestERR body, string? xPBDeveloperPartnerID = null)

Bulk Import Shipments ERR

This operation imports the .CSV file which includes fields required for creating ERR (Electronic Return Receipt) Bulk Shipments.    The payload, which is used for shipment transactions, contains the following essential information in .CSV file:   - Carrier Account   - Output format: Shipping Label and Coversheet    - Services, and   - Special Services     The above-mentioned information are stored in AWS-S3 which in turn provides URL to users. When Batch is submitted, S3 returned URL along with .CSV file are uploaded, which generates BatchID.    The same BatchID is used to track the status of BulkImport. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class BulkImportAPIERRExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BatchApi(config);
            var body = new CreateBatchRequestERR(); // CreateBatchRequestERR |  This is the request body to import ERR Bulk shipments.
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | The PB-Developer-Partner-ID is assigned by PB to uniquely identify a developer's strategic business partners. If the developer is the sole business partner, this field is not required. (optional) 

            try
            {
                // Bulk Import Shipments ERR
                ShipmentBatchResponseERR result = apiInstance.BulkImportAPIERR(body, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.BulkImportAPIERR: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the BulkImportAPIERRWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Bulk Import Shipments ERR
    ApiResponse<ShipmentBatchResponseERR> response = apiInstance.BulkImportAPIERRWithHttpInfo(body, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.BulkImportAPIERRWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateBatchRequestERR**](CreateBatchRequestERR.md) |  This is the request body to import ERR Bulk shipments. |  |
| **xPBDeveloperPartnerID** | **string?** | The PB-Developer-Partner-ID is assigned by PB to uniquely identify a developer&#39;s strategic business partners. If the developer is the sole business partner, this field is not required. | [optional]  |

### Return type

[**ShipmentBatchResponseERR**](ShipmentBatchResponseERR.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  ERR Bulk Shipment has been successfully imported. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createbulkshipmentsapi"></a>
# **CreateBulkShipmentsAPI**
> BulkShipmentResponse CreateBulkShipmentsAPI (CreateBulkShipmentsAPIRequest body, string? xPBDeveloperPartnerID = null)

Create Bulk Shipments

This operation creates a batch of bulk (larger quantities) shipments for single or multiple recipients. The shipments can be addressed to a single or multiple recipients with different combination of carrier, service special services and parcel type. `carrierAccountId`, `parcelType`, `serviceId` and `specialServices` are used as default when user do not wish to provide at shipment level. If user choose to provide these at Shipment level then it overrides the values provided at root level. At shipment level either you can wish to provide all of `carrierAccountId`, `parcelType`, `serviceId` and `specialServices` or not provide all of them if wants to use default ones from root level. If user do not provide any one out of `carrierAccountId`, `parcelType` and `serviceId` at shipment level it would result in validation error

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class CreateBulkShipmentsAPIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BatchApi(config);
            var body = new CreateBulkShipmentsAPIRequest(); // CreateBulkShipmentsAPIRequest | This is the Request body to create bulk shipments.
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 

            try
            {
                // Create Bulk Shipments
                BulkShipmentResponse result = apiInstance.CreateBulkShipmentsAPI(body, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.CreateBulkShipmentsAPI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBulkShipmentsAPIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Bulk Shipments
    ApiResponse<BulkShipmentResponse> response = apiInstance.CreateBulkShipmentsAPIWithHttpInfo(body, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.CreateBulkShipmentsAPIWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateBulkShipmentsAPIRequest**](CreateBulkShipmentsAPIRequest.md) | This is the Request body to create bulk shipments. |  |
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

### Return type

[**BulkShipmentResponse**](BulkShipmentResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Batch Shipment has been created. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createbulkshipmentsapierr"></a>
# **CreateBulkShipmentsAPIERR**
> BulkShipmentResponseERR CreateBulkShipmentsAPIERR (CreateBulkShipmentsAPIERRRequest body, string? xPBDeveloperPartnerID = null)

Create Bulk Shipments ERR

ERR (Electronic Return Receipt) is an official United States Postal Service® (USPS) document designed to be equivalent to the hardcopy 'green card' Return Receipt. <br />    It provides the following information:   - Name of the Recipient     - Time when article is delivered   - Signature (image) of the Recipient     - Address where the item is delivered, and    - Date when the article gets delivered.      ERR is combined with certain classes and categories of mails, which are as follow:   - First-Class Mail®    - Priority Mail®     ERR Batch supports two types of Shipment Document format:    - Shipping Label    - Coversheet       This API \"Create Bulk Shipments with ERR\" operation requires the following information:   - Recipient (Single or Multiple)   - Carrier - USPS   - Service   - Parcel Type, and   - Special Service.    The ERR API works at two levels: Shipment level and Root level. Root level is marked as Default, where multiple shipments are processed and entities are common for all shipments. While at Shipment level, entities might differ. <br />   User can either define values for *CarrierAccountID*, *ParcelType*, *ServiceID*, and *SpecialService* respectively at the Root level for all shipments, or mention the values at Shipment level, i.e., for individual shipment(s).     If user does not provide values for the above-mentioned fields combinedly at Shipment level, then the default values for these fields provided at Root level will be considered. While, if user provides these values combinedly at Shipment Level for individual shipment(s), it will override the values defined at Root level. <br />   <br />   *Condition: The fields *CarrierAccountID*, *ParcelType*, *ServiceID* are treated as a combination, and values against each field must be provided if user selects Shipment level. In case any of these field(s) out of the mentioned combination is/are missing, it will return validation error.*    

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class CreateBulkShipmentsAPIERRExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BatchApi(config);
            var body = new CreateBulkShipmentsAPIERRRequest(); // CreateBulkShipmentsAPIERRRequest | This is the request body to create Bulk Shipment for ERR.
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | The Developer-Partner-ID is assigned by PB to uniquely identify a developer's strategic business partners. If the developer is the sole business partner, this field is not required. (optional) 

            try
            {
                // Create Bulk Shipments ERR
                BulkShipmentResponseERR result = apiInstance.CreateBulkShipmentsAPIERR(body, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.CreateBulkShipmentsAPIERR: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateBulkShipmentsAPIERRWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Bulk Shipments ERR
    ApiResponse<BulkShipmentResponseERR> response = apiInstance.CreateBulkShipmentsAPIERRWithHttpInfo(body, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.CreateBulkShipmentsAPIERRWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **body** | [**CreateBulkShipmentsAPIERRRequest**](CreateBulkShipmentsAPIERRRequest.md) | This is the request body to create Bulk Shipment for ERR. |  |
| **xPBDeveloperPartnerID** | **string?** | The Developer-Partner-ID is assigned by PB to uniquely identify a developer&#39;s strategic business partners. If the developer is the sole business partner, this field is not required. | [optional]  |

### Return type

[**BulkShipmentResponseERR**](BulkShipmentResponseERR.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Bulk Shipment for ERR has been successfully created. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getbatchstatusapi"></a>
# **GetBatchStatusAPI**
> GetStatusDetailedResponse GetBatchStatusAPI (string batchId, string? xPBDeveloperPartnerID = null)

Get Batch Status

This operation retrieves the status of an existing Batch using *Batch ID*. Once the Job status is completed, the URL received from Response can be used to download the shipping label in PDF format.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class GetBatchStatusAPIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BatchApi(config);
            var batchId = "batchId_example";  // string | This is a system-generated unique identifier assigned to the Batch while it is processed.
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | The Developer-Partner- ID is assigned by PB to uniquely identify a Developer's strategic business partners. If the developer is the sole business partner, this field is not required. (optional) 

            try
            {
                // Get Batch Status
                GetStatusDetailedResponse result = apiInstance.GetBatchStatusAPI(batchId, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.GetBatchStatusAPI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetBatchStatusAPIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Batch Status
    ApiResponse<GetStatusDetailedResponse> response = apiInstance.GetBatchStatusAPIWithHttpInfo(batchId, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.GetBatchStatusAPIWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **string** | This is a system-generated unique identifier assigned to the Batch while it is processed. |  |
| **xPBDeveloperPartnerID** | **string?** | The Developer-Partner- ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field is not required. | [optional]  |

### Return type

[**GetStatusDetailedResponse**](GetStatusDetailedResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Here, is the status of the Batch ID. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getshipmentdetailsforbatchapi"></a>
# **GetShipmentDetailsForBatchAPI**
> GetShipmentsForBatch GetShipmentDetailsForBatchAPI (string batchId, string? xPBDeveloperPartnerID = null, int? page = null, int? size = null, string? status = null, string? step = null)

Get Batch Shipment Details

\"This API operation provides the shipment details for those shipments which are SUCCESS or FAILED during batch processing at the following levels: - addressValidation - rating - labelGeneration, and - voidLabel  Based on fields/data mentioned in Query Parameter, user can check shipment details for particular status at any levels. <br /> If no values are provided in the fields mentioned in Query Parameter, the default for each will be: - Page: 1  - Size: 20 - Status: SUCCESS/FAILED. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class GetShipmentDetailsForBatchAPIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BatchApi(config);
            var batchId = "batchId_example";  // string | This is a system-generated unique identifier assigned to the Batch while it is processed
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | The Developer-Partner- ID is assigned by PB to uniquely identify a Developer's strategic business partners. If the developer is the sole business partner, this field is not required. (optional) 
            var page = 56;  // int? | It returns detailed information for shipments status and it can cover in one or more pages. The default value for page number is 1. (optional) 
            var size = 56;  // int? | Indicates the number of records per page. The default value for records is 20. (optional) 
            var status = "SUCCESS";  // string? | The status of the shipment. Values can be Failed or Success. (optional) 
            var step = "rating";  // string? | Indicates various stages of the batch processing. (optional) 

            try
            {
                // Get Batch Shipment Details
                GetShipmentsForBatch result = apiInstance.GetShipmentDetailsForBatchAPI(batchId, xPBDeveloperPartnerID, page, size, status, step);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.GetShipmentDetailsForBatchAPI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetShipmentDetailsForBatchAPIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Batch Shipment Details
    ApiResponse<GetShipmentsForBatch> response = apiInstance.GetShipmentDetailsForBatchAPIWithHttpInfo(batchId, xPBDeveloperPartnerID, page, size, status, step);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.GetShipmentDetailsForBatchAPIWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **string** | This is a system-generated unique identifier assigned to the Batch while it is processed |  |
| **xPBDeveloperPartnerID** | **string?** | The Developer-Partner- ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field is not required. | [optional]  |
| **page** | **int?** | It returns detailed information for shipments status and it can cover in one or more pages. The default value for page number is 1. | [optional]  |
| **size** | **int?** | Indicates the number of records per page. The default value for records is 20. | [optional]  |
| **status** | **string?** | The status of the shipment. Values can be Failed or Success. | [optional]  |
| **step** | **string?** | Indicates various stages of the batch processing. | [optional]  |

### Return type

[**GetShipmentsForBatch**](GetShipmentsForBatch.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Detailed status of processed shipments for the batch. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="processbatchapi"></a>
# **ProcessBatchAPI**
> ProcessShipmentResponse ProcessBatchAPI (string batchId, string? xPBDeveloperPartnerID = null)

Process Batch

This operation processes (executes) the existing Batch. The payload for this endpoint needs only an empty JSON object and no additional data is required in the request body. The BatchID parameter located in the endpoint specifies which batch of shipments to process.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class ProcessBatchAPIExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BatchApi(config);
            var batchId = "batchId_example";  // string | This is a system-generated unique identifier assigned to the Batch while it is processed.
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | The Developer-Partner-ID is assigned by PB to uniquely identify a Developer's strategic business partners. If the developer is the sole business partner, this field is not required. (optional) 

            try
            {
                // Process Batch
                ProcessShipmentResponse result = apiInstance.ProcessBatchAPI(batchId, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.ProcessBatchAPI: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ProcessBatchAPIWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Process Batch
    ApiResponse<ProcessShipmentResponse> response = apiInstance.ProcessBatchAPIWithHttpInfo(batchId, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.ProcessBatchAPIWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **string** | This is a system-generated unique identifier assigned to the Batch while it is processed. |  |
| **xPBDeveloperPartnerID** | **string?** | The Developer-Partner-ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field is not required. | [optional]  |

### Return type

[**ProcessShipmentResponse**](ProcessShipmentResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Batch has been processed successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="voidshippinglabel"></a>
# **VoidShippingLabel**
> VoidBatchResponse VoidShippingLabel (string batchId, string? xPBDeveloperPartnerID = null, VoidBatchRequest? voidBatchRequest = null)

Void Batch Shipping Labels

This operation cancels (voids) shipments which are created using the Batch API operation `createBulkShipments`. <br /> If user wants to cancel specific shipment(s) of the Batch, then s/he needs to pass the *Shipment ID* for the selected shipments in the `shipmentIDs` array. While if user wants to cancel all shipments of the Batch, then s/he does not need to provide any *Shipment ID* in the array under request body.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class VoidShippingLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new BatchApi(config);
            var batchId = "batchId_example";  // string | This is a system-generated unique identifier assigned to the Batch while it is processed.
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | The Developer-Partner-ID is assigned by PB to uniquely identify a Developer's strategic business partners. If the developer is the sole business partner, this field is not required. (optional) 
            var voidBatchRequest = new VoidBatchRequest?(); // VoidBatchRequest? |  This is the request body for cancelling the selected shipments or entire Batch of shipments*. (optional) 

            try
            {
                // Void Batch Shipping Labels
                VoidBatchResponse result = apiInstance.VoidShippingLabel(batchId, xPBDeveloperPartnerID, voidBatchRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling BatchApi.VoidShippingLabel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the VoidShippingLabelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Void Batch Shipping Labels
    ApiResponse<VoidBatchResponse> response = apiInstance.VoidShippingLabelWithHttpInfo(batchId, xPBDeveloperPartnerID, voidBatchRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling BatchApi.VoidShippingLabelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **batchId** | **string** | This is a system-generated unique identifier assigned to the Batch while it is processed. |  |
| **xPBDeveloperPartnerID** | **string?** | The Developer-Partner-ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field is not required. | [optional]  |
| **voidBatchRequest** | [**VoidBatchRequest?**](VoidBatchRequest?.md) |  This is the request body for cancelling the selected shipments or entire Batch of shipments*. | [optional]  |

### Return type

[**VoidBatchResponse**](VoidBatchResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The indicated shipment(s) of Batch have been successfully cancelled. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

