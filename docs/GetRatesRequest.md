# com.pitneybowes.api360.Model.GetRatesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateOfShipment** | **string** | This defines the date of the Shipment in the format YYYY:MM:DD.,required for future shipment rating | [optional] 
**FromAddress** | [**RateShopFromAddress**](RateShopFromAddress.md) |  | 
**Parcel** | [**RateShopParcel**](RateShopParcel.md) |  | 
**CarrierAccounts** | **List&lt;string&gt;** | This provide one or more carrier accounts Ids for rate shop. It can be referred from &#x60;Get Carrier Accounts&#x60; API | 
**ParcelType** | **string** | Parcel Type required for rating, it&#39;s value can be referred from response of &#x60;Get Parcel Types&#x60; API | 
**ParcelId** | **string** | &gt;-Parcel Id is optional and required to be given in case of branded parcels which have brandedDimension and/or brandedWeight. If parcel has brandedDimension, in that case user need not to pass dimensionUnit and dimension details(length, width and height) in the parcel object. And if brandedWeight is also available for the parcel then in that case weightUnit and weight need not to be passed  in parcel object | [optional] 
**ServiceId** | **string** | Service to be used for rating, it can be referred from response of &#x60;Get Services&#x60; API | 
**SpecialServices** | [**List&lt;SpecialService&gt;**](SpecialService.md) | Special services to be used for rating, it can be referred from response of &#x60;Get Special Services&#x60; API | [optional] 
**ToAddress** | [**SingleRateToAddress**](SingleRateToAddress.md) |  | 
**IsHazmat** | **bool** | isHazmat if set to true,only services which support Hazardous material shipment would be visible in the response | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

