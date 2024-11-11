# com.pitneybowes.api360.Model.ShipmentOptionsV2

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddToManifest** | **bool** | This option asks if the shipment is to be added for Manifest, so that the shipment will reflect in the Manifest Form while compilation. The value can be &#39;true&#39; or &#39;false&#39;. Applicable for USPS | [optional] 
**PrintCustomMessage** | **string** | This prints a custom message on shipping label | [optional] 
**ReceiptOption** | **string** | It provides options to print receipt with shipping label. Only applicable for USPS, can take values- RECEIPT_ONLY or RECEIPT_WITH_INSTRUCTIONS or NO_OPTIONS | [optional] 
**PrintDepartment** | **string** | This prints department on shipping label, applicable for FedEx | [optional] 
**PrintInvoiceNumber** | **string** | This prints invoice number on shipping label, applicable for FedEx | [optional] 
**PrintPONumber** | **string** | This prints po number on shipping label, applicable for FedEx | [optional] 
**MinimalAddressValidation** | **bool** | If true, then only City, State, and PostalCode (zip) are validated. This option is specific for US domestic addresses only. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

