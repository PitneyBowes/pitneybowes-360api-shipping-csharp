# com.pitneybowes.api360.Model.InternationalShipmentResponseCustomsCustomsItemsInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | A detailed description of the commodity, up to 255 characters. The description will appear on the customs form. If the shipment has multiple types of items, create a separate customsItems object for each. Each description will appear on the form. | [optional] 
**HSTariffCode** | **string** | The destination country’s tariff-classification number (HS code) for the commodity. Most countries use the six-digit Harmonized System (HS) as the basis for their tariff classifications and then add digits for more detail. The maximum length for an HS code is 14 characters. The HS code will appear on the customs form. If the shipment has multiple types of items, create a separate customsItems object for each. | [optional] 
**OriginCountryCode** | **string** | The two-character ISO country code of the shipment’s origin country. Use ISO 3166-1 alpha-2 standard values. | [optional] 
**Quantity** | **decimal** | Enter the total number of items of this type of commodity. | [optional] 
**UnitPrice** | **decimal** | The price of one item of this type of commodity. | [optional] 
**WeightUnit** | **string** | WeightUnit is a standard for measuring the physical quantities of specified weight. &lt;br&gt; The valid values are:  &lt;br&gt;- OZ: Ounces &lt;br&gt;- GM: Grams &lt;br&gt;- LB: Pounds &lt;br&gt;- KG: Kilograms For USPS shipments, set this to OZ. | [optional] 
**Weight** | **decimal** | Weight is the measure of how heavy an object is. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

