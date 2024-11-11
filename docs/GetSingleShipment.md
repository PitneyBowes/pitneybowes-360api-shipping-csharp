# com.pitneybowes.api360.Model.GetSingleShipment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | This is a GUID (globally unique identifier) that&#39;s automatically generated for every request that the webserver receives. | [optional] 
**FromAddress** | [**GetSingleShipmentFromAddress**](GetSingleShipmentFromAddress.md) |  | [optional] 
**Parcel** | [**ShipmentDomesticParcel**](ShipmentDomesticParcel.md) |  | [optional] 
**Metadata** | [**List&lt;GetAllShipmentsDataInnerMetadataInner&gt;**](GetAllShipmentsDataInnerMetadataInner.md) | Additional metadata that needs to be stored for this shipment can be added here. For now, &#x60;costAccountName&#x60; is supported. | [optional] 
**ParcelTrackingNumber** | **string** | The Tracking number given to the Parcel for tracking purpose. | [optional] 
**Rate** | [**GetSingleShipmentRate**](GetSingleShipmentRate.md) |  | [optional] 
**Service** | **string** | This indicates the carrier based service that is used for shipment. | [optional] 
**ShipmentId** | **string** | A unique identifier associated with Shipment ID. | [optional] 
**Status** | **string** | The status of the Shipment. | [optional] 
**ToAddress** | [**GetSingleShipmentToAddress**](GetSingleShipmentToAddress.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

