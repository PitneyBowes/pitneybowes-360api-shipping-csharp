# com.pitneybowes.api360.Model.SchedulePickupUSPSRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PackageLocation** | **string** | The location where the parcel will be available for pickup at the specified pickup address. | 
**CarrierAccountId** | **string** | The unique identifier of the carrier account being used to process the pickup. | 
**PickupAddress** | [**SchedulePickupUSPSRequestPickupAddress**](SchedulePickupUSPSRequestPickupAddress.md) |  | 
**PickupSummary** | [**List&lt;SchedulePickupUSPSRequestPickupSummaryInner&gt;**](SchedulePickupUSPSRequestPickupSummaryInner.md) | An array of the pickup details, including the number of packages, total weight, and carrier service information. | 
**Additionalnotes** | **string** | Additional instructions or notes for the carrier regarding the pickup. &lt;br /&gt; Value is required when packageLocation is set to other. | [optional] 
**Reference** | **string** | An optional Reference related to the pickup. | [optional] 
**ShipmentIds** | **List&lt;string&gt;** | A comma-separated list of shipment IDs associated with the pickup request.  | [optional] 
**PickupOptions** | [**SchedulePickupDHLEXPRequestPickupOptions**](SchedulePickupDHLEXPRequestPickupOptions.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

