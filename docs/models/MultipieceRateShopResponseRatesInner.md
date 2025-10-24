# com.pitneybowes.api360.Model.MultipieceRateShopResponseRatesInner
Details of each rate, including charges, service, and parcel information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TotalCarrierCharge** | **decimal** | The total amount payable to the carrier, including base charges, surcharges, and other fees. | [optional] 
**Carrier** | **string** | The name of the carrier providing the shipping service. | [optional] 
**CurrencyCode** | **string** | The currency in which the rates are calculated. | [optional] 
**DeliveryCommitment** | [**MultipieceRateShopResponseRatesInnerDeliveryCommitment**](MultipieceRateShopResponseRatesInnerDeliveryCommitment.md) |  | [optional] 
**RateTypeId** | **string** | description | [optional] 
**ServiceId** | **string** | The identifier for the shipping service to be used. | [optional] 
**MultiPieceParcels** | [**List&lt;MultipieceRateShopResponseRatesInnerMultiPieceParcelsInner&gt;**](MultipieceRateShopResponseRatesInnerMultiPieceParcelsInner.md) | Details of each parcel within the multipiece shipment. | [optional] 
**Surcharges** | [**List&lt;MultipieceRateShopResponseRatesInnerSurchargesInner&gt;**](MultipieceRateShopResponseRatesInnerSurchargesInner.md) | A list of surcharges applied to the entire shipment. | [optional] 
**PublishedTotalCarrierCharge** | **decimal** | The total amount based on the carrier&#39;s standard (published) rates, including base charges, surcharges, special services, discounts, and applicable taxes. This value reflects the amount the carrier would charge without any negotiated discounts or platform-specific rate adjustments. - Returned only when supported by the carrier (e.g., FedEx, UPS, DHL, USPS).\&quot;  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

