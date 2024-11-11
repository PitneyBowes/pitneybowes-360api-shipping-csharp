# com.pitneybowes.api360.Model.GetShipmentsForBatchDataInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchId** | **string** | This is a system-generated unique identifier assigned to the Batch while it is processed. | [optional] 
**CarrierAccountId** | **string** | A unique identifier associated with the Carrier account used by client users during shipment process. | [optional] 
**ExternalId** | **string** | This is a user-defined value provided by users just for their reference. This is for mapping purpose against each shipment. | [optional] 
**FromAddress** | [**FromAddress**](FromAddress.md) |  | [optional] 
**LabelLayout** | [**GetShipmentsForBatchDataInnerLabelLayout**](GetShipmentsForBatchDataInnerLabelLayout.md) |  | [optional] 
**Metadata** | [**List&lt;GetShipmentsForBatchDataInnerMetadataInner&gt;**](GetShipmentsForBatchDataInnerMetadataInner.md) | Additional metadata that needs to be stored for this shipment can be added here. For now, &#x60;costAccountName&#x60; is supported. | [optional] 
**Parcel** | [**Parcel**](Parcel.md) |  | [optional] 
**ParcelType** | **string** | Parcel Type is required for creating a shipment while rating a parcel. And it varies as per carrier selection and corresponding services. | [optional] 
**ServiceId** | **string** | A unique identifier given to the carrier-specific service. User can override this value by defining it at Shipment level. | [optional] 
**ShipmentId** | **string** | Shipment ID is a unique identifier for an individual shipment | [optional] 
**ShipmentIdentifier** | **string** | Unique identifier generated for each shipment, it can be either success or failed. | [optional] 
**ShipmentOptions** | [**ShipmentOptions**](ShipmentOptions.md) |  | [optional] 
**SpecialServices** | [**List&lt;GetShipmentsForBatchDataInnerSpecialServicesInner&gt;**](GetShipmentsForBatchDataInnerSpecialServicesInner.md) | Special services used to create shipment | [optional] 
**StepStatus** | [**GetShipmentsForBatchDataInnerStepStatus**](GetShipmentsForBatchDataInnerStepStatus.md) |  | [optional] 
**ToAddress** | [**ToAddress**](ToAddress.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

