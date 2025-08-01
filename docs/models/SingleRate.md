# com.pitneybowes.api360.Model.SingleRate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromAddress** | [**SingleRateFromAddress**](SingleRateFromAddress.md) |  | 
**Parcel** | [**SingleRateParcel**](SingleRateParcel.md) |  | 
**CarrierAccounts** | **List&lt;string&gt;** |  It provides a single carrier account Id in case of single rate request. It can be referred from response of &#x60;Get Carrier Accounts&#x60; API. | 
**ParcelType** | **string** | Parcel Type its value can be referred from response of &#x60;Get Parcel Types&#x60; API. | 
**ServiceId** | **string** | Service to be used for rating, it can be referred from response of &#x60;Get Services&#x60; API | 
**ToAddress** | [**SingleRateToAddress**](SingleRateToAddress.md) |  | 
**SpecialServices** | [**List&lt;SpecialService&gt;**](SpecialService.md) | Special services to be used for rating, it can be referred from response of &#x60;Get Special Services&#x60; API | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

