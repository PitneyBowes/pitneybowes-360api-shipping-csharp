# com.pitneybowes.api360.Model.RateShopResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromAddress** | [**RateShopResponseFromAddress**](RateShopResponseFromAddress.md) |  | [optional] 
**Parcel** | [**RateShopResponseParcel**](RateShopResponseParcel.md) |  | [optional] 
**Rates** | [**List&lt;RateShopResponseRatesInner&gt;**](RateShopResponseRatesInner.md) | It displays all available rates for each services | [optional] 
**ToAddress** | [**RateShopResponseToAddress**](RateShopResponseToAddress.md) |  | [optional] 
**IsHazmat** | **bool** | isHazmat if set to true,only services which support Hazardous material shipment would be visible in the response | [optional] 
**Errors** | [**List&lt;RateShopResponseErrorsInner&gt;**](RateShopResponseErrorsInner.md) | It display any error while getting rates | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

