# com.pitneybowes.api360.Api.ShipmentApi

All URIs are relative to *https://api-sandbox.sendpro360.pitneybowes.com/shipping*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CancelShipmentById**](ShipmentApi.md#cancelshipmentbyid) | **PUT** /api/v1/shipments/{shipmentId}/cancel | Cancel Shipment |
| [**CancelStampsERR**](ShipmentApi.md#cancelstampserr) | **POST** /api/v1/err/stamps/void | Cancel Stamps ERR |
| [**CreateReturnLabel**](ShipmentApi.md#createreturnlabel) | **POST** /api/v1/shipments/{shipmentId}/return | Create Return label shipment |
| [**CreateShipment**](ShipmentApi.md#createshipment) | **POST** /api/v1/shipments | Create Shipment |
| [**DownloadBpodFiles**](ShipmentApi.md#downloadbpodfiles) | **POST** /api/v1/err/shipments/bpod | Download BPOD Files |
| [**GetAllShipments**](ShipmentApi.md#getallshipments) | **GET** /api/v1/shipments | Get All Shipments |
| [**GetCarrierAccounts**](ShipmentApi.md#getcarrieraccounts) | **GET** /api/v1/carrierAccounts | Get Carrier Accounts |
| [**GetCarriers**](ShipmentApi.md#getcarriers) | **GET** /api/v1/carriers | Get Carriers |
| [**GetCountries**](ShipmentApi.md#getcountries) | **GET** /api/v1/countries | Get Countries |
| [**GetParcelTypes**](ShipmentApi.md#getparceltypes) | **GET** /api/v1/parcelTypes | Get Parcel Types |
| [**GetRates**](ShipmentApi.md#getrates) | **POST** /api/v1/rates | Rate Shop and Get Single Rate |
| [**GetServices**](ShipmentApi.md#getservices) | **GET** /api/v1/services | Get Services |
| [**GetSignatureImageERR**](ShipmentApi.md#getsignatureimageerr) | **GET** /api/v1/err/shipments/{shipmentId}/signaturefile | Signature Image ERR |
| [**GetSpecialServices**](ShipmentApi.md#getspecialservices) | **GET** /api/v1/specialServices | Get Special Services |
| [**ReprintShipmentById**](ShipmentApi.md#reprintshipmentbyid) | **GET** /api/v1/shipments/{shipmentId}/reprint | Reprint Shipment |
| [**ShipmentById**](ShipmentApi.md#shipmentbyid) | **GET** /api/v1/shipments/{shipmentId} | Get Shipment by Id |

<a id="cancelshipmentbyid"></a>
# **CancelShipmentById**
> CancelShipment CancelShipmentById (string shipmentId, string? xPBDeveloperPartnerID = null)

Cancel Shipment

This operation cancel/void shipment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class CancelShipmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentApi(config);
            var shipmentId = "shipmentId_example";  // string | This indicates the shipmentId, a unique identifier assigned for the Shipment.
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 

            try
            {
                // Cancel Shipment
                CancelShipment result = apiInstance.CancelShipmentById(shipmentId, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.CancelShipmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelShipmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel Shipment
    ApiResponse<CancelShipment> response = apiInstance.CancelShipmentByIdWithHttpInfo(shipmentId, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.CancelShipmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentId** | **string** | This indicates the shipmentId, a unique identifier assigned for the Shipment. |  |
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

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
| **200** | The Shipment has been cancelled. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="cancelstampserr"></a>
# **CancelStampsERR**
> CancelStampsResponseERR CancelStampsERR (CancelStampsRequestERR cancelStampsRequestERR, string? xPBDeveloperPartnerID = null)

Cancel Stamps ERR

This operation cancels (voids) stamps generated for ERR (Electronic Return Receipt).  - User needs to provide *Stamp IDs* to cancel those specific ERR stamps.  - User can download the *Refund Form* having details of generated Postage.  - At once, maximum 1000 stamps can be requested for cancelation. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class CancelStampsERRExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentApi(config);
            var cancelStampsRequestERR = new CancelStampsRequestERR(); // CancelStampsRequestERR | 
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | The Developer Partner ID is assigned by PB to uniquely identify a Developer's strategic business partners. If the developer is the sole business partner, this field is not required. (optional) 

            try
            {
                // Cancel Stamps ERR
                CancelStampsResponseERR result = apiInstance.CancelStampsERR(cancelStampsRequestERR, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.CancelStampsERR: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CancelStampsERRWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Cancel Stamps ERR
    ApiResponse<CancelStampsResponseERR> response = apiInstance.CancelStampsERRWithHttpInfo(cancelStampsRequestERR, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.CancelStampsERRWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **cancelStampsRequestERR** | [**CancelStampsRequestERR**](CancelStampsRequestERR.md) |  |  |
| **xPBDeveloperPartnerID** | **string?** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field is not required. | [optional]  |

### Return type

[**CancelStampsResponseERR**](CancelStampsResponseERR.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/pdf, application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Stamps Refund Form has been generated. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createreturnlabel"></a>
# **CreateReturnLabel**
> ReturnLabelResponse CreateReturnLabel (string shipmentId, ReturnLabel returnLabel, string? xPBDeveloperPartnerID = null)

Create Return label shipment

This operation creates a return label based on a previous shipment. <br> The return label can be created in two ways:  <br> 1. User need not to provide any details of package, address and service. The API would take all details from the shipmentId mentioned in the path parameter and would swap the address and create return label. However for UPS `specialServices` object is required as carrier mandates to provide package description with PRL special service. <br> 2. User can customize the request by passing `fromAddress`, `toAddress`, `parcelType`, `serviceId` in the request itself. <br> Please Note that for UPS it is required to pass `specialServices` object with `PRL` service id and  input parameters with name as `RETURN_PKG_DESCRIPTION`. <br> For FedEx `specialServices` object is not required and PRL is added by default while creating return.  If user wishes to provide RMA number, it can be passed in `specialServices` object in the request body. <br> Please Note If user provides any information in this request it overrides the information in onward shipment which was created <br> For example if user provides toAddress in the request the return label will get created with recipient as mentioned in toAddress and  if user provides fromAddress in the request, the return label will be created with sender as mentioned in fromAddress

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class CreateReturnLabelExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentApi(config);
            var shipmentId = "shipmentId_example";  // string | It specifies the shipmentId of onward shipment against which return label has to be created.
            var returnLabel = new ReturnLabel(); // ReturnLabel | 
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 

            try
            {
                // Create Return label shipment
                ReturnLabelResponse result = apiInstance.CreateReturnLabel(shipmentId, returnLabel, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.CreateReturnLabel: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateReturnLabelWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Return label shipment
    ApiResponse<ReturnLabelResponse> response = apiInstance.CreateReturnLabelWithHttpInfo(shipmentId, returnLabel, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.CreateReturnLabelWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentId** | **string** | It specifies the shipmentId of onward shipment against which return label has to be created. |  |
| **returnLabel** | [**ReturnLabel**](ReturnLabel.md) |  |  |
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

### Return type

[**ReturnLabelResponse**](ReturnLabelResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Return Label has been created successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createshipment"></a>
# **CreateShipment**
> CreateShipment200Response CreateShipment (CreateShipmentRequest createShipmentRequest, string? xPBDeveloperPartnerID = null)

Create Shipment

This operation creates a new Shipment or Shipment Label. This is for both Domestic and International.<br> For domestic, Create a shipment requires domestic addresses (within same country)- ToAddress and FromAddress, and  carrier service and special service.<br> While for International, Create a shipment requires international delivery, that is ToAddress must be the different country (and not the same country mentioned in From Address), selected services, special services, and customs information. <br> <br> Note- To create Return shipment using this API- If PRL (return special service) is used, user need to provide sender address (from where return shipment is to be created) in `fromAddress` object and recipient address (to where return is to be created) in `toAddress` object. System will not swap the address for return in this API. If you want to create return for the already created shipment, you may use `Create Return Label Shipment` API. <br> <br> Note: Currently Shipment created from below API gets assigned to the Default location of the subscription.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class CreateShipmentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentApi(config);
            var createShipmentRequest = new CreateShipmentRequest(); // CreateShipmentRequest | 
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 

            try
            {
                // Create Shipment
                CreateShipment200Response result = apiInstance.CreateShipment(createShipmentRequest, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.CreateShipment: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateShipmentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Create Shipment
    ApiResponse<CreateShipment200Response> response = apiInstance.CreateShipmentWithHttpInfo(createShipmentRequest, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.CreateShipmentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createShipmentRequest** | [**CreateShipmentRequest**](CreateShipmentRequest.md) |  |  |
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

### Return type

[**CreateShipment200Response**](CreateShipment200Response.md)

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

<a id="downloadbpodfiles"></a>
# **DownloadBpodFiles**
> BPODDownloadResponse DownloadBpodFiles (string? xPBDeveloperPartnerID = null, string? startDate = null, string? endDate = null, BPODDownloadRequest? body = null)

Download BPOD Files

This API operation is used to download bulk of ERR (*Electronic Return Receipt*) - POD (*Proof of Delivery*) files, which are specific to USPS carrier. <br />   User can download BPOD (*Bulk Proof of Delivery*) files either using *Shipment IDs* or *Date Range*.    If user wants to check records based on dates and download BPOD files accordingly, then *Start Date* and *End Date* need to be passed in the request body as filter. Else *Shipment IDs* will be used as default value when user does not provide *DateRange* filter. <br />   User is restricted to download 1000 BPOD files as max limit. 

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class DownloadBpodFilesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentApi(config);
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | The Developer Partner ID is assigned by PB to uniquely identify a Developer's strategic business partners. If the developer is the sole business partner, this field is not required. (optional) 
            var startDate = "startDate_example";  // string? | The BPOD files to be downloaded from which Date is the startDate in the Date Range filter. This field is not required if the Shipment IDs provided in the request body. (optional) 
            var endDate = "endDate_example";  // string? | The BPOD files to be downloaded till which Date is the endDate in the Date Range filter. This field is not required if the Shipment IDs provided in the request body. (optional) 
            var body = new BPODDownloadRequest?(); // BPODDownloadRequest? | This is the request body to download BPOD files. Request body supports max of 1000 ShipmentIDs in a request. (optional) 

            try
            {
                // Download BPOD Files
                BPODDownloadResponse result = apiInstance.DownloadBpodFiles(xPBDeveloperPartnerID, startDate, endDate, body);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.DownloadBpodFiles: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DownloadBpodFilesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Download BPOD Files
    ApiResponse<BPODDownloadResponse> response = apiInstance.DownloadBpodFilesWithHttpInfo(xPBDeveloperPartnerID, startDate, endDate, body);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.DownloadBpodFilesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerID** | **string?** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field is not required. | [optional]  |
| **startDate** | **string?** | The BPOD files to be downloaded from which Date is the startDate in the Date Range filter. This field is not required if the Shipment IDs provided in the request body. | [optional]  |
| **endDate** | **string?** | The BPOD files to be downloaded till which Date is the endDate in the Date Range filter. This field is not required if the Shipment IDs provided in the request body. | [optional]  |
| **body** | [**BPODDownloadRequest?**](BPODDownloadRequest?.md) | This is the request body to download BPOD files. Request body supports max of 1000 ShipmentIDs in a request. | [optional]  |

### Return type

[**BPODDownloadResponse**](BPODDownloadResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The ZIP URL for BPOD files has been created for download. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getallshipments"></a>
# **GetAllShipments**
> GetAllShipments GetAllShipments (string? xPBDeveloperPartnerID = null, string? startDate = null, string? endDate = null, string? page = null, string? size = null)

Get All Shipments

This operation fetches all created Shipments. If query parameters are not provided, it will default endDate as current date, page as 1 and size as 10.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class GetAllShipmentsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentApi(config);
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 
            var startDate = "startDate_example";  // string? | While searching shipments, user set a date range to get all created shipments. This indicatesthe start date of the set date range under shipment search criteria. The date format must be: YYYY-MM-DD. (optional) 
            var endDate = "endDate_example";  // string? | While searching shipments, user set a date range to get all created shipments. This indicatesthe end date of the set date range under shipment search criteria. The date format must be: YYYY-MM-DD. (optional) 
            var page = "page_example";  // string? | This indicates the page of the Shipments search result list. (optional) 
            var size = "size_example";  // string? | This indicates the size/count of the searched result list. (optional) 

            try
            {
                // Get All Shipments
                GetAllShipments result = apiInstance.GetAllShipments(xPBDeveloperPartnerID, startDate, endDate, page, size);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.GetAllShipments: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAllShipmentsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get All Shipments
    ApiResponse<GetAllShipments> response = apiInstance.GetAllShipmentsWithHttpInfo(xPBDeveloperPartnerID, startDate, endDate, page, size);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.GetAllShipmentsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **startDate** | **string?** | While searching shipments, user set a date range to get all created shipments. This indicatesthe start date of the set date range under shipment search criteria. The date format must be: YYYY-MM-DD. | [optional]  |
| **endDate** | **string?** | While searching shipments, user set a date range to get all created shipments. This indicatesthe end date of the set date range under shipment search criteria. The date format must be: YYYY-MM-DD. | [optional]  |
| **page** | **string?** | This indicates the page of the Shipments search result list. | [optional]  |
| **size** | **string?** | This indicates the size/count of the searched result list. | [optional]  |

### Return type

[**GetAllShipments**](GetAllShipments.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of shipments. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcarrieraccounts"></a>
# **GetCarrierAccounts**
> GetCarrierAccounts200Response GetCarrierAccounts (string? xPBDeveloperPartnerID = null)

Get Carrier Accounts

This operation retrieves onboarded Carriers with their Carrier Account Ids which uniquely identify multiple accounts of same carrier.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class GetCarrierAccountsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentApi(config);
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 

            try
            {
                // Get Carrier Accounts
                GetCarrierAccounts200Response result = apiInstance.GetCarrierAccounts(xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.GetCarrierAccounts: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCarrierAccountsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Carrier Accounts
    ApiResponse<GetCarrierAccounts200Response> response = apiInstance.GetCarrierAccountsWithHttpInfo(xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.GetCarrierAccountsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

### Return type

[**GetCarrierAccounts200Response**](GetCarrierAccounts200Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Carrier Accounts has been fetched. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcarriers"></a>
# **GetCarriers**
> Carriers GetCarriers (string? xPBDeveloperPartnerID = null)

Get Carriers

This operation fetches all supported carriers. This service is used to get list of supported carriers and their properties.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class GetCarriersExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentApi(config);
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 

            try
            {
                // Get Carriers
                Carriers result = apiInstance.GetCarriers(xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.GetCarriers: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCarriersWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Carriers
    ApiResponse<Carriers> response = apiInstance.GetCarriersWithHttpInfo(xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.GetCarriersWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

### Return type

[**Carriers**](Carriers.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The available carriers have been fetched. |  * X-Pb-Transactionid - The X-PB-TransactionId is unique id for this request. <br>  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getcountries"></a>
# **GetCountries**
> List&lt;CountriesInner&gt; GetCountries (string? xPBDeveloperPartnerID = null, string? carrier = null, string? originCountryCode = null)

Get Countries

This operation fetches list of supported destination countries for a provided carrier and origin country. If query parameters are not provided, it will default to `USPS` as carrier and `US` as origin country.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class GetCountriesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentApi(config);
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 
            var carrier = "carrier_example";  // string? | This indicates the carrierID, a unique identifier given to  an individual carrier. (optional) 
            var originCountryCode = "originCountryCode_example";  // string? | This indicates the Source Country. The two-character ISO country code for the country where the Shipment originates. (optional) 

            try
            {
                // Get Countries
                List<CountriesInner> result = apiInstance.GetCountries(xPBDeveloperPartnerID, carrier, originCountryCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.GetCountries: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetCountriesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Countries
    ApiResponse<List<CountriesInner>> response = apiInstance.GetCountriesWithHttpInfo(xPBDeveloperPartnerID, carrier, originCountryCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.GetCountriesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **carrier** | **string?** | This indicates the carrierID, a unique identifier given to  an individual carrier. | [optional]  |
| **originCountryCode** | **string?** | This indicates the Source Country. The two-character ISO country code for the country where the Shipment originates. | [optional]  |

### Return type

[**List&lt;CountriesInner&gt;**](CountriesInner.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Countries has been fetched. |  * X-Pb-Transactionid - The X-PB-TransactionId is unique id for this request. <br>  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getparceltypes"></a>
# **GetParcelTypes**
> List&lt;ParcelTypesInner&gt; GetParcelTypes (string? xPBDeveloperPartnerID = null, string? carrier = null, string? originCountryCode = null, string? destinationCountryCode = null)

Get Parcel Types

This operation fetches Parcel Types based on the provided carrier, origin county, and the destination country. If query parameters are not provided, this will default to `USPS` as carrier, `US` as both origin and destination country code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class GetParcelTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentApi(config);
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 
            var carrier = "carrier_example";  // string? | This indicates the CarrierID, a unique identifier given to an individual carrier. It can be referred from the response of Get Carriers API (optional) 
            var originCountryCode = "originCountryCode_example";  // string? | This indicates the Source Country. The two-character ISO country code for the country where the Shipment originates. (optional) 
            var destinationCountryCode = "destinationCountryCode_example";  // string? | This indicates the Destination Country for the Shipment. The two-character ISO country code for the country where the shipment is to be delivered. (optional) 

            try
            {
                // Get Parcel Types
                List<ParcelTypesInner> result = apiInstance.GetParcelTypes(xPBDeveloperPartnerID, carrier, originCountryCode, destinationCountryCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.GetParcelTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetParcelTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Parcel Types
    ApiResponse<List<ParcelTypesInner>> response = apiInstance.GetParcelTypesWithHttpInfo(xPBDeveloperPartnerID, carrier, originCountryCode, destinationCountryCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.GetParcelTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **carrier** | **string?** | This indicates the CarrierID, a unique identifier given to an individual carrier. It can be referred from the response of Get Carriers API | [optional]  |
| **originCountryCode** | **string?** | This indicates the Source Country. The two-character ISO country code for the country where the Shipment originates. | [optional]  |
| **destinationCountryCode** | **string?** | This indicates the Destination Country for the Shipment. The two-character ISO country code for the country where the shipment is to be delivered. | [optional]  |

### Return type

[**List&lt;ParcelTypesInner&gt;**](ParcelTypesInner.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of Parcel Types has been fetched. |  * X-Pb-Transactionid - The X-PB-TransactionId is unique id for this request. <br>  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getrates"></a>
# **GetRates**
> GetRates200Response GetRates (GetRatesRequest getRatesRequest, string? xPBDeveloperPartnerID = null, bool? compactResponse = null)

Rate Shop and Get Single Rate

This API contains 2 operations, rate shop and single rate. Rate shop will fetch rates for all carrier services based on the given addresses (From and To), weight, and dimension for given parcelType. If parcelType is not provided, it will default to `PKG`. Single rate will get rate for specific service and special service (if requested) based on the given addresses (From and To), weight, and dimension, parcelType and serviceId with or without specialServices. Single rate will be used mainly to a rate a shipment before creating shipment.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class GetRatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentApi(config);
            var getRatesRequest = new GetRatesRequest(); // GetRatesRequest | 
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 
            var compactResponse = true;  // bool? | This header defines if the response required is detailed or compact. When value is set to true, it will only return rates object in response. (optional) 

            try
            {
                // Rate Shop and Get Single Rate
                GetRates200Response result = apiInstance.GetRates(getRatesRequest, xPBDeveloperPartnerID, compactResponse);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.GetRates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetRatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Rate Shop and Get Single Rate
    ApiResponse<GetRates200Response> response = apiInstance.GetRatesWithHttpInfo(getRatesRequest, xPBDeveloperPartnerID, compactResponse);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.GetRatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **getRatesRequest** | [**GetRatesRequest**](GetRatesRequest.md) |  |  |
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **compactResponse** | **bool?** | This header defines if the response required is detailed or compact. When value is set to true, it will only return rates object in response. | [optional]  |

### Return type

[**GetRates200Response**](GetRates200Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Rating is done for the shipment(s). |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getservices"></a>
# **GetServices**
> List&lt;ServicesInner&gt; GetServices (string? xPBDeveloperPartnerID = null, string? carrier = null, string? originCountryCode = null, string? destinationCountryCode = null)

Get Services

This operation fetches a list of supported services for a carrier with respect to specific origin and destination country. If query parameters are not provided, this will default to `USPS` as carrier, `US` as both origin and destination country code.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class GetServicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentApi(config);
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 
            var carrier = "carrier_example";  // string? | This indicates the CarrierID, a unique identifier provided to an individual carrier. It can be referred from the response of Get Carriers API (optional) 
            var originCountryCode = "originCountryCode_example";  // string? | This indicates the Source Country. The two-character ISO country code for the country where the Shipment originates. (optional) 
            var destinationCountryCode = "destinationCountryCode_example";  // string? | This indicates the Destination Country for the Shipment. The two-character ISO country code for the country where the shipment is to be delivered. (optional) 

            try
            {
                // Get Services
                List<ServicesInner> result = apiInstance.GetServices(xPBDeveloperPartnerID, carrier, originCountryCode, destinationCountryCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.GetServices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetServicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Services
    ApiResponse<List<ServicesInner>> response = apiInstance.GetServicesWithHttpInfo(xPBDeveloperPartnerID, carrier, originCountryCode, destinationCountryCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.GetServicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **carrier** | **string?** | This indicates the CarrierID, a unique identifier provided to an individual carrier. It can be referred from the response of Get Carriers API | [optional]  |
| **originCountryCode** | **string?** | This indicates the Source Country. The two-character ISO country code for the country where the Shipment originates. | [optional]  |
| **destinationCountryCode** | **string?** | This indicates the Destination Country for the Shipment. The two-character ISO country code for the country where the shipment is to be delivered. | [optional]  |

### Return type

[**List&lt;ServicesInner&gt;**](ServicesInner.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of services has been fetched. |  * X-Pb-Transactionid - The X-PB-TransactionId is unique id for this request. <br>  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getsignatureimageerr"></a>
# **GetSignatureImageERR**
> SignatureFileResponse GetSignatureImageERR (string shipmentId, string? xPBDeveloperPartnerID = null)

Signature Image ERR

This operation provides a downloadable link which consists of a signature image for specific ERR (Electronic Return Receipt) shipment, and this is known as POD. <br /> Proof of Delivery (POD) is a document or file that shows an evidence of shipment delivery. This file contains the digital copy of recipient's signature, i.e., the signature image, in the form of downloadable link or URL.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class GetSignatureImageERRExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentApi(config);
            var shipmentId = "shipmentId_example";  // string | Shipment ID is a unique identifier for an individual shipment.
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | The Developer Partner ID is assigned by PB to uniquely identify a Developer's strategic business partners. If the developer is the sole business partner, this field is not required. (optional) 

            try
            {
                // Signature Image ERR
                SignatureFileResponse result = apiInstance.GetSignatureImageERR(shipmentId, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.GetSignatureImageERR: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSignatureImageERRWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Signature Image ERR
    ApiResponse<SignatureFileResponse> response = apiInstance.GetSignatureImageERRWithHttpInfo(shipmentId, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.GetSignatureImageERRWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentId** | **string** | Shipment ID is a unique identifier for an individual shipment. |  |
| **xPBDeveloperPartnerID** | **string?** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field is not required. | [optional]  |

### Return type

[**SignatureFileResponse**](SignatureFileResponse.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Signature image as proof of delivered shipment. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getspecialservices"></a>
# **GetSpecialServices**
> SpecialServices GetSpecialServices (string? xPBDeveloperPartnerID = null, string? service = null, string? parcel = null, string? carrier = null, string? originCountryCode = null, string? destinationCountryCode = null)

Get Special Services

This operation fetches Special Services for a given carrier, service, origin country, and the destination country. If query parameters are not provided, it will default to `USPS` as carrier,`US` as both origin and destination country and would show for all service and parcel types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class GetSpecialServicesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentApi(config);
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 
            var service = "service_example";  // string? | This indicates the serviceId. It can be referred from response of `Get Services` API (optional) 
            var parcel = "parcel_example";  // string? | This indicates the parcel Id, a unique identifier named to individual package. It can be referred from response of `Get Parcel Types` API (optional) 
            var carrier = "carrier_example";  // string? | This indicates the CarrierID, a unique identifier given to  an individual carrier. It can be referred from response of `Get Carriers` API (optional) 
            var originCountryCode = "originCountryCode_example";  // string? | This indicates the Source Country. The two-character ISO country code for the country where the Shipment originates. (optional) 
            var destinationCountryCode = "destinationCountryCode_example";  // string? | This indicates the Destination Country for the Shipment. The two-character ISO country code for the country where the shipment is to be delivered. (optional) 

            try
            {
                // Get Special Services
                SpecialServices result = apiInstance.GetSpecialServices(xPBDeveloperPartnerID, service, parcel, carrier, originCountryCode, destinationCountryCode);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.GetSpecialServices: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSpecialServicesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Special Services
    ApiResponse<SpecialServices> response = apiInstance.GetSpecialServicesWithHttpInfo(xPBDeveloperPartnerID, service, parcel, carrier, originCountryCode, destinationCountryCode);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.GetSpecialServicesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **service** | **string?** | This indicates the serviceId. It can be referred from response of &#x60;Get Services&#x60; API | [optional]  |
| **parcel** | **string?** | This indicates the parcel Id, a unique identifier named to individual package. It can be referred from response of &#x60;Get Parcel Types&#x60; API | [optional]  |
| **carrier** | **string?** | This indicates the CarrierID, a unique identifier given to  an individual carrier. It can be referred from response of &#x60;Get Carriers&#x60; API | [optional]  |
| **originCountryCode** | **string?** | This indicates the Source Country. The two-character ISO country code for the country where the Shipment originates. | [optional]  |
| **destinationCountryCode** | **string?** | This indicates the Destination Country for the Shipment. The two-character ISO country code for the country where the shipment is to be delivered. | [optional]  |

### Return type

[**SpecialServices**](SpecialServices.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Special Service has been fetched successfully. |  * X-Pb-Transactionid - The X-PB-TransactionId is unique id for this request. <br>  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="reprintshipmentbyid"></a>
# **ReprintShipmentById**
> ReprintShipment ReprintShipmentById (string shipmentId, string? xPBDeveloperPartnerID = null, bool? compactResponse = null)

Reprint Shipment

This operation reprints Shipment by the shipmentId. It retrieves an existing shipping label to reprint. The API sends the shipmentId returned by the original Created Shipment request. Use this only if the shipping label in the Create Shipment response was spoilt or lost.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class ReprintShipmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentApi(config);
            var shipmentId = "shipmentId_example";  // string | This indicates the shipmentId, a unique identifier assigned to the Shipment.
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 
            var compactResponse = false;  // bool? | This header defines if the response required is detailed or compact. When value is set to true, it will only return label layout details and parcel tracking number object in response. (optional) 

            try
            {
                // Reprint Shipment
                ReprintShipment result = apiInstance.ReprintShipmentById(shipmentId, xPBDeveloperPartnerID, compactResponse);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.ReprintShipmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ReprintShipmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Reprint Shipment
    ApiResponse<ReprintShipment> response = apiInstance.ReprintShipmentByIdWithHttpInfo(shipmentId, xPBDeveloperPartnerID, compactResponse);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.ReprintShipmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentId** | **string** | This indicates the shipmentId, a unique identifier assigned to the Shipment. |  |
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |
| **compactResponse** | **bool?** | This header defines if the response required is detailed or compact. When value is set to true, it will only return label layout details and parcel tracking number object in response. | [optional]  |

### Return type

[**ReprintShipment**](ReprintShipment.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
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

<a id="shipmentbyid"></a>
# **ShipmentById**
> GetSingleShipment ShipmentById (string shipmentId, string? xPBDeveloperPartnerID = null)

Get Shipment by Id

This operation retrieves shipment details using shipmentId.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;

namespace Example
{
    public class ShipmentByIdExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api-sandbox.sendpro360.pitneybowes.com/shipping";
            // Configure Bearer token for authorization: bearerAuth
            config.AccessToken = "YOUR_BEARER_TOKEN";

            var apiInstance = new ShipmentApi(config);
            var shipmentId = "shipmentId_example";  // string | This indicates the shipmentId, a unique identifier for an individual Shipment.
            var xPBDeveloperPartnerID = "xPBDeveloperPartnerID_example";  // string? | This is the Developer Partner ID. When the developer is the only partner, this field is not required. (optional) 

            try
            {
                // Get Shipment by Id
                GetSingleShipment result = apiInstance.ShipmentById(shipmentId, xPBDeveloperPartnerID);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ShipmentApi.ShipmentById: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ShipmentByIdWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // Get Shipment by Id
    ApiResponse<GetSingleShipment> response = apiInstance.ShipmentByIdWithHttpInfo(shipmentId, xPBDeveloperPartnerID);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ShipmentApi.ShipmentByIdWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **shipmentId** | **string** | This indicates the shipmentId, a unique identifier for an individual Shipment. |  |
| **xPBDeveloperPartnerID** | **string?** | This is the Developer Partner ID. When the developer is the only partner, this field is not required. | [optional]  |

### Return type

[**GetSingleShipment**](GetSingleShipment.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The shipment has been retrieved. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

