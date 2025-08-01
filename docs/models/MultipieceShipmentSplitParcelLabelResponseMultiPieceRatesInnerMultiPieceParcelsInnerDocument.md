# com.pitneybowes.api360.Model.MultipieceShipmentSplitParcelLabelResponseMultiPieceRatesInnerMultiPieceParcelsInnerDocument
Details of the shipping label for an individual parcel in a multipiece shipment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ContentType** | **string** | Specifies how the label content is encoded. If the file format is &#39;PDF&#39;, &#39;URL&#39; is used to reference the document&#39;s location. For &#39;ZPL2&#39; files, &#39;BASE64&#39; encoding is used to represent the binary data as printable text. | [optional] 
**Contents** | **string** | The URL to access the label document if the content type is &#x60;URL&#x60;, or the Base64-encoded data if the content type is &#x60;BASE64&#x60;. | [optional] 
**FileFormat** | **string** | The format of the label document file the print takes. | [optional] 
**Size** | **string** | Defines the label size of the Shipment, e.g., Shipping Label having Doc Size (4&#39; X 6&#39; or 8&#39; X 11&#39;). | [optional] 
**Type** | **string** | Type of label document, such as &#39;SHIPPING_LABEL&#39;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

