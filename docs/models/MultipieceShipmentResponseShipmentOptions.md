# com.pitneybowes.api360.Model.MultipieceShipmentResponseShipmentOptions
Additional options associated with the shipment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrintCustomMessage** | **string** | A custom message to be printed on each parcel label of the shipment. | [optional] 
**PrintDepartment** | **string** | Department Name to be printed on each parcel label of the shipment. | [optional] 
**PrintInvoiceNumber** | **string** | Invoice number to be printed on each parcel label of the shipment. | [optional] 
**PrintPONumber** | **string** | PO number to be printed on each parcel label of the shipment. | [optional] 
**BillingWeight** | **string** | The weight used by the carrier to calculate the shipping cost. This value is determined as the greater of the actual weight and the dimensional weight.  | [optional] 
**BookingConfirmationNumber** | **string** | This is an advanced booking number required for FedEx Express Freight shipments. It must be obtained through the appropriate channel in the shipment&#39;s origin country. Without a valid booking confirmation number, pickup and space allocation for the shipment are not guaranteed. The booking number must be between 5 and 12 digits.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

