# com.pitneybowes.api360.Api.PrintApi

All URIs are relative to *https://api-dev.sendpro360.pitneycloud.com/shipping*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeletePrinterMapping**](PrintApi.md#deleteprintermapping) | **DELETE** /api/v1/printer/mapping | Delete Printer mapping |
| [**GetPrinterMapping**](PrintApi.md#getprintermapping) | **GET** /api/v1/printer/mapping | Get Printer mapping |
| [**JobStatus**](PrintApi.md#jobstatus) | **GET** /api/v1/jobs/{jobId} | Job status |
| [**PrintDocument**](PrintApi.md#printdocument) | **POST** /api/v1/document/print | Print Document |
| [**PrinterMapping**](PrintApi.md#printermapping) | **POST** /api/v1/printer/mapping | Printer mapping |

<a id="deleteprintermapping"></a>
# **DeletePrinterMapping**
> void DeletePrinterMapping (string alias, string xPBDeveloperPartnerId = null, string xPBLocationId = null, string xPBTransactionId = null)

Delete Printer mapping

delete printer mapping document


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alias** | **string** | Refers to a printer connected (directly or via network) to a computer. |  |
| **xPBDeveloperPartnerId** | **string** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **xPBLocationId** | **string** | This is the Location ID assigned as per the Developer&#39;s and Partner&#39;s parsed locations, to which all transactions will be billed. &lt;br /&gt; Partner&#39;s location will be used for billing if it is configured, however, in case Partner&#39;s location is not given, then the Developer&#39;s location will be taken. Developer&#39;s location will be the default value. &lt;br /&gt; Additionally, Developers and Partners can use carriers belong to this location only. | [optional]  |
| **xPBTransactionId** | **string** | A unique transaction Id provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="getprintermapping"></a>
# **GetPrinterMapping**
> PrinterMappingGetResponse GetPrinterMapping (string alias, string xPBDeveloperPartnerId = null, string xPBLocationId = null, string xPBTransactionId = null)

Get Printer mapping

Get printer mapping document


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **alias** | **string** | Refers to a printer connected (directly or via network) to a computer. |  |
| **xPBDeveloperPartnerId** | **string** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **xPBLocationId** | **string** | This is the Location ID assigned as per the Developer&#39;s and Partner&#39;s parsed locations, to which all transactions will be billed. &lt;br /&gt; Partner&#39;s location will be used for billing if it is configured, however, in case Partner&#39;s location is not given, then the Developer&#39;s location will be taken. Developer&#39;s location will be the default value. &lt;br /&gt; Additionally, Developers and Partners can use carriers belong to this location only. | [optional]  |
| **xPBTransactionId** | **string** | A unique transaction Id provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="jobstatus"></a>
# **JobStatus**
> JobStatus JobStatus (string jobId, string xPBDeveloperPartnerId = null, string xPBLocationId = null, string xPBTransactionId = null)

Job status

job status


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **jobId** | **string** | The jobId, a unique identifier assigned for the job. |  |
| **xPBDeveloperPartnerId** | **string** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **xPBLocationId** | **string** | This is the Location ID assigned as per the Developer&#39;s and Partner&#39;s parsed locations, to which all transactions will be billed. &lt;br /&gt; Partner&#39;s location will be used for billing if it is configured, however, in case Partner&#39;s location is not given, then the Developer&#39;s location will be taken. Developer&#39;s location will be the default value. &lt;br /&gt; Additionally, Developers and Partners can use carriers belong to this location only. | [optional]  |
| **xPBTransactionId** | **string** | A unique transaction Id provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. | [optional]  |

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
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="printdocument"></a>
# **PrintDocument**
> PrintDocumentResponse PrintDocument (PrintDocumentRequest printDocumentRequest, string xPBDeveloperPartnerId = null, string xPBLocationId = null, string xPBTransactionId = null)

Print Document

It contains information about a label or a document, e.g., a shipping label, a customs form, manifest report etc., that pertains to a shipment or manifest.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **printDocumentRequest** | [**PrintDocumentRequest**](PrintDocumentRequest.md) |  |  |
| **xPBDeveloperPartnerId** | **string** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **xPBLocationId** | **string** | This is the Location ID assigned as per the Developer&#39;s and Partner&#39;s parsed locations, to which all transactions will be billed. &lt;br /&gt; Partner&#39;s location will be used for billing if it is configured, however, in case Partner&#39;s location is not given, then the Developer&#39;s location will be taken. Developer&#39;s location will be the default value. &lt;br /&gt; Additionally, Developers and Partners can use carriers belong to this location only. | [optional]  |
| **xPBTransactionId** | **string** | A unique Transaction ID provided by the partner, which is used to enable debugging and linking between the client&#39;s transaction and the system. | [optional]  |

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
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="printermapping"></a>
# **PrinterMapping**
> PrinterMappingResponse PrinterMapping (PrinterMappingRequest printerMappingRequest, string xPBDeveloperPartnerId = null, string xPBLocationId = null, string xPBTransactionId = null)

Printer mapping

printer mapping document


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **printerMappingRequest** | [**PrinterMappingRequest**](PrinterMappingRequest.md) |  |  |
| **xPBDeveloperPartnerId** | **string** | The Developer Partner ID is assigned by PB to uniquely identify a Developer&#39;s strategic business partners. If the developer is the sole business partner, this field isn&#39;t required. | [optional]  |
| **xPBLocationId** | **string** | This is the Location ID assigned as per the Developer&#39;s and Partner&#39;s parsed locations, to which all transactions will be billed. &lt;br /&gt; Partner&#39;s location will be used for billing if it is configured, however, in case Partner&#39;s location is not given, then the Developer&#39;s location will be taken. Developer&#39;s location will be the default value. &lt;br /&gt; Additionally, Developers and Partners can use carriers belong to this location only. | [optional]  |
| **xPBTransactionId** | **string** | A unique transaction Id provided by the partner which is used to enable debugging and linking between the client&#39;s transaction and the system. | [optional]  |

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

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

