# com.pitneybowes.api360.Model.CreateBulkShipmentsERRLabel
This ShipmentBatch contains the schema information for ERR Label.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the of ERR Batch which consists of multiple shipments (shipments in bulk) for Label printing, e.g. ERR-Bulk05. | 
**GroupName** | **string** | Indicates the name of the group of batches, which consists of multiple Batch groups. | [optional] 
**Size** | **string** | This indicates the label size of the Bulk Shipment when it gets printed,i.e., DocSize. This has two options 8&#39; X 11&#39; or 4&#39; X 6&#39;. | 
**Type** | **string** | Indicates the type of the Batch Shipment, e.g., Shipping Label. | 
**Format** | **string** | Defines the type of the shipment which is printed, e.g., Shipping label gets printed in PDF form. | [optional] 
**CarrierAccountId** | **string** | A unique identifier associated with the Carrier account used by client users during shipment process. Default CarrierAccountID for this batch will be user&#39;s registered USPS account. User can override this value by defining it at Shipment level. | 
**ServiceId** | **string** | A unique identifier given to the carrier-specific service. User can override this value by defining it at Shipment level. | 
**ParcelType** | **string** | Parcel Type is required for creating a shipment while rating a parcel. And it varies as per USPS selected services, e.g. FRPKG, LGENV, TUBE, and PKG. User can override this value by defining it at Shipment level. | 
**ParcelID** | **string** | A unique identifier given to the parcel or package corresponding to the selected service. This is optional field, but is used in few cases. Examples include BLM10, B1095, MT1098, etc. User can override this value by defining it at Shipment level. | [optional] 
**SpecialServices** | [**List&lt;SpecialServiceERRInner&gt;**](SpecialServiceERRInner.md) |  | [optional] 
**Shipments** | [**List&lt;ShipmentERR&gt;**](ShipmentERR.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

