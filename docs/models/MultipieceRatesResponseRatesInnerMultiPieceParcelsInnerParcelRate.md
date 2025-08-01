# com.pitneybowes.api360.Model.MultipieceRatesResponseRatesInnerMultiPieceParcelsInnerParcelRate
Details of the charges applicable to the parcel.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseCharge** | **decimal** | The base charge for shipping the parcel. | [optional] 
**DeliveryCommitment** | [**MultipieceRatesResponseRatesInnerMultiPieceParcelsInnerParcelRateDeliveryCommitment**](MultipieceRatesResponseRatesInnerMultiPieceParcelsInnerParcelRateDeliveryCommitment.md) |  | [optional] 
**Surcharges** | [**List&lt;MultipieceRatesResponseRatesInnerMultiPieceParcelsInnerParcelRateSurchargesInner&gt;**](MultipieceRatesResponseRatesInnerMultiPieceParcelsInnerParcelRateSurchargesInner.md) | Additional fees or surcharges applied to the shipment. Each object in the array represents a specific surcharge and its associated fee.  The &#x60;name&#x60; field must be one of the supported surcharge types from the respective carrier.  **Supported Surcharge Names by Carrier:**  | Carrier       | Surcharge Names     |- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- --| | DHL Express   | FUEL, GO_GREEN_BASIC, OVERSIZE, PREMIUM, RURAL, TOLL                            | | FedEx         | ANCILLARY_FEE, CANADIAN_DESTINATION, DELIVERY_AREA, DELIVERY_CONFIRMATION, FUEL, NON_MACHINABLE, OTHER, OUT_OF_DELIVERY_AREA, OUT_OF_PICKUP_AREA, OVERSIZE, RESIDENTIAL_DELIVERY, RESIDENTIAL_PICKUP | | UPS           | DELIVERY_AREA, EXTENDED_AREA, FUEL, LARGE_PACKAGE, RESIDENTIAL, SHIPPER_PAYS_DUTY_TAX | | USPS          | nonmachinable, oversize                                                         |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

