# com.pitneybowes.api360.Model.Parcel
The details of the Parcel.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Length** | **float** | Length is always the greatest of the three dimensions. The other two dimensions are used in the calculation of the girth. | [optional] 
**Width** | **float** | There is no strict rule as to which element is the width or the height, but the width is the second greatest dimension of a parcel by convention. | [optional] 
**Height** | **float** | By convention the height is the smallest dimension of the parcel. | [optional] 
**DimUnit** | **string** | DimUnit is a standard for measuring the physical quantities of specified dimension parameters.&lt;br /&gt; The valid values are: Inch and Centimeter. | [optional] 
**WeightUnit** | **string** | WeightUnit is a standard for measuring the physical quantities of specified weight.&lt;br /&gt; The valid values are: Ounces and Grams.&lt;br /&gt; For USPS shipments, set this to OZ. | 
**Weight** | **float** | Weight measures the heaviness of an object (how heavy an object is) . | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

