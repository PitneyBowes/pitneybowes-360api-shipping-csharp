# com.pitneybowes.api360.Model.PickupAvailabilityRequestPickupSummaryInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ToAddressCountryCode** | **string** | Destination country code of the shipment | [optional] 
**ServiceId** | **string** | Identifier of the shipping service requested (e.g., GND). | [optional] 
**ParcelType** | **string** | Type of parcel (e.g., PKG, LTR) | [optional] 
**TotalWeight** | **decimal** | Total weight of all packages for pickup | [optional] 
**WeightUnit** | **string** | Unit of measurement for weight | [optional] 
**PackageDetails** | [**List&lt;PickupAvailabilityRequestPickupSummaryInnerPackageDetailsInner&gt;**](PickupAvailabilityRequestPickupSummaryInnerPackageDetailsInner.md) |  | [optional] 
**SpecialServices** | [**List&lt;PickupAvailabilityRequestPickupSummaryInnerSpecialServicesInner&gt;**](PickupAvailabilityRequestPickupSummaryInnerSpecialServicesInner.md) |  List of special services requested for the pickup. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

