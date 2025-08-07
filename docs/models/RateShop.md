# com.pitneybowes.api360.Model.RateShop

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromAddress** | [**RateShopFromAddress**](RateShopFromAddress.md) |  | 
**Parcel** | [**RateShopParcel**](RateShopParcel.md) |  | 
**ToAddress** | [**RateShopToAddress**](RateShopToAddress.md) |  | 
**DateOfShipment** | **DateTime** | The date when shipment is created/shipped. The format of the Date is YYYY-MM-DD. | [optional] 
**ParcelType** | **string** | Parcel Type required for rating, it&#39;s value can be referred from response of &#x60;Get Parcel Types&#x60; API | [optional] 
**IsHazmat** | **bool** | isHazmat if set to true, only services which support Hazardous material shipment would be visible in the response | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

