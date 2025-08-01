# com.pitneybowes.api360.Model.CustomsItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | A detailed description of the commodity. | 
**Quantity** | **int** | Enter the total number of items of this type of commodity. | 
**UnitPrice** | **double** | &gt;- The price of one item of this type of commodity. Currency should be declared under customsInfo. | 
**WeightUnit** | **string** | The unit of measurement. This field is required by the unitWeight object. | 
**Weight** | **decimal** | The weight of the item. | 
**HSTariffCode** | **string** | &gt;- The destination country&#39;s tariff-classification number for the commodity. Most countries use the six-digit Harmonized System (HS) as the basis for their tariff classifications and add additional digits for more detail. The maximum length is 14 characters. If you are issuing the HS Code API, you can use this field to help with the HS code prediction by entering the commodity&#39;s HS code from another country, such as from the origin country. Enter the country that the code comes from in the hSTariffCodeCountry field. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

