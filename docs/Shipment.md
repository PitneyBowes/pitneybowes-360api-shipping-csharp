# com.pitneybowes.api360.Model.Shipment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ExternalId** | **string** | The external ID of the shipment. User can provide any custom value to it for its own reference | [optional] 
**FromAddress** | [**MultipieceDomesticShipmentRequestFromAddress**](MultipieceDomesticShipmentRequestFromAddress.md) |  | 
**Parcel** | [**ShipmentDomesticParcel**](ShipmentDomesticParcel.md) |  | 
**CarrierAccountId** | **string** | A unique identifier associated with the Carrier account used by client users during shipment process. | 
**ParcelType** | **string** | &gt;-Packaging type specific to the carrier, e.g., FRPKG, LGENV, TUBE,PKG. | 
**ServiceId** | **string** | &gt;-The abbreviated name of the carrier-specific service. Required for creating a shipment. Optional for rating a parcel. | 
**DateOfShipment** | **string** | Current Shipment date | [optional] 
**SpecialServices** | [**List&lt;SpecialService&gt;**](SpecialService.md) |  | [optional] 
**ShipmentOptions** | [**ShipmentOptions**](ShipmentOptions.md) |  | [optional] 
**Metadata** | [**List&lt;ShipmentMetadataInner&gt;**](ShipmentMetadataInner.md) | Additional metadata that needs to be stored for this shipment can be added here. For now, &#x60;costAccountName&#x60; is supported. | [optional] 
**ToAddress** | [**ShipmentToAddress**](ShipmentToAddress.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

