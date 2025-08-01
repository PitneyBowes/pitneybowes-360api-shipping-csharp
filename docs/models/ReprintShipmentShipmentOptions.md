# com.pitneybowes.api360.Model.ReprintShipmentShipmentOptions

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
**BillingWeight** | **string** | The weight used by the carrier to calculate the shipping cost. This value is determined as the greater of the actual weight and the dimensional weight.  | [optional] 
**BookingConfirmationNumber** | **string** | This is an advanced booking number required for FedEx Express Freight shipments. It must be obtained through the appropriate channel in the shipment&#39;s origin country. Without a valid booking confirmation number, pickup and space allocation for the shipment are not guaranteed. The booking number must be between 5 and 12 digits.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

