# com.pitneybowes.api360.Model.ReprintShipment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | This is a GUID (globally unique identifier) that&#39;s automatically generated for every request that the webserver receives. | [optional] 
**Size** | **string** | This defines the label size of the Shipment, e.g., Shipping Label having Doc Size (8&#39; X 11&#39;). | [optional] 
**Type** | **string** | This defines the type of the Shipment, e.g., Shipping Label. | [optional] 
**Format** | **string** | This defines the type of the shipment which is printed. For example Shipping label prints in PDF form. | [optional] 
**FromAddress** | [**ReprintShipmentFromAddress**](ReprintShipmentFromAddress.md) |  | [optional] 
**Parcel** | [**ReprintShipmentParcel**](ReprintShipmentParcel.md) |  | [optional] 
**ParcelTrackingNumber** | **string** | The Tracking number given to the Parcel for tracking purpose. | [optional] 
**Rate** | [**ReprintShipmentRate**](ReprintShipmentRate.md) |  | [optional] 
**ShipmentId** | **string** | A unique identifier associated with Shipment ID. | [optional] 
**ShipmentOptions** | [**ShipmentOptions**](ShipmentOptions.md) |  | [optional] 
**ToAddress** | [**ReprintShipmentToAddress**](ReprintShipmentToAddress.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

