# com.pitneybowes.api360.Model.RateShopResponseRatesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseCharge** | **decimal** | The base service charge is payable to the carrier, excluding special service charges. | [optional] 
**Carrier** | **string** | Carrier is a service used to transport the parcels or couriers from one place to another. | [optional] 
**CarrierAccount** | **string** | Carrier Account is the account associated to specific carrier service. | [optional] 
**DeliveryCommitment** | [**RateShopResponseRatesInnerDeliveryCommitment**](RateShopResponseRatesInnerDeliveryCommitment.md) |  | [optional] 
**CurrencyCode** | **string** | A three-character (all uppercase letter) symbol of a currency according to the international ISO standard. As a rule, the first two letters denote the name of the country, and the third letter, the name of the currency thereof. For example, for US - the currency is Dollars and code is USD. Similarly for Canada, the currencycode is CAD, and for India, it is INR.  | [optional] 
**ParcelType** | **string** | Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection. ParcelType have categories like Package, Envelopes, Paks, Boxes, Tube, etc.  | [optional] 
**RateTypeId** | **string** | Its value can be CONTRACT_RATES, COMMERCIAL or COMMERCIAL_BASE for USPS and COMMERCIAL for other carriers depending on the Pitney Bowes contract/subscription | [optional] 
**ServiceId** | **string** | The unique identifier given to the carrier specific service. | [optional] 
**Surcharges** | [**List&lt;RateShipment200ResponseRateInnerSurchargesInner&gt;**](RateShipment200ResponseRateInnerSurchargesInner.md) | Additional fees or surcharges applied to the shipment. Each object in the array represents a specific surcharge and its associated fee.  The &#x60;name&#x60; field must be one of the supported surcharge types from the respective carrier.  **Supported Surcharge Names by Carrier:**  | Carrier       | Surcharge Names | |- -- -- -- -- -- -- --|- -- -- -- -- -- -- -- --| | DHL Express   | FUEL, GO_GREEN_BASIC, OVERSIZE, PREMIUM, RURAL, TOLL | | FedEx         | ANCILLARY_FEE, CANADIAN_DESTINATION, DELIVERY_AREA, DELIVERY_CONFIRMATION, FUEL, NON_MACHINABLE, OTHER, OUT_OF_DELIVERY_AREA, OUT_OF_PICKUP_AREA, OVERSIZE, RESIDENTIAL_DELIVERY, RESIDENTIAL_PICKUP | | UPS           | DELIVERY_AREA, EXTENDED_AREA, FUEL, LARGE_PACKAGE, RESIDENTIAL, SHIPPER_PAYS_DUTY_TAX | | USPS          | nonmachinable, oversize |  | [optional] 
**TotalCarrierCharge** | **decimal** | The total amount payable to the carrier, including special service fees, surcharges, and any international taxes and duties | [optional] 
**DestinationZone** | **string** | This is the postal or delivery zone assigned to the shipment&#39;s destination by the carrier. This field is returned for USPS as of now. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

