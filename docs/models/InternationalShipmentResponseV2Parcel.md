# com.pitneybowes.api360.Model.InternationalShipmentResponseV2Parcel
Details of the parcel being shipped.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Length** | **int** | Length of the parcel. Length is always the greatest of the three dimensions. The other two dimensions are used in the calculation of the girth. | [optional] 
**Height** | **int** | Height of the parcel. By convention, the height is the smallest dimension of the parcel. | [optional] 
**Width** | **int** | Width of the parcel. There is no strict rule as to which element is the width or the height, but typically, by convention the width is the second greatest dimension of a parcel. | [optional] 
**DimUnit** | **string** | DimUnit is a standard for measuring the physical quantities of specified dimension parameters. | [optional] 
**WeightUnit** | **string** | WeightUnit is a standard for measuring the physical quantities of specified weight. | [optional] 
**Weight** | **decimal** | Weight is the measure of how heavy an object is. | [optional] 
**PackageValue** | **decimal** | Declared value of the package. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

