# com.pitneybowes.api360.Api.ElectronicTradeDocumentApi

All URIs are relative to *https://api-dev.sendpro360.pitneycloud.com/shipping*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**UploadETD**](ElectronicTradeDocumentApi.md#uploadetd) | **POST** /api/v1/importUrl | Upload Electronic Trade Document |

<a id="uploadetd"></a>
# **UploadETD**
> UploadETD200Response UploadETD (UploadETDRequest uploadETDRequest)

Upload Electronic Trade Document

Electronic Trade Documents Upload API is an international shipping document upload solution that simplifies global shipping needs and allows you to electronically upload customs documentation required for international shipments.  You can submit most of your trade documents electronically relieving yourself from printing or attaching trade documents with the shipment. <br/> This API simplifies and accelerates customs clearance by replacing physical paperwork with electronic documentation.<br/> The customs and other agencies receive electronically sent documents faster than paper copies attached with your shipment. The customs clearance process is also optimized as capturing and sharing of critical trade information is done at earlier stages of shipping.  > Note: - FedEx supports ETD with the special service `ELECTRONIC_TRADE_DOCUMENTS`. - DHL Express supports ETD with the special service `PAPERLESS`. - In certain scenarios, the originals of specific international documents still need to be attached to the package.  - For smooth customs clearance and to avoid delays, ensure that the documents are visually clear and not distorted in any way.  **How the Workflow Operates**<br/>  **Step 1: Submit Electronic Trade Document Metadata**<br/>  Initiate the process by making a POST request to the ETD Upload API with the document metadata (e.g., file name, document type, and content type).<br/> In response, the system returns:<br/> - A pre-signed S3 upload URL (url)<br/> - A fileName<br/> - A relative `s3FileId` used to reference the uploaded document later<br/>  **Step 2: Upload the Document File**<br/>  After receiving the response, you must perform a separate HTTP PUT request to the provided [url](https://docs.shipping360.pitneybowes.com/openapi/shipping/operation/uploadETD/#!c=200&path=url&t=response).<br/>  - This request must upload the binary content of the file (e.g., PDF or image)<br/>  - Upload the same file whose metadata was submitted in step-1 <br/>  **Step 3: Reference the Document in Shipment Creation**<br/>  Once the ETD uploaded successfully, the document is stored in the S3 bucket.<br/>  - Once uploaded, the document is stored in the S3 bucket and can later be referenced via the `s3FileId` in [Create International Shipment API](https://docs.shipping360.pitneybowes.com/openapi/shipping/operation/createShipment/#!path=1/customs/customsDocuments&t=request)  under `customsDocuments` object. 


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **uploadETDRequest** | [**UploadETDRequest**](UploadETDRequest.md) |  |  |

### Return type

[**UploadETD200Response**](UploadETD200Response.md)

### Authorization

[bearerAuth](../README.md#bearerAuth)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The pre-signed S3 upload url is generated successfully. |  -  |
| **400** | Invalid request. |  -  |
| **401** | The request could not be authorized. |  -  |
| **404** | The requested resource was not found. |  -  |
| **500** | The request could not be completed due to an internal error. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

