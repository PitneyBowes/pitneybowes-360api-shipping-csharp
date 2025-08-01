# com.pitneybowes.api360.Model.RateShopbyCarrierParcel
Parcel details, including dimensions and weight.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Length** | **decimal** | Length of the parcel. ength is always the greatest of the three dimensions. The other two dimensions are used in the calculation of the girth. | [optional] 
**Width** | **decimal** | Width of the parcel. There is no strict rule as to which element is the width or the height, but the width is the second greatest dimension of a parcel by convention. | [optional] 
**Height** | **decimal** | Height of the parcel. By convention, the height is the smallest dimension of the parcel. | [optional] 
**DimUnit** | **string** | Unit for dimensions. | [optional] 
**WeightUnit** | **string** | Unit for weight. | [optional] 
**Weight** | **decimal** | Weight of the parcel. | [optional] 
**PackageValue** | **decimal** | Declared value of the parcel. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

