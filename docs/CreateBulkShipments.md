# com.pitneybowes.api360.Model.CreateBulkShipments
ShipmentBatch information contains following schema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupName** | **string** |  | [optional] 
**Size** | **string** | This indicates the label size of the Bulk Shipment, e.g., DocSize can be 8&#39; X 11&#39; or 4&#39; X 6&#39;. | 
**Type** | **string** | This indicates the type of the Batch Shipment, e.g., Shipping Label. | 
**Format** | **string** | This defines the type of the shipment which is printed, e.g., Shipping label gets printed in PDF form. | [optional] 
**Name** | **string** |  | 
**CarrierAccountId** | **string** | A unique identifier associated with the Carrier account used by client users during shipment process. Default CarrierAccountID for this batch will be user&#39;s registered carrier account. User can override this value by defining it at shipment level. | 
**ParcelType** | **string** | Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection. Different carriers have different ParcelTypes, e.g., FRPKG, LGENV, TUBE, and PKG. User can override this value by defining it at Shipment level. | 
**ServiceId** | **string** | A unique identifier given to the carrier-specific service. It varies with carrier selection. This is required for creating a shipment, while it is optional for rating a parcel. User can override this value by defining it at Shipment level. | 
**SpecialServices** | [**List&lt;SpecialService&gt;**](SpecialService.md) | It provides a carrier-service based special or extra service, which also varies based on services and parcel types. User can override this value by defining it at shipment level. | [optional] 
**Shipments** | [**List&lt;Shipment&gt;**](Shipment.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

