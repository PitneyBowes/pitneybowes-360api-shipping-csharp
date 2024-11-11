# com.pitneybowes.api360.Model.ReprintShipmentV2LabelLayoutInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContentType** | **string** | This is used to encode binary data as printable text.&lt;br /&gt; ContentType of the document is URL if the fileformat is PDF, while it will be BASE64 if the fileFormat is ZPL2. | [optional] 
**Contents** | **string** | Content/Identifier of document e.g. DOCUMENT_REFERECE_ID.&lt;br /&gt; Actual document name e.g. abc.pdf. [IN]. | [optional] 
**FileFormat** | **string** | Defines the format of the document file the print takes. | [optional] 
**Size** | **string** | Defines the label size of the Shipment, that is, the Shipping Label is available in different Doc Size. | [optional] 
**Type** | **string** | Defines the type of the Shipment. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

