# com.pitneybowes.api360.Model.SubscriptionCapabilitiesRequestCapabilities
Carrier-specific capability codes to allow for the subscription and origin country.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParcelTypes** | **List&lt;string&gt;** | Package codes allowed in shipment calls for this subscription. Only these codes will be accepted by Rate Shipment and Create Shipment calls. Set only what you intend to use; others will be rejected. If omitted, the current allowlist (or carrier-supported defaults) remains in effect. | [optional] 
**Services** | **List&lt;string&gt;** | Service codes allowed in shipment calls for this subscription. Only these codes will be accepted in Rate Shipment and Create Shipment calls. Set only what you intend to use; others will be rejected. If omitted, the current allowlist (or carrier-supported defaults) remains in effect. | [optional] 
**SpecialServices** | **List&lt;string&gt;** | Special service codes allowed in shipment calls for this subscription. Only these codes will be accepted by Rate Shipment and Create Shipment calls. Set only what you intend to use; others will be rejected. If omitted, the current allowlist (or carrier-supported defaults) remains in effect. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

