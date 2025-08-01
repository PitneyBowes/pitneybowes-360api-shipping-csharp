# com.pitneybowes.api360.Model.RateShopbyCarrierByCarrier
Specifies the carrier and service configuration used for rate retrieval in Rate Shipment V2 This object enables the following use cases:   1. **Rate Shop for a Single Carrier**: Provide either `carrier` or `carrierAccountId` to retrieve all available rates from the specified carrier.   2. **Single Rate Retrieval by Service ID**: Provide both `carrier` (or `carrierAccountId`) and `service` to retrieve a single rate corresponding to the specified service.   3. **Rate Shop Across Carriers**: Omit this object to retrieve rates from all carriers available under the current subscription. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierAccountId** | **string** | This is a unique identifier associated with the specific sub-carrier account, which must be valid.&lt;br /&gt; This is used in the shipment creation (if this value is defined, Carrier properties will be skipped). | 
**Carrier** | **string** | A unique identifier associated with the specific carrier, i.e. CarrierID, which must be valid. | 
**Service** | **string** | Indicates a unique identifier associated with the carrier specific service, which is ServiceID, which must be valid. Required only when requesting a specific service rate from the given carrier. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

