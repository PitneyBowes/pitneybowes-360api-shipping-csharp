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

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

