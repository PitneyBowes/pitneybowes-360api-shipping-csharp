# com.pitneybowes.api360.Model.RateShipment200ResponseRateInner
Carrier-provided rate details for the shipment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseCharge** | **decimal** | The base service charge payable to the carrier, excluding special service charges. | [optional] 
**BaseChargeTaxes** | [**List&lt;RateShipment200ResponseRateInnerBaseChargeTaxesInner&gt;**](RateShipment200ResponseRateInnerBaseChargeTaxesInner.md) | List of taxes applied to the base charge. Returned in case of Canada carriers, such as: purolator, Canpar and Fedex. | [optional] 
**Carrier** | **string** | Carrier responsible for transporting the shipment. | [optional] 
**ParcelType** | **string** | Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection.&lt;br/&gt; ParcelType have categories like Package, Envelopes, Paks, Boxes, Tube, etc. | [optional] 
**RateTypeId** | **string** | Type of rate associated with the quote, such as CONTRACT_RATES or RETAIL_RATES. | [optional] 
**ServiceId** | **string** | The unique identifier given to the carrier specific service. | [optional] 
**Surcharges** | [**List&lt;RateShipment200ResponseRateInnerSurchargesInner&gt;**](RateShipment200ResponseRateInnerSurchargesInner.md) | Additional fees or surcharges applied to the shipment. Each object in the array represents a specific surcharge and its associated fee.  The &#x60;name&#x60; field must be one of the supported surcharge types from the respective carrier.  **Supported Surcharge Names by Carrier:**  | Carrier       | Surcharge Names | |- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- --| | DHL Express   | FUEL, GO_GREEN_BASIC, OVERSIZE, PREMIUM, RURAL, TOLL | | FedEx         | ANCILLARY_FEE, CANADIAN_DESTINATION, DELIVERY_AREA, DELIVERY_CONFIRMATION, FUEL, NON_MACHINABLE, OTHER, OUT_OF_DELIVERY_AREA, OUT_OF_PICKUP_AREA, OVERSIZE, RESIDENTIAL_DELIVERY, RESIDENTIAL_PICKUP | | UPS           | DELIVERY_AREA, EXTENDED_AREA, FUEL, LARGE_PACKAGE, RESIDENTIAL, SHIPPER_PAYS_DUTY_TAX | | USPS          | nonmachinable, oversize |  | [optional] 
**TotalCarrierCharge** | **decimal** | Total amount payable to the carrier, including base and special service fees. | [optional] 
**DeliveryCommitment** | [**RateShipment200ResponseRateInnerDeliveryCommitment**](RateShipment200ResponseRateInnerDeliveryCommitment.md) |  | [optional] 
**TotalTaxAmount** | **float** | Total tax amount applied to the shipment. Returned in case of canada carriers. | [optional] 
**DestinationZone** | **string** | This is the postal or delivery zone assigned to the shipment&#39;s destination by the carrier. This field is returned for USPS as of now. | [optional] 
**PublishedTotalCarrierCharge** | **decimal** | The total amount based on the carrier&#39;s standard (published) rates, including base charges, surcharges, special services, discounts, and applicable taxes. This value reflects the amount the carrier would charge without any negotiated discounts or platform-specific rate adjustments. - Returned only when supported by the carrier (e.g., FedEx, UPS, DHL, USPS).\&quot;  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

