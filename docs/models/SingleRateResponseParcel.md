# com.pitneybowes.api360.Model.SingleRateResponseParcel
It provides details of parcel its weight, dimension and respective unit of measurement

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Length** | **int** | Length is always the greatest of the three dimensions. The other two dimensions are used in the calculation of the girth. | 
**Width** | **int** | There is no strict rule as to which element is the width or the height, but typically, by convention the width is the second greatest dimension of a parcel. | 
**Height** | **int** | By convention, the height is the smallest dimension of the parcel. | 
**DimUnit** | **string** | DimUnit is a standard for measuring the physical quantities of specified dimension parameters. | 
**WeightUnit** | **string** | WeightUnit is a standard for measuring the physical quantities of specified weight. | 
**Weight** | **decimal** | Weight is the measure of how heavy an object is. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

