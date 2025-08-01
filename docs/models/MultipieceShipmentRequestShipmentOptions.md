# com.pitneybowes.api360.Model.MultipieceShipmentRequestShipmentOptions
Additional options for the shipment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrintCustomMessage** | **string** | A custom message to be printed on each parcel label of the shipment. | [optional] 
**PrintDepartment** | **string** | Department Name to be printed on each parcel label of the shipment. | [optional] 
**PrintInvoiceNumber** | **string** | Invoice number to be printed on each parcel label of the shipment. | [optional] 
**PrintPONumber** | **string** | PO number to be printed on each parcel label of the shipment. | [optional] 
**MinimalAddressValidation** | **bool** | Allows performing minimal address validation during shipment creation. the addressLine1 field is not validated if set to true. Minimal address validation is supported only for these APIs:   - Create Shipment   - Create Bulk Shipments   - Create Multipiece Shipment  | [optional] 
**BookingConfirmationNumber** | **string** | This is an advanced booking number required for FedEx Express Freight shipments. It must be obtained through the appropriate channel in the shipment&#39;s origin country. Without a valid booking confirmation number, pickup and space allocation for the shipment are not guaranteed. The booking number must be between 5 and 12 digits.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

