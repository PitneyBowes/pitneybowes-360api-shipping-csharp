# com.pitneybowes.api360.Model.GetAllPickupsData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PackageLocation** | **string** | The location where the parcel will be available for pickup. | [optional] 
**ConfirmationNumber** | **string** | The confirmation number generated when the pickup request is successfully processed. | [optional] 
**PickupId** | **string** | Unique identifiers for scheduled pickups. | [optional] 
**Carrier** | **string** | The carrier is beng used for the pickup. | [optional] 
**CarrierAccountId** | **string** | The unique identifier of the carrier account being used to process the pickup. | [optional] 
**PickupAddress** | [**GetAllPickupsDataPickupAddress**](GetAllPickupsDataPickupAddress.md) |  | [optional] 
**PickupSummary** | [**List&lt;GetAllPickupsDataPickupSummaryInner&gt;**](GetAllPickupsDataPickupSummaryInner.md) | An array of the pickup details, including the number of packages, total weight, and carrier service information. | [optional] 
**SpecialInstructions** | **string** | Any special instructions or notes for the carrier regarding the pickup. | [optional] 
**TotalWeight** | **decimal** | The total weight of all packages being picked up. | [optional] 
**PickupTotalWeightUnit** | **string** | The unit of measurement for the total package weight. | [optional] 
**TotalCount** | **int** | The total number of packages being picked up. | [optional] 
**Status** | **string** | The current status of the pickup request. Values are &#x60;scheduled&#x60;and &#x60;cancelled&#x60;. | [optional] 
**Reference** | **string** | An optional Reference related to the pickup. | [optional] 
**PickupDateTime** | **string** | The date and time of the pickup. | [optional] 
**PickupOptions** | [**GetAllPickupsDataPickupOptions**](GetAllPickupsDataPickupOptions.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

