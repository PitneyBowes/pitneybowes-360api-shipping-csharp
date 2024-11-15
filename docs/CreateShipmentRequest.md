# com.pitneybowes.api360.Model.CreateShipmentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Size** | **string** | This defines the label size of the Shipment, e.g., Shipping Label having Doc Size (8&#39; X 11&#39;). | 
**Type** | **string** | This defines the type of the Shipment, e.g., Shipping Label. | 
**Format** | **string** | This defines the type of the shipment which is printed. For example Shipping label prints in PDF form. | [optional] 
**DateOfShipment** | **string** | This defines the date of the Shipment in the format YYYY:MM:DD. | [optional] 
**FromAddress** | [**ShipmentInternationalFromAddress**](ShipmentInternationalFromAddress.md) |  | 
**Parcel** | [**ShipmentDomesticParcel**](ShipmentDomesticParcel.md) |  | 
**CarrierAccountId** | **string** | The unique identifier associated with the Carrier account used by client users during shipment process. | 
**ParcelType** | **string** | &gt;-Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection. It has categories like Package, Envelopes, Paks, Boxes, Tube, defined per specific carrier and used in abbreviated form, e.g., FRPKG, LGENV, TUBE,PKG. | 
**ParcelId** | **string** | &gt;-Parcel Id is optional and required to be given in case of branded parcels which have brandedDimension and/or brandedWeight. If parcel has brandedDimension, in that case user need not to pass dimensionUnit and dimension details(length, width and height) in the parcel object. And if brandedWeight is also available for the parcel then in that case weightUnit and weight need not to be passed  in parcel object | [optional] 
**ServiceId** | **string** | &gt;-A unique identifier given to the carrier-specific service. This is required for creating a shipment, while it is optional for rating a parcel. | 
**SpecialServices** | [**List&lt;SpecialService&gt;**](SpecialService.md) | This provides a carrier-service based special or extra sevice. | [optional] 
**ShipmentOptions** | [**ShipmentOptions**](ShipmentOptions.md) |  | [optional] 
**Metadata** | [**List&lt;ShipmentInternationalMetadataInner&gt;**](ShipmentInternationalMetadataInner.md) | Additional metadata that needs to be stored for this shipment can be added here. For now, &#x60;costAccountName&#x60; is supported. | [optional] 
**ToAddress** | [**ShipmentInternationalToAddress**](ShipmentInternationalToAddress.md) |  | 
**Customs** | [**ShipmentInternationalCustoms**](ShipmentInternationalCustoms.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

