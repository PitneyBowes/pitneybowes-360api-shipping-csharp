# com.pitneybowes.api360.Model.MilitaryMailShipmentsRequestV2ShipmentOptions
Shipment Options have an added feature that is Manifest.<br /> With Manifest, the Mail Center agent can print the Manifest (End of day records of all created shipment) of selected carrier.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddToManifest** | **bool** | This option asks if the shipment is to be added for Manifest, so that the shipment will reflect in the Manifest Form while compilation. Supported for CPC and USPS carriers. &lt;br /&gt; The value can be &#39;true&#39; or &#39;false&#39;. | [optional] 
**MinimalAddressValidation** | **bool** | Allows performing minimal address validation during shipment creation. the addressLine1 field is not validated if set to true. Minimal address validation is supported only for these APIs:   - Create Shipment   - Create Bulk Shipments   - Create Multipiece Shipment  | [optional] 
**ShipperID** | **string** | The unique identifier of the known shipper associated with this shipment. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

