# com.pitneybowes.api360.Model.RatingCountStatusERR
This indicates the status count of shipments which are at Rating stage. Rating is a process of assessing the shipping/freight charge associated with the ERR Bulk shipment. Rates are calculated based on selected special/extra services corresponding to the selected Services and ParcelType for USPS.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Success** | **decimal** | The number of shipments that have been successfully processed for Ratings. | [optional] 
**Failed** | **decimal** | The number of shipments which failed processing at Ratings due to some scenarios like unsupported extra services or incompatible extra services combined for a shipment. | [optional] 
**Pending** | **decimal** | The number of shipments which are pending and in-queue to be processed. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

