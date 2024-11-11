# com.pitneybowes.api360.Model.SchedulePickupDHLEXPRequest
It specifies the request body for scheduling pickup for DHL Express

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PackageLocation** | **string** | It specifies the location from where packages would be collected. Applicable values are &#x60;NONE&#x60;, &#x60;FRONT&#x60;,&#x60;RECEPTION&#x60;,&#x60;BACK&#x60;,&#x60;LOADING DOCK&#x60; | 
**CarrierAccountId** | **string** | It specifies the carrier account id, its value can be referenced from the &#x60;Get Carrier Accounts&#x60; API. | 
**PickupAddress** | [**SchedulePickupDHLEXPRequestPickupAddress**](SchedulePickupDHLEXPRequestPickupAddress.md) |  | 
**ShipmentIds** | **List&lt;string&gt;** | It indicates the shipmentIds for which pickup to be scheduled. | [optional] 
**PickupSummary** | [**List&lt;SchedulePickupDHLEXPRequestPickupSummaryInner&gt;**](SchedulePickupDHLEXPRequestPickupSummaryInner.md) | This can be used to add package details for which labels are not created yet but would want to schedule pickup in advance. | [optional] 
**Additionalnotes** | **string** | It can be used to provide any additional comments or remarks, it would be printed on the scheduled pickup document | [optional] 
**Reference** | **string** | It is used for any reference purpose | [optional] 
**PickupOptions** | [**SchedulePickupDHLEXPRequestPickupOptions**](SchedulePickupDHLEXPRequestPickupOptions.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

