# com.pitneybowes.api360.Model.SchedulePickupDHLEXPRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PackageLocation** | **string** | The location where the parcel will be available for pickup at the specified pickup address. | 
**CarrierAccountId** | **string** | The unique identifier of the carrier account being used to process the pickup. | 
**PickupAddress** | [**SchedulePickupDHLEXPRequestPickupAddress**](SchedulePickupDHLEXPRequestPickupAddress.md) |  | 
**PickupSummary** | [**List&lt;SchedulePickupDHLEXPRequestPickupSummaryInner&gt;**](SchedulePickupDHLEXPRequestPickupSummaryInner.md) | An array of the pickup details, including the number of packages, total weight, and carrier service information and package details. | 
**Additionalnotes** | **string** | Additional instructions or notes for the carrier regarding the pickup. | [optional] 
**Reference** | **string** | An optional Reference related to the pickup. | [optional] 
**PickupOptions** | [**SchedulePickupDHLEXPRequestPickupOptions**](SchedulePickupDHLEXPRequestPickupOptions.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

