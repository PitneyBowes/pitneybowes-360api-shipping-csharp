# com.pitneybowes.api360.Model.VoidBatchRequest
The request to cancel Batch.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Indicates the name of the Batch, i.e., a list of shipments, which need to be cancelled. | 
**Reason** | **string** | Reason to cancel the batch of shipments. | [optional] 
**ShipmentIds** | **List&lt;string&gt;** | &gt;- Shipment ID is a unique identifier for an individual shipment. If ShipmentID(s) are passed in the array, then corresponding shipments will be cancelled. If ShipmentID(s) is/are not provided, then the entire shipments of the Batch will be cancelled. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

