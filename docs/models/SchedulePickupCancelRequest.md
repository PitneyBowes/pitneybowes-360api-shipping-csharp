# com.pitneybowes.api360.Model.SchedulePickupCancelRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PickupIds** | **List&lt;string&gt;** | Unique identifiers for scheduled pickups. | 
**Options** | [**List&lt;SchedulePickupCancelRequestOptionsInner&gt;**](SchedulePickupCancelRequestOptionsInner.md) | An array of key-value pairs specifying additional parameters for the cancellation request. &lt;br/&gt;There are two required keys: &#x60;REQUESTOR_NAME&#x60; and &#x60;REASON_FOR_CANCEL&#x60;. The value for REQUESTOR_NAME is required, while the value for REASON_FOR_CANCEL is optional. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

