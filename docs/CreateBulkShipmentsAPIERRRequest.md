# com.pitneybowes.api360.Model.CreateBulkShipmentsAPIERRRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the of ERR Batch which consists of multiple shipments (shipments in bulk) for Coversheet printing., e.g. ERR-Coversheet07. | 
**GroupName** | **string** | Indicates the name of the group of batches, which consists of multiple Batch groups. | [optional] 
**Size** | **string** | This indicates the envelope size of the ERR Bulk Shipment, i.e., DocSize. We have indicated the example values in enum. | 
**Type** | **string** | Indicates the type of the Batch Shipment, e.g., Shipping Label. | 
**Format** | **string** | This defines the format type of the shipment which is printed. For example Coversheet prints in PDF form. | [optional] 
**CarrierAccountId** | **string** | The unique identifier associated with the user&#39;s registered USPS Account which will be required for this batch. User can override this value by defining it at Shipment level. | 
**ServiceId** | **string** | A unique identifier given  to the carrier-specific service which is used for this BulkShipment. User can override this value by defining it at shipment level. | 
**ParcelType** | **string** | Parcel Type is required for creating a shipment while rating a parcel. And it varies as per USPS selected services, e.g. LTR, LGENV. User can override this value by defining it at shipment level. | 
**ParcelID** | **string** | A unique identifier given to the parcel or package corresponding to the selected service. This is optional field, but is used in few cases. Examples include BLM10, B1095, MT1098, etc. User can override this value by defining it at Shipment level. | [optional] 
**SpecialServices** | [**List&lt;SpecialServiceERRInner&gt;**](SpecialServiceERRInner.md) |  | [optional] 
**Shipments** | [**List&lt;ShipmentERRCoversheet&gt;**](ShipmentERRCoversheet.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

