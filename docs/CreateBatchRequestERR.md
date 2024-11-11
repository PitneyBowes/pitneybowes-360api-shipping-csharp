# com.pitneybowes.api360.Model.CreateBatchRequestERR

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the of ERR Batch which is imported, e.g. ERR-Import-05. | [optional] 
**GroupName** | **string** | Indicates the name of the group of batches, which consists of multiple Batch groups. | [optional] 
**Size** | **string** | This indicates the label size of the Bulk Shipment when it gets printed,i.e., DocSize. | 
**Type** | **string** | This indicates the type of the Batch Shipment, e.g., Shipping Label and Coversheet. | 
**Format** | **string** | This defines the type of the shipment which is printed, e.g., Shipping label gets printed in PDF form. | [optional] 
**CarrierAccountId** | **string** | A unique identifier associated with the carrier account used by client users during shipment process. Default CarrierAccountID for this batch will be user&#39;s registered USPS account. | 
**ServiceId** | **string** | A unique identifier given to the carrier-specific service. User can override this value by defining it at Shipment level. | 
**ParcelType** | **string** | Parcel Type is required for creating a shipment while rating a parcel. And it varies as per USPS selected services, e.g. FRPKG, LGENV, TUBE, and PKG. | 
**SpecialServices** | [**List&lt;SpecialServiceBatchERR&gt;**](SpecialServiceBatchERR.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

