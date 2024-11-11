# com.pitneybowes.api360.Model.SchedulePickupCancelRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PickupIds** | **List&lt;string&gt;** | It specifies the pickup Ids for which you would like to cancel the request. Only pickupIds of the same carrier should be provided in the array. | 
**Options** | [**List&lt;SchedulePickupCancelRequestOptionsInner&gt;**](SchedulePickupCancelRequestOptionsInner.md) | It is required to be provided for DHL Express pickup cancellation. Both &#x60;REQUESTOR_NAME&#x60; and &#x60;REASON_FOR_CANCEL&#x60; are required for DHL Express. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

