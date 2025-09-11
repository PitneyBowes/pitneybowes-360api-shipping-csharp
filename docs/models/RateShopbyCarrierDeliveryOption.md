# com.pitneybowes.api360.Model.RateShopbyCarrierDeliveryOption
There are two options of delivery: deliverBy and useBestNextDate, where customer can schedule the delivery date in deliverBy. <br /> In case if the customer's scheduled `deliverBy` date falls under Holiday, then `useBestNextDate` will be used by our system. Then, we will mark the second option and deliver the same.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DeliverBy** | **DateTime** | Delivery date is the target delivery date for the shipment. When specified, the API returns only those rate quotes that can commit to delivering the shipment on or before this date. The value must be in the YYYY-MM-DD format. | [optional] 
**UseBestNextDate** | **bool** | When set to true, if the specified Deliver By date falls on a holiday, the API will return rate quotes based on the next available business day delivery commitment. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

