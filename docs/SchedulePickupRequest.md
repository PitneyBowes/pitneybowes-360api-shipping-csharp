# com.pitneybowes.api360.Model.SchedulePickupRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PackageLocation** | **string** | It specifies the location from where packages would be collected. Applicable values are &#x60;FRONT&#x60;,&#x60;NONE&#x60;,&#x60;SIDE&#x60;,&#x60;REAR&#x60; | 
**CarrierAccountId** | **string** | It specifies the carrier account id, its value can be referenced from the &#x60;Get Carrier Accounts&#x60; API. | 
**PickupAddress** | [**SchedulePickupDHLEXPRequestPickupAddress**](SchedulePickupDHLEXPRequestPickupAddress.md) |  | 
**ShipmentIds** | **List&lt;string&gt;** | It indicates the shipmentIds for which pickup to be scheduled. | [optional] 
**PickupSummary** | [**List&lt;SchedulePickupFedexRequestPickupSummaryInner&gt;**](SchedulePickupFedexRequestPickupSummaryInner.md) | This can be used to add package details for which labels are not created yet but would want to schedule pickup in advance. | [optional] 
**Additionalnotes** | **string** | It can be used to provide any additional comments or remarks, it would be printed on the scheduled pickup document. | [optional] 
**Reference** | **string** | It is used for any reference purpose | [optional] 
**PickupOptions** | [**SchedulePickupFedexRequestPickupOptions**](SchedulePickupFedexRequestPickupOptions.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

