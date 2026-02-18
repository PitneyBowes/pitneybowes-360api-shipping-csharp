# com.pitneybowes.api360.Model.SchedulePickupCancelRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PickupIds** | **List&lt;string&gt;** | Unique identifiers for scheduled pickups. | 
**Options** | [**List&lt;SchedulePickupCancelRequestOptionsInner&gt;**](SchedulePickupCancelRequestOptionsInner.md) | An array of key-value pairs specifying additional parameters for the cancellation request. &lt;br/&gt;There are three required keys: &#x60;REQUESTOR_NAME&#x60;, &#x60;REASON_FOR_CANCEL&#x60; and &#x60;REMARKS&#x60;. Different carriers required different keys and values for  | Carrier     | Is &#x60;options&#x60; required? | Required keys | Value | |- -- -- -- -- -- --|- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- --|- -- -- --| | USPS   | No   |  | | | DHL Express | Yes  | &#x60;REQUESTOR_NAME&#x60;, &#x60;REASON_FOR_CANCEL&#x60; | &#x60;REQUESTOR_NAME&#x60; value required; &#x60;REASON_FOR_CANCEL&#x60; value optional. | | FedEx  | Yes | &#x60;REMARKS&#x60;  | &#x60;REMARKS&#x60; value required. |  **Notes:** - Keys are case-sensitive. - Provide only the keys relevant to the selected carrier.  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

