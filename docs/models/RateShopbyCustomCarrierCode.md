# com.pitneybowes.api360.Model.RateShopbyCustomCarrierCode

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromAddress** | [**FromAddressV2**](FromAddressV2.md) |  | 
**ToAddress** | [**ToAddressV2**](ToAddressV2.md) |  | 
**Parcel** | [**RateShopbyCarrierParcel**](RateShopbyCarrierParcel.md) |  | 
**RateShopBy** | **string** | RateShop, which is attached to an Enterprise or Location, is done through four approaches: by Carrier, by RateGroup, by RuleSet and by CustomCarrierCode.  &lt;br /&gt;  Through Carrier, customers can choose the carriers as per requirement, based on which services, parcel types, and special services can be selected, and RateShop is done. &lt;br /&gt; Through RateGroup, customers can select the RateGroup, which has been divided into two categories: Cheapest (w.r.t. price) and Fastest (w.r.t. delivery hours).  &lt;br /&gt; Through RuleSet, customers can define the Condition/rule for selecting carriers and their services, so they do not need to worry for Rate Shopping every time they create Shipment. For example, For a particular location, they can set one definite carrier, or apply RateGroup - Cheapest/Fastest.   Similarly, for a particular amount like below $1000 Dollars, they can select a definite carrier service, based on RateGroup. | 
**ParcelType** | **string** | Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection.&lt;br /&gt; ParcelType can have categories like Package, Envelopes, Paks, Boxes, Tube, etc. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;   - For Rate Shop by Custom Carrier Code, the parcelType field in the request payload is optional:  - If the parcel type is defined in the Custom Carrier Code metadata, it does not need to be provided in the request payload.  - If the parcel type is not defined in the Custom Carrier Code, it must be provided in the request payload.  - If parcel type is provided in both the request payload and Custom Carrier Code, then  request payload value will be overridden by the values defined in the Custom Carrier Code.  | [optional] 
**ByCustomCarrierCode** | [**RateShopbyCustomCarrierCodeByCustomCarrierCode**](RateShopbyCustomCarrierCodeByCustomCarrierCode.md) |  | [optional] 
**DeliveryOption** | [**RateShopbyCarrierDeliveryOption**](RateShopbyCarrierDeliveryOption.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

