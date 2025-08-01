# com.pitneybowes.api360.Model.ShipmentDomesticByCarrierShipmentOptions
Shipment Options have an added feature that is Manifest.<br /> With Manifest, the Mail Center agent can print the Manifest (End of day records of all created shipment) of selected carrier.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddToManifest** | **bool** | This option asks if the shipment is to be added for Manifest, so that the shipment will reflect in the Manifest Form while compilation. Supported for CPC and USPS carriers. &lt;br /&gt; The value can be &#39;true&#39; or &#39;false&#39;. | [optional] 
**MinimalAddressValidation** | **bool** | Allows performing minimal address validation during shipment creation. the addressLine1 field is not validated if set to true. Minimal address validation is supported only for these APIs:   - Create Shipment   - Create Bulk Shipments   - Create Multipiece Shipment  | [optional] 
**BookingConfirmationNumber** | **string** | This field specifies the booking confirmation number for Freight International services. | [optional] 
**B2b** | **bool** | Required only for RMG carrier. Must be set to true to indicate a business-to-business (B2B) shipment. | [optional] 
**SenderEORI** | **string** | Sender&#39;s Economic Operators Registration and Identification number. EORI is a unique identification number used for customs clearance in the European Union. This Number can be 14 characters long in Alphanumeric format. **Required for RMG B2B shipments**. | [optional] 
**RecipientEORI** | **string** | Recipient&#39;s EORI number. ORI is a unique identification number used for customs clearance in the European Union. This Number can be 14 characters long in Alphanumeric format. **Required for RMG B2B shipments**. | [optional] 
**SenderUKIMSNumber** | **string** | UKIMS (UK Internal Market Scheme) is an authorization that allows businesses to move goods between Great Britain (GB) and Northern Ireland (NI) without paying EU (European) duty. UKIMS Number can be 32 characters long in Alphanumeric format. Required if the package value value is over £135. | [optional] 
**ExportLicenceRequired** | **bool** | Specifies whether the shipment includes goods that require an official export license. - applies to both RMG B2B and B2C shipments - Required as part of customs compliance under the Windsor Agreement  | [optional] 
**ShipperID** | **string** | The unique identifier of the known shipper associated with this shipment. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

