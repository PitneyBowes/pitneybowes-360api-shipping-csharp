# com.pitneybowes.api360.Model.ShipmentERRCoversheet

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalId** | **string** | This is a user-defined value provided by users just for their reference. This is for mapping purpose against each shipment. | [optional] 
**FromAddress** | [**FromAddress**](FromAddress.md) |  | 
**ToAddress** | [**ToAddress**](ToAddress.md) |  | 
**Parcel** | [**Parcel**](Parcel.md) |  | 
**CarrierAccountId** | **string** | A unique identifier associated with the user&#39;s registered USPS account which is used by client users while shipment process. | [optional] 
**ParcelType** | **string** | &gt;-Packaging type varies as per USPS selected services, e.g., LTR, LGENV. | [optional] 
**ServiceId** | **string** | &gt;-A unique identifier given to the carrier-specific service. ERR supports two services: First Class Mail (FCM) and Priority Mail (PM). | [optional] 
**DateOfShipment** | **string** | The date when shipment gets created. | [optional] 
**SpecialServices** | [**List&lt;SpecialServiceERRInner&gt;**](SpecialServiceERRInner.md) |  | [optional] 
**ShipmentOptions** | [**ShipmentOptionsERR**](ShipmentOptionsERR.md) |  | [optional] 
**Metadata** | [**List&lt;ShipmentERRCoversheetMetadataInner&gt;**](ShipmentERRCoversheetMetadataInner.md) | Additional metadata that needs to be stored for this shipment, can be added here. For now, &#x60;costAccountName&#x60; is supported. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

