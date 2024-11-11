# com.pitneybowes.api360.Model.PrintDocumentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrinterAliasName** | **string** | Name of the Printer connected (directly or via network) to a Computer. &#x60;Max length &#x3D; 30&#x60; | 
**Data** | **string** | Content/Identifier of document e.g. DOCUMENT_REFERECE_ID. Actual document name e.g. abc.pdf. [IN] i.e base64 string, URL, file path | 
**DataType** | **string** | Data Type of the document e.g. DOCUMENT_REFERENCE. [IN/OUT] | 
**DocumentType** | **string** | The format of the document file the print takes. | 
**FormName** | **string** | The name of the Document Form. | 
**Orientation** | **string** | The orientation of the document layout: Portrait or Landscape. | [optional] 
**Reference** | [**PrintDocumentRequestReference**](PrintDocumentRequestReference.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

