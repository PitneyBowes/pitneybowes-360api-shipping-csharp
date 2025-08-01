# com.pitneybowes.api360.Model.ShipmentDomesticShipmentOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddToManifest** | **bool** | The option asks if the shipment is to be added for Manifest, so that the shipment will reflect in the Manifest Form while compilation.&lt;br /&gt; The value can be &#39;true&#39; or &#39;false&#39;. Applicable for USPS and CPC carriers. | [optional] 
**PrintCustomMessage** | **string** | It prints a custom message on shipping label. Custom messages are not supported for RMG shipments. | [optional] 
**ReceiptOption** | **string** | It provides options to print receipt with shipping label. Only applicable for USPS, and it can have the indicated possible/ enum values. | [optional] 
**PrintDepartment** | **string** | It prints the Department on Shipping Label, applicable for FedEx. | [optional] 
**PrintInvoiceNumber** | **string** | It prints Invoice Number on Shipping Label, applicable for FedEx. | [optional] 
**PrintPONumber** | **string** | It prints Product Order number on Shipping Label, applicable for FedEx. | [optional] 
**ShipperId** | **string** | The unique identifier of the known shipper. | [optional] 
**MinimalAddressValidation** | **bool** | Allows performing minimal address validation during shipment creation. the addressLine1 field is not validated if set to true. Minimal address validation is supported only for these APIs:    - Create Shipment    - Create Bulk Shipments    - Create Multipiece Shipment  | [optional] 
**BookingConfirmationNumber** | **string** | This is an advanced booking number required for FedEx Express Freight shipments. It must be obtained through the appropriate channel in the shipment&#39;s origin country. Without a valid booking confirmation number, pickup and space allocation for the shipment are not guaranteed. The booking number must be between 5 and 12 digits.  | [optional] 
**B2b** | **bool** | Required only for **RMG carrier**. Must be set to &#x60;true&#x60; to indicate a business-to-business (B2B) shipment.  | [optional] 
**SenderEORI** | **string** | Sender&#39;s Economic Operators Registration and Identification number. EORI is a unique identification number used for customs clearance in the European Union. This Number can be 14 characters long in Alphanumeric format. **Required for RMG B2B shipments**.  | [optional] 
**RecipientEORI** | **string** | Recipient&#39;s EORI number. ORI is a unique identification number used for customs clearance in the European Union. This Number can be 14 characters long in Alphanumeric format. **Required for RMG B2B shipments**.  | [optional] 
**SenderUKIMSNumber** | **string** | UKIMS (UK Internal Market Scheme) is an authorization that allows businesses to move goods between Great Britain (GB) and Northern Ireland (NI) without paying EU (European) duty. UKIMS Number can be 32 characters long in Alphanumeric format. Required if the package value value is over £135.   | [optional] 
**ExportLicenceRequired** | **bool** | Specifies whether the shipment includes goods that require an official export license. - applies to both RMG B2B and B2C shipments - Required as part of customs compliance under the Windsor Agreement  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

