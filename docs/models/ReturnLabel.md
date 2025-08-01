# com.pitneybowes.api360.Model.ReturnLabel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Size** | **string** | Defines the label size of the Shipment, e.g., Shipping Label having Doc Size (8&#39; X 11&#39;). | [optional] 
**Type** | **string** | Defines the type of the Shipment, e.g., Shipping Label. | [optional] 
**FromAddress** | [**ReturnLabelFromAddress**](ReturnLabelFromAddress.md) |  | [optional] 
**Parcel** | [**ReturnLabelParcel**](ReturnLabelParcel.md) |  | [optional] 
**CarrierAccountId** | **string** | The unique identifier associated with the Carrier account used by client users during shipment process. | [optional] 
**ParcelType** | **string** | &gt;-Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection. It has categories like Package, Envelopes, Paks, Boxes, Tube, defined per specific carrier and used in abbreviated form, e.g., FRPKG, LGENV, TUBE, PKG. | [optional] 
**ParcelId** | **string** | A unique identifier associated with the Parcel. | [optional] 
**ServiceId** | **string** | &gt;-A unique identifier given to the carrier-specific service. This is required for creating a shipment, while it is optional for rating a parcel. | [optional] 
**SpecialServices** | [**List&lt;ReturnLabelSpecialServicesInner&gt;**](ReturnLabelSpecialServicesInner.md) |  | [optional] 
**ShipmentOptions** | [**ShipmentOptions**](ShipmentOptions.md) |  | [optional] 
**Metadata** | [**List&lt;ShipmentDomesticMetadataInner&gt;**](ShipmentDomesticMetadataInner.md) | Additional metadata that needs to be stored for this shipment can be added here. For now, &#39;Cost Account Name&#39; is supported. | [optional] 
**ToAddress** | [**ReturnLabelToAddress**](ReturnLabelToAddress.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

