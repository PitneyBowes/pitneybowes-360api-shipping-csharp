# com.pitneybowes.api360.Model.DomesticShipmentResponseV2

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | Key assigned by the shipping system to the transaction. | [optional] 
**ShipmentId** | **string** | The shipmentId, a unique identifier for an individual Shipment. | [optional] 
**ParcelTrackingNumber** | **string** | The Tracking number given to the Parcel for tracking purpose. | [optional] 
**LabelLayout** | [**List&lt;DomesticShipmentResponseV2LabelLayoutInner&gt;**](DomesticShipmentResponseV2LabelLayoutInner.md) | It defines the layout of the shipping label. | [optional] 
**Parcel** | [**ParcelV2**](ParcelV2.md) |  | [optional] 
**Rate** | [**RateResponseV2**](RateResponseV2.md) |  | [optional] 
**References** | [**ReferenceV2**](ReferenceV2.md) |  | [optional] 
**PrintStatus** | **string** | Status of the Printed Label. | [optional] 
**PrintError** | [**DomesticShipmentResponseV2PrintError**](DomesticShipmentResponseV2PrintError.md) |  | [optional] 
**FromAddress** | [**FromAddressV2Response**](FromAddressV2Response.md) |  | [optional] 
**ToAddress** | [**ToAddressV2Response**](ToAddressV2Response.md) |  | [optional] 
**ShipmentOptions** | [**ShipmentOptions**](ShipmentOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

