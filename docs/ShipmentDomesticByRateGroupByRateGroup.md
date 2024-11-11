# com.pitneybowes.api360.Model.ShipmentDomesticByRateGroupByRateGroup
Indicates the category to select how cheap the carrier service is, or which carrier has fastest service. <br /> It displays the list of those services. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleType** | **string** | The Rule Type is a condition applied to RateGroup by Product side as per the customer requirement, which can have following options: Cheapest, Fastest, and deliverBy. &lt;br /&gt; If ruleType is deliverBy, then deliverBy date under deliveryOption will be mandatory to provide. | 
**RateGroupId** | **string** | This is a unique identifier assigned to the created RateGroup, which is used in the shipment creation. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

