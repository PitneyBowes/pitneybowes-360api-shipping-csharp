# com.pitneybowes.api360.Model.MultipieceShipmentRequestMultiPieceParcelsInnerParcelShipmentOptions
Parcel-level references are supported for carrier FedEx as of now. These references override shipment-level values and will be printed on the specific parcel label where provided. <br/> If only shipment-level references are provided, these references will be printed on all parcel labels.  <br/> If only parcel-level references are provided, each parcel label will be printed with its own parcel-specific references. <br/> If both shipment-level and parcel-level references are provided, the parcel-level references take precedence and will be printed on the corresponding parcel labels. <br/> If shipment-level references are provided along with parcel-level references for some parcels, parcel-level references will be printed where provided; shipment-level references will be printed for the remaining parcels. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PrintCustomMessage** | **string** | Custom message to be printed on the specific parcel label. | [optional] 
**PrintDepartment** | **string** | Department name to be printed on the specific parcel label. | [optional] 
**PrintInvoiceNumber** | **string** | Invoice number to be printed on the specific parcel label. | [optional] 
**PrintPONumber** | **string** | Purchase order number to be printed on the specific parcel label. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

