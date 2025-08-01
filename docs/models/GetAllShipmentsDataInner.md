# com.pitneybowes.api360.Model.GetAllShipmentsDataInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | Key assigned by the shipping system to the transaction. | [optional] 
**FromAddress** | [**GetAllShipmentsDataInnerFromAddress**](GetAllShipmentsDataInnerFromAddress.md) |  | [optional] 
**Parcel** | [**GetAllShipmentsDataInnerParcel**](GetAllShipmentsDataInnerParcel.md) |  | [optional] 
**Metadata** | [**List&lt;GetAllShipmentsDataInnerMetadataInner&gt;**](GetAllShipmentsDataInnerMetadataInner.md) | Additional metadata that needs to be stored for this shipment can be added here. For now, &#39;Cost Account Name&#39; is supported. | [optional] 
**ParcelId** | **string** | A unique identifier associated with the Parcel. | [optional] 
**ParcelTrackingNumber** | **string** | The Tracking number given to the Parcel for tracking purpose. | [optional] 
**Rate** | [**GetAllShipmentsDataInnerRate**](GetAllShipmentsDataInnerRate.md) |  | [optional] 
**Service** | **string** |  | [optional] 
**ShipmentId** | **string** | A unique identifier associated with the Shipment. | [optional] 
**ShipmentOptions** | [**GetAllShipmentsDataInnerShipmentOptions**](GetAllShipmentsDataInnerShipmentOptions.md) |  | [optional] 
**Status** | **string** |  | [optional] 
**ToAddress** | [**GetAllShipmentsDataInnerToAddress**](GetAllShipmentsDataInnerToAddress.md) |  | [optional] 
**AltReturnAddress** | [**ShipmentInternationalAltReturnAddress**](ShipmentInternationalAltReturnAddress.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

