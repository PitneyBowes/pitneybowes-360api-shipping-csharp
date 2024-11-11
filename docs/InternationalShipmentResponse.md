# com.pitneybowes.api360.Model.InternationalShipmentResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | This is a GUID (globally unique identifier) that&#39;s automatically generated for every request that the webserver receives. | [optional] 
**LabelLayout** | [**List&lt;DomesticShipmentResponseLabelLayoutInner&gt;**](DomesticShipmentResponseLabelLayoutInner.md) | This indicates the label layout and generated label details | [optional] 
**FromAddress** | [**ReprintShipmentFromAddress**](ReprintShipmentFromAddress.md) |  | [optional] 
**Parcel** | [**ShipmentDomesticParcel**](ShipmentDomesticParcel.md) |  | [optional] 
**ParcelId** | **string** | &gt;-Parcel Id is optional and would be visible in case when is present in the request. | [optional] 
**ParcelTrackingNumber** | **string** | The Tracking number given to the Parcel for tracking purpose. | [optional] 
**Rate** | [**InternationalShipmentResponseRate**](InternationalShipmentResponseRate.md) |  | [optional] 
**ShipmentId** | **string** | A unique identifier associated with the Shipment. | [optional] 
**ShipmentOptions** | [**ShipmentOptions**](ShipmentOptions.md) |  | [optional] 
**ToAddress** | [**ReprintShipmentToAddress**](ReprintShipmentToAddress.md) |  | [optional] 
**Customs** | [**InternationalShipmentResponseCustoms**](InternationalShipmentResponseCustoms.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

