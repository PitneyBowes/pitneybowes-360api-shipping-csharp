# com.pitneybowes.api360.Model.ShipmentBatchResponseERR

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BatchId** | **string** | This is a system-generated unique identifier assigned to the ERR Batch while it is processed. | [optional] 
**Name** | **string** | Name of the of ERR Batch which consists of multiple shipments (shipments in bulk). | [optional] 
**GroupName** | **string** |  Indicates the name of the group of batches, which consists of multiple Batch groups. | [optional] 
**Status** | [**JobStatus**](JobStatus.md) |  | [optional] 
**UploadURL** | **string** | For the stored Batch file under S3, this is the S3 returned URL. The URL is uploaded along with the .CSV file to get the BatchID, which is used to track the import status. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

