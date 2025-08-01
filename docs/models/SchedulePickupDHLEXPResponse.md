# com.pitneybowes.api360.Model.SchedulePickupDHLEXPResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PackageLocation** | **string** | The location where the parcel will be available for pickup at the specified pickup address. | [optional] 
**PickupConfirmationNumber** | **string** | The confirmation number generated when the pickup request is successfully processed. | [optional] 
**PickupId** | **string** | A unique identifier for the scheduled pickup. | [optional] 
**Carrier** | **string** | The carrier being used for the pickup. | [optional] 
**CarrierAccountId** | **string** | The unique identifier of the carrier account being used to process the pickup. | [optional] 
**PickupAddress** | [**SchedulePickupDHLEXPResponsePickupAddress**](SchedulePickupDHLEXPResponsePickupAddress.md) |  | [optional] 
**PickupSummary** | [**List&lt;SchedulePickupDHLEXPResponsePickupSummaryInner&gt;**](SchedulePickupDHLEXPResponsePickupSummaryInner.md) | An array of the pickup details, including the number of packages, total weight, and carrier service information. | [optional] 
**AdditionalNotes** | **string** | Additional instructions or notes for the carrier regarding the pickup. | [optional] 
**PickupDateTime** | **string** | The sdate and time of the pickup window. | [optional] 
**PickupTotalWeight** | **decimal** | The total weight of all packages being picked up. | [optional] 
**PickupTotalWeightUnit** | **string** | The unit of measurement for the total package weight. | [optional] 
**Reference** | **string** | An optional Reference related to the pickup. | [optional] 
**PickupOptions** | [**SchedulePickupDHLEXPResponsePickupOptions**](SchedulePickupDHLEXPResponsePickupOptions.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

