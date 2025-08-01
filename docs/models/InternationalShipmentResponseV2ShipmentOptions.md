# com.pitneybowes.api360.Model.InternationalShipmentResponseV2ShipmentOptions
Options for the shipment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddToManifest** | **bool** | The option asks if the shipment is to be added for Manifest, so that the shipment will reflect in the Manifest Form while compilation.&lt;br /&gt; The value can be &#39;true&#39; or &#39;false&#39;. Applicable for USPS and CPC carriers. | [optional] 
**BillingWeight** | **string** | The weight used by the carrier to calculate the shipping cost. This value is determined as the greater of the actual weight and the dimensional weight.  | [optional] 
**BookingConfirmationNumber** | **string** | This is an advanced booking number required for FedEx Express Freight shipments. It must be obtained through the appropriate channel in the shipment&#39;s origin country. Without a valid booking confirmation number, pickup and space allocation for the shipment are not guaranteed. The booking number must be between 5 and 12 digits.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

