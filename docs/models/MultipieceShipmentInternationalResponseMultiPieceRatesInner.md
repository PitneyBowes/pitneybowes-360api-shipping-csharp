# com.pitneybowes.api360.Model.MultipieceShipmentInternationalResponseMultiPieceRatesInner
Individual rate information for a multipiece shipment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseCharge** | **decimal** |  | [optional] 
**TotalCarrierCharge** | **decimal** | The total amount payable to the carrier for the entire shipment, including base charges, special service fees, surcharges, and any applicable international taxes and duties. | [optional] 
**Carrier** | **string** | The name of the carrier providing the shipping service. | [optional] 
**CurrencyCode** | **string** | The currency code in which the rates are calculated. | [optional] 
**DeliveryCommitment** | [**MultipieceShipmentInternationalResponseMultiPieceRatesInnerDeliveryCommitment**](MultipieceShipmentInternationalResponseMultiPieceRatesInnerDeliveryCommitment.md) |  | [optional] 
**RateTypeId** | **string** | The identifier for the type of rate applied. | [optional] 
**ServiceId** | **string** | The identifier for the shipping service used. | [optional] 
**MultiPieceParcels** | [**List&lt;MultipieceShipmentResponseMultiPieceRatesInnerMultiPieceParcelsInner&gt;**](MultipieceShipmentResponseMultiPieceRatesInnerMultiPieceParcelsInner.md) | Details of each parcel within the multi-piece shipment. | [optional] 
**Surcharges** | [**List&lt;MultipieceShipmentResponseMultiPieceRatesInnerSurchargesInner&gt;**](MultipieceShipmentResponseMultiPieceRatesInnerSurchargesInner.md) | Additional fees or surcharges applied to the shipment. Each object in the array represents a specific surcharge and its associated fee.  The &#x60;name&#x60; field must be one of the supported surcharge types from the respective carrier.  **Supported Surcharge Names by Carrier:**  | Carrier       | Surcharge Names | |- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- --| | DHL Express   | FUEL, GO_GREEN_BASIC, OVERSIZE, PREMIUM, RURAL, TOLL | | FedEx         | ANCILLARY_FEE, CANADIAN_DESTINATION, DELIVERY_AREA, DELIVERY_CONFIRMATION, FUEL, NON_MACHINABLE, OTHER, OUT_OF_DELIVERY_AREA, OUT_OF_PICKUP_AREA, OVERSIZE, RESIDENTIAL_DELIVERY, RESIDENTIAL_PICKUP | | UPS           | DELIVERY_AREA, EXTENDED_AREA, FUEL, LARGE_PACKAGE, RESIDENTIAL, SHIPPER_PAYS_DUTY_TAX | | USPS          | nonmachinable, oversize |  | [optional] 
**PublishedTotalCarrierCharge** | **decimal** | The total amount based on the carrier&#39;s standard (published) rates, including base charges, surcharges, special services, discounts, and applicable taxes. This value reflects the amount the carrier would charge without any negotiated discounts or platform-specific rate adjustments. - Returned only when supported by the carrier (e.g., FedEx, UPS, DHL, USPS).\&quot;  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

