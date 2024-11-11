# com.pitneybowes.api360.Model.GetAllPickupsDataInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PackageLocation** | **string** | It specifies the location from where packages would be collected. | [optional] 
**PickupConfirmationNumber** | **string** | It displays the unique confirmation number of the pickup | [optional] 
**PickupId** | **string** | It displays the unique pickup Id which can be further used to get scheduled PDF and cancel pdf if required. | [optional] 
**Carrier** | **string** | It dispays the carrier | [optional] 
**CarrierAccountId** | **string** | It displays the carrier acount id which is used to create the shipment | [optional] 
**PickupAddress** | [**SchedulePickupDHLEXPResponsePickupAddress**](SchedulePickupDHLEXPResponsePickupAddress.md) |  | [optional] 
**ShipmentIds** | **List&lt;string&gt;** | It indicates the shipmentIds for which pickup is scheduled. | [optional] 
**PickupSummary** | [**List&lt;GetAllPickupsDataInnerPickupSummaryInner&gt;**](GetAllPickupsDataInnerPickupSummaryInner.md) | It displays the package details provided in the request. | [optional] 
**SpecialInstructions** | **string** | It displays additional comments or remarks provided in the request, it would be printed on the scheduled pickup document | [optional] 
**Reference** | **string** | It displays any reference information provided in the request. | [optional] 
**PickupDateTime** | **string** | It displays the scheduled pickup date and time (in UTC) | [optional] 
**PickupTotalWeight** | **decimal** | It displays the total package weight. | [optional] 
**PickupTotalWeightUnit** | **string** | It displays the weight unit. | [optional] 
**PickupOptions** | [**GetAllPickupsDataInnerPickupOptions**](GetAllPickupsDataInnerPickupOptions.md) |  | [optional] 
**PickupRate** | [**SchedulePickupUPSResponsePickupRate**](SchedulePickupUPSResponsePickupRate.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

