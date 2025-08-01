# com.pitneybowes.api360.Model.GetAllPickupsDataPickupSummaryInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServiceId** | **string** | The abbreviated name of the carrier-specific service. | [optional] 
**PackageCount** | **decimal** | The total number of packages being picked up. | [optional] 
**TotalWeight** | **decimal** | The total weight of all packages to be picked up, measured in units supported by the carrier in the origin country. The value is a decimal with up to 2 decimal places. | [optional] 
**WeightUnit** | **string** | The unit of measurement for the total package weight. | [optional] 
**CurrencyCode** | **string** | The currency code in which the rates are calculated. &lt;br/&gt; This field is supported for FEDEX carrier only. | [optional] 
**ParcelType** | **string** | The type of parcel used for the shipment, as defined by the carrier. Supported for UPS and FedEx carriers. | [optional] 
**PackageDetails** | [**List&lt;SchedulePickupDHLEXPRequestPickupSummaryInnerPackageDetailsInner&gt;**](SchedulePickupDHLEXPRequestPickupSummaryInnerPackageDetailsInner.md) | Details of each package in the parcel being picked up. Supported for DHLEXP carrier only. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

