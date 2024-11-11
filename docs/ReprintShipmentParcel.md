# com.pitneybowes.api360.Model.ReprintShipmentParcel

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Height** | **decimal** | Height is a part of Dimension objet where it helps determine a parcel’s girth. | 
**Length** | **decimal** | Length is a part of Dimension objet having highest numeric value out of three required parameters (length, width, and height) of Dimension. It helps determine a parcel’s girth. | 
**Width** | **decimal** | Width is a part of Dimension object having lowest numeric value out of three required parameters of dimension (length, width, and height). This helps determine a parcel’s girth. | 
**DimUnit** | **string** | DimUnit is a standard for measuring the physical quantities of specified dimension parameters. | 
**WeightUnit** | **string** | WeightUnit is a standard for measuring the physical quantities of specified weight. &lt;br&gt; The valid values are:  &lt;br&gt;- OZ: Ounces &lt;br&gt;- GM: Grams &lt;br&gt;- LB: Pounds &lt;br&gt;- KG: Kilograms For USPS shipments, set this to OZ. | 
**Weight** | **decimal** | Weight is the measure of how heavy an object is. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

