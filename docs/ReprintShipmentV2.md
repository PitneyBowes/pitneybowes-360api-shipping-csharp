# com.pitneybowes.api360.Model.ReprintShipmentV2

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShipmentId** | **string** | The shipmentId, a unique identifier for an individual Shipment, which is used for Reprint or Cancel. | [optional] 
**ParcelTrackingNumber** | **string** | The Tracking number given to the Parcel for tracking purpose. | [optional] 
**LabelLayout** | [**List&lt;ReprintShipmentV2LabelLayoutInner&gt;**](ReprintShipmentV2LabelLayoutInner.md) | It defines the layout of the shipping label. | [optional] 
**Parcel** | [**ParcelV2**](ParcelV2.md) |  | [optional] 
**Rate** | [**RateResponseV2**](RateResponseV2.md) |  | [optional] 
**References** | [**CancelShipmentV2References**](CancelShipmentV2References.md) |  | [optional] 
**PrintStatus** | **string** | Status of the Printed Label. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

