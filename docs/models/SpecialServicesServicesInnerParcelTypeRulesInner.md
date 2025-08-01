# com.pitneybowes.api360.Model.SpecialServicesServicesInnerParcelTypeRulesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BrandedName** | **string** | The branded name of Parcel Type | [optional] 
**ParcelType** | **string** | Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection. Here, it reflects as per the defined ParcelType Rules. ParcelType have categories like Package, Envelopes, Paks, Boxes, Tube, etc.  | [optional] 
**Trackable** | **string** | Whether this parcel type is trackable. Valid Values are: TRACKABLE, NON_TRACKABLE, REQUIRES_TRACKABLE_SPECIAL_SERVICE | [optional] 
**SuggestedTrackableSpecialService** | **string** | If trackable is set to REQUIRES_TRACKABLE_SPECIAL_SERVICE, this is a free or low-cost special service that allows the shipper to track the shipment. | [optional] 
**SpecialServiceRules** | [**List&lt;SpecialServicesServicesInnerParcelTypeRulesInnerSpecialServiceRulesInner&gt;**](SpecialServicesServicesInnerParcelTypeRulesInnerSpecialServiceRulesInner.md) | It displays all the available special services, their details and prerequisites and/or incompatible details with other special services | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

