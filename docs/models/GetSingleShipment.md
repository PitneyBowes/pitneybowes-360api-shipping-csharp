# com.pitneybowes.api360.Model.GetSingleShipment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | Key assigned by the shipping system to the transaction. | [optional] 
**FromAddress** | [**GetSingleShipmentFromAddress**](GetSingleShipmentFromAddress.md) |  | [optional] 
**Parcel** | [**ReturnLabelParcel**](ReturnLabelParcel.md) |  | [optional] 
**Metadata** | [**List&lt;GetAllShipmentsDataInnerMetadataInner&gt;**](GetAllShipmentsDataInnerMetadataInner.md) | Additional metadata that needs to be stored for this shipment can be added here. For now, &#39;Cost Account Name&#39; is supported. | [optional] 
**ParcelId** | **string** | A unique identifier associated with the Parcel. | [optional] 
**ParcelTrackingNumber** | **string** | The Tracking number given to the Parcel for tracking purpose. | [optional] 
**Rate** | [**GetSingleShipmentRate**](GetSingleShipmentRate.md) |  | [optional] 
**Service** | **string** | The carrier-based service that is used for shipment. | [optional] 
**ShipmentId** | **string** | A unique identifier known shipper associated with Shipment ID. | [optional] 
**ShipmentOptions** | [**GetSingleShipmentShipmentOptions**](GetSingleShipmentShipmentOptions.md) |  | [optional] 
**Status** | **string** | The status of the Shipment. | [optional] 
**ToAddress** | [**GetSingleShipmentToAddress**](GetSingleShipmentToAddress.md) |  | [optional] 
**AltReturnAddress** | [**ShipmentInternationalAltReturnAddress**](ShipmentInternationalAltReturnAddress.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

