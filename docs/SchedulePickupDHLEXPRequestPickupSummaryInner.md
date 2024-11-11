# com.pitneybowes.api360.Model.SchedulePickupDHLEXPRequestPickupSummaryInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServiceId** | **string** | The service id | 
**PackageCount** | **decimal** | The total number of packages | 
**TotalWeight** | **decimal** | The total weight of the packages | 
**WeightUnit** | **string** | Weight Unit, supported values are &#x60;OZ&#x60; and &#x60;GM&#x60; | 
**CurrencyCode** | **string** | Currency code | 
**TotalCustomsDeclaredValue** | **decimal** | It indicates the custom declared value. It is required in case of international shipment. | [optional] 
**PackageDetails** | [**List&lt;SchedulePickupDHLEXPRequestPickupSummaryInnerPackageDetailsInner&gt;**](SchedulePickupDHLEXPRequestPickupSummaryInnerPackageDetailsInner.md) | It descibes the individual package details | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

