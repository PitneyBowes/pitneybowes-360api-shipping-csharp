# com.pitneybowes.api360.Model.SchedulePickupUPSRequestPickupSummaryInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServiceId** | **string** | The abbreviated name of the carrier-specific service. | [optional] 
**PackageCount** | **decimal** | The total number of packages being picked up. | [optional] 
**TotalWeight** | **decimal** | The total weight of all packages to be picked up, measured in units supported by the carrier in the origin country. The value is a decimal with up to 2 decimal places. | [optional] 
**WeightUnit** | **string** | The unit of measurement for the total package weight. | [optional] 
**ParcelType** | **string** | Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection. Here, it reflects as per the defined ParcelType Rules. ParcelType have categories like Package, Envelopes, Paks, Boxes, Tube, etc.  | [optional] 
**ToAddressCountryCode** | **string** | The two-letter country code of the destination country for the shipment. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

