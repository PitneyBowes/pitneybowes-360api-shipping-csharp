# com.pitneybowes.api360.Model.SingleRateResponseRatesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BaseCharge** | **decimal** | The base service charge is payable to the carrier, excluding special service charges. | [optional] 
**Carrier** | **string** | Carrier is a service used to transport the parcels or couriers from one place to another. | [optional] 
**CarrierAccount** | **string** | Carrier Account is the account associated to specific carrier service. | [optional] 
**DeliveryCommitment** | [**RateShopResponseRatesInnerDeliveryCommitment**](RateShopResponseRatesInnerDeliveryCommitment.md) |  | [optional] 
**ParcelType** | **string** | Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection. ParcelType have categories like Package, Envelopes, Paks, Boxes, Tube, etc.  | [optional] 
**RateTypeId** | **string** | Its value can be CONTRACT_RATES, COMMERCIAL or COMMERCIAL_BASE for USPS and COMMERCIAL for other carriers depending on the Pitney Bowes contract/subscription | [optional] 
**ServiceId** | **string** | The unique identifier given to the carrier specific service. | [optional] 
**SpecialServices** | [**List&lt;SingleRateResponseRatesInnerSpecialServicesInner&gt;**](SingleRateResponseRatesInnerSpecialServicesInner.md) |  It provides a carrier-service based special or extra service. | [optional] 
**TotalCarrierCharge** | **decimal** | The total amount payable to the carrier, including special service fees, surcharges, and any international taxes and duties. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

