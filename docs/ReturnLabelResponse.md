# com.pitneybowes.api360.Model.ReturnLabelResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromAddress** | [**ReturnLabelFromAddress**](ReturnLabelFromAddress.md) |  | [optional] 
**Parcel** | [**ShipmentDomesticParcel**](ShipmentDomesticParcel.md) |  | [optional] 
**CorrelationId** | **string** | correction id | [optional] 
**ServiceId** | **string** | &gt;-A unique identifier given to the carrier-specific service. This is required for creating a shipment, while it is optional for rating a parcel. | [optional] 
**ParcelTrackingNumber** | **string** | &gt;-A unique identifier parcel tracking number | [optional] 
**ShipmentId** | **string** | &gt;-A unique identifier shipment tracking number | [optional] 
**ShipmentOptions** | [**ShipmentOptionsV2**](ShipmentOptionsV2.md) |  | [optional] 
**LabelLayout** | [**List&lt;ReturnLabelResponseLabelLayoutInner&gt;**](ReturnLabelResponseLabelLayoutInner.md) | labelLayout details | [optional] 
**ToAddress** | [**ReturnLabelResponseToAddress**](ReturnLabelResponseToAddress.md) |  | [optional] 
**Rate** | [**ReturnLabelResponseRate**](ReturnLabelResponseRate.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

