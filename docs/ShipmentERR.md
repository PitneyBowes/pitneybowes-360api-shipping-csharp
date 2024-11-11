# com.pitneybowes.api360.Model.ShipmentERR

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalId** | **string** | This is a user-defined value provided by users just for their reference. This is for mapping purpose against each shipment. | [optional] 
**FromAddress** | [**FromAddress**](FromAddress.md) |  | 
**ToAddress** | [**ToAddress**](ToAddress.md) |  | 
**Parcel** | [**Parcel**](Parcel.md) |  | 
**CarrierAccountId** | **string** | A unique identifier associated with the Carrier account used by client users during shipment process. | [optional] 
**ParcelType** | **string** | &gt;-Packaging type varies as per selected carrier and its services, e.g., PKG, LGENV. | [optional] 
**ServiceId** | **string** | &gt;-The unique identifier given to the carrier-specific service. ERR supports two services: First Class Mail (FCM) and Priority Mail (PM). | [optional] 
**DateOfShipment** | **string** | Indicates the date when shipment is created. | [optional] 
**SpecialServices** | [**List&lt;SpecialServiceERRInner&gt;**](SpecialServiceERRInner.md) |  | [optional] 
**ShipmentOptions** | [**ShipmentOptionsERR**](ShipmentOptionsERR.md) |  | [optional] 
**Metadata** | [**List&lt;ShipmentERRMetadataInner&gt;**](ShipmentERRMetadataInner.md) | Additional metadata that needs to be stored for this shipment can be added here. For now, &#x60;costAccountName&#x60; is supported. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

