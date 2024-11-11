# com.pitneybowes.api360.Model.GetShipmentsForBatchDataInnerStepStatus
It displays different status of shipments at each level- addressValidation, rating, labelGeneration, and voidLabel.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Import** | **string** | This is only visible for batch submitted during Import via .CSV. | [optional] 
**AddressValidation** | **string** | It indicates the status of shipments at addressValidation stage. | [optional] 
**Rating** | **string** | It indicates status of shipments at rating level. | [optional] 
**LabelGeneration** | **string** | It indicates status of shipments at labelGeneration step. | [optional] 
**VoidLabel** | **string** | It will only be visible when batch labels are cancelled. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

