# com.pitneybowes.api360.Model.BulkShipmentResponseERR

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchId** | **string** |  This is a system-generated unique identifier assigned to the Batch while it is processed. | [optional] 
**Name** | **string** |  Name of the of ERR Batch which consists of multiple shipments (shipments in bulk). | [optional] 
**GroupName** | **string** | Indicates the name of the group of batches, which consists of multiple Batch groups. | [optional] 
**Status** | [**JobStatus**](JobStatus.md) |  | [optional] 
**AddressValidation** | [**AddressCountStatus**](.md) |  | [optional] 
**Rating** | [**RatingCountStatusERR**](.md) |  | [optional] 
**LabelGeneration** | [**LabelGenerationCountStatus**](.md) |  | [optional] 
**LabelDetails** | [**BulkShipmentResponseERRLabelDetails**](BulkShipmentResponseERRLabelDetails.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

