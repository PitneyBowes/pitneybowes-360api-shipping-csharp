# com.pitneybowes.api360.Model.ShipmentDomesticByCarrierCustoms
Customs information required for international shipments. - Required only for RMG carrier in domestic shipment requests. - Must include customsItems and customsInfo objects. - Other carriers do not require this object for domestic shipments. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomsInfo** | [**ShipmentDomesticByCarrierCustomsCustomsInfo**](ShipmentDomesticByCarrierCustomsCustomsInfo.md) |  | 
**CustomsItems** | [**List&lt;ShipmentDomesticByCarrierCustomsCustomsItemsInner&gt;**](ShipmentDomesticByCarrierCustomsCustomsItemsInner.md) | Items included in the customs declaration. | 
**CustomsDocuments** | [**List&lt;ShipmentInternationalCustomsCustomsDocumentsInner&gt;**](ShipmentInternationalCustomsCustomsDocumentsInner.md) | Use this field to attach Electronic Trade Documents (ETDs) to your DHL international shipment.  Each item should represent a document uploaded previously using the [Upload ETD API](/openapi/shipping/operation/uploadETD/). - For DHL, if you pass this field, ensure the selected service type is PAPERLESS. - The &#x60;s3FileId&#x60; value must be taken from the [Upload ETD API response](/openapi/shipping/operation/uploadETD/). &gt; Electronic trade document must upload before shipment label creation.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

