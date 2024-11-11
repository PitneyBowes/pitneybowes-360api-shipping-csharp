# com.pitneybowes.api360.Model.ShipmentInternational

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromAddress** | [**ShipmentInternationalFromAddress**](ShipmentInternationalFromAddress.md) |  | 
**Parcel** | [**ShipmentInternationalParcel**](ShipmentInternationalParcel.md) |  | 
**CarrierAccountId** | **string** | A unique identifier associated with the Carrier account used by client users during shipment process. | 
**ParcelType** | **string** | &gt;-Packaging type specific to the carrier, e.g., FRPKG, LGENV, TUBE,PKG. | 
**ServiceId** | **string** | &gt;-The abbreviated name of the carrier-specific service. Required for creating a shipment. Optional for rating a parcel. | 
**DateOfShipment** | **string** | The date of the shipment. The format must be YYY:MM:DD. | [optional] 
**SpecialServices** | [**List&lt;SpecialService&gt;**](SpecialService.md) |  | [optional] 
**ShipmentOptions** | [**ShipmentOptions**](ShipmentOptions.md) |  | [optional] 
**Metadata** | [**List&lt;ShipmentInternationalMetadataInner&gt;**](ShipmentInternationalMetadataInner.md) | Additional metadata that needs to be stored for this shipment can be added here. For now, &#x60;costAccountName&#x60; is supported. | [optional] 
**ToAddress** | [**ShipmentInternationalToAddress**](ShipmentInternationalToAddress.md) |  | 
**Customs** | [**ShipmentInternationalCustoms**](ShipmentInternationalCustoms.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

