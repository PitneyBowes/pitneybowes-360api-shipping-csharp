# com.pitneybowes.api360.Model.RateShopbyRuleset

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromAddress** | [**FromAddressV2**](FromAddressV2.md) |  | 
**ToAddress** | [**ToAddressV2**](ToAddressV2.md) |  | 
**Parcel** | [**RateShopbyCarrierParcel**](RateShopbyCarrierParcel.md) |  | 
**ParcelType** | **string** | Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection.&lt;br /&gt; ParcelType can have categories like Package, Envelopes, Paks, Boxes, Tube, etc. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60; \&quot; | 
**RateShopBy** | **string** | RateShop, which is attached to an Enterprise or Location, is done through three approaches: by Carrier, by RateGroup, and by Ruleset.  &lt;br /&gt;  Through Carrier, customers can choose the carriers as per requirement, based on which services, parcel types, and special services can be selected, and RateShop is done. &lt;br /&gt; Through RateGroup, customers can select the RateGroup, which has been divided into two categories: Cheapest (w.r.t. price) and Fastest (w.r.t. delivery hours).  &lt;br /&gt; Through Ruleset, customers can define the Condition/rule for selecting carriers and their services, so they do not need to worry for Rate Shopping every time they create Shipment. For example, For a particular location, they can set one definite carrier, or apply RateGroup - Cheapest/Fastest.   Similarly, for a particular amount like below $1000 Dollars, they can select a definite carrier service, based on RateGroup. | 
**ByRuleSet** | [**RateShopbyRulesetByRuleSet**](RateShopbyRulesetByRuleSet.md) |  | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

