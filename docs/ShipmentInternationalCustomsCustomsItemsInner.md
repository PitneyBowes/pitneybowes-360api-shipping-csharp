# com.pitneybowes.api360.Model.ShipmentInternationalCustomsCustomsItemsInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | A detailed description of the commodity, up to 255 characters. The description will appear on the customs form. If the shipment has multiple types of items, create a separate customsItems object for each. Each description will appear on the form. | 
**HSTariffCode** | **string** | The destination country’s tariff-classification number (HS code) for the commodity. Most countries use the six-digit Harmonized System (HS) as the basis for their tariff classifications and then add digits for more detail. The maximum length for an HS code is 14 characters. The HS code will appear on the customs form. If the shipment has multiple types of items, create a separate customsItems object for each. | [optional] 
**OriginCountryCode** | **string** | The two-character ISO country code of the shipment’s origin country. Use ISO 3166-1 alpha-2 standard values. | [optional] 
**Quantity** | **decimal** | Enter the total number of items of this type of commodity. | 
**UnitPrice** | **decimal** | The price of one item of this type of commodity. | 
**WeightUnit** | **string** | The unit of measurement. This field is required by the unitWeight object. | [optional] 
**Weight** | **decimal** | The weight of the item. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

