# com.pitneybowes.api360.Model.SchedulePickupUPSRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PackageLocation** | **string** | It specifies the location from where packages would be collected. Applicable values are &#x60;Front Door&#x60;,&#x60;Back Door&#x60;,&#x60;Side Door&#x60;,&#x60;Shipping&#x60;,&#x60;Receiving&#x60;,&#x60;Knock on Door/Ring Bell&#x60;,&#x60;Mail Room&#x60;,&#x60;Garage&#x60;,&#x60;Office&#x60;,&#x60;Downstairs&#x60;,&#x60;Reception&#x60;,&#x60;In/At Mailbox&#x60;,&#x60;Third Party&#x60;,&#x60;Warehouse&#x60;,&#x60;Other&#x60; | 
**CarrierAccountId** | **string** | It specifies the carrier account id, its value can be referenced from the &#x60;Get Carrier Accounts&#x60; API. | 
**PickupAddress** | [**SchedulePickupDHLEXPRequestPickupAddress**](SchedulePickupDHLEXPRequestPickupAddress.md) |  | 
**ShipmentIds** | **List&lt;string&gt;** | It indicates the shipmentIds for which pickup to be scheduled. | [optional] 
**PickupSummary** | [**List&lt;SchedulePickupUPSRequestPickupSummaryInner&gt;**](SchedulePickupUPSRequestPickupSummaryInner.md) | This can be used to add package details for which labels are not created yet but would want to schedule pickup in advance. | [optional] 
**Additionalnotes** | **string** | It can be used to provide any additional comments or remarks, it would be printed on the scheduled pickup document. It is required when packageLocation is set to &#x60;Other&#x60;. | [optional] 
**Reference** | **string** | It is used for any reference purpose | [optional] 
**PickupOptions** | [**SchedulePickupUPSRequestPickupOptions**](SchedulePickupUPSRequestPickupOptions.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

