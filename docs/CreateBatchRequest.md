# com.pitneybowes.api360.Model.CreateBatchRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the Batch which consists of multiple shipments (shipments in bulk). | [optional] 
**GroupName** | **string** | Indicates the name of the group of batches, which consists of multiple Batch groups. | [optional] 
**Size** | **string** | This indicates the label size of the Bulk Shipment, e.g., DocSize can be 8&#39; X 11&#39; or 4&#39; X 6&#39;. | 
**Type** | **string** | This indicates the type of the Batch Shipment, e.g., Shipping Label. | 
**Format** | **string** | This defines the type of the shipment which is printed, e.g., Shipping label gets printed in PDF form. | [optional] 
**CarrierAccountId** | **string** | A unique identifier associated with the carrier account used by client users during shipment process. | 
**ServiceId** | **string** | A unique identifier given to the carrier-specific service. This varies as per carrier selection. | 
**ParcelType** | **string** | Parcel Type is required for creating a shipment while rating a parcel. And it varies as per USPS selected services, e.g. FRPKG, LGENV, TUBE, and PKG. | 
**SpecialServices** | [**List&lt;SpecialServiceBatch&gt;**](SpecialServiceBatch.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

