# com.pitneybowes.api360.Model.MilitaryMailShipmentsResponseRate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseCharge** | **decimal** | The base service charge is payable to the carrier, excluding special service charges. | [optional] 
**Carrier** | **string** | Carrier is a service used to transport the parcels or couriers from one place to another. | [optional] 
**CurrencyCode** | **string** | A three-character (all uppercase letter) symbol of a currency according to the international ISO standard. As a rule, the first two letters denote the name of the country, and the third letter, the name of the currency thereof. For example, for US - the currency is Dollars and code is USD. Similarly for Canada, the currencycode is CAD, and for India, it is INR.  | [optional] 
**DeliveryCommitment** | [**MultipieceRateShopResponseRatesInnerDeliveryCommitment**](MultipieceRateShopResponseRatesInnerDeliveryCommitment.md) |  | [optional] 
**ParcelType** | **string** | Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection. ParcelType have categories like Package, Envelopes, Paks, Boxes, Tube, etc.  | [optional] 
**RateTypeId** | **string** | Its value can be CONTRACT_RATES, COMMERCIAL or COMMERCIAL_BASE for USPS and COMMERCIAL for other carriers depending on the Pitney Bowes contract/subscription | [optional] 
**ServiceId** | **string** | The unique identifier given to the carrier specific service. | [optional] 
**SpecialServices** | [**List&lt;DomesticShipmentResponseRateSpecialServicesInner&gt;**](DomesticShipmentResponseRateSpecialServicesInner.md) | It provides a carrier-service based special or extra service. | [optional] 
**TotalCarrierCharge** | **decimal** | The total amount payable to the carrier, including special service fees, surcharges, and any international taxes and duties, except as noted below: | [optional] 
**InductionPostalCode** | **string** | The postal code where the shipment is tendered to the carrier. If an induction postal code is specified in the \&quot;fromAddress\&quot;, it will be used for rate calculations and determining manifest eligibility instead of the standard postal code. If not specified, the postal code from the \&quot;fromAddress\&quot; will be used. | [optional] 
**DestinationZone** | **string** | This is the postal or delivery zone assigned to the shipment&#39;s destination by the carrier. This field is returned for USPS as of now. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

