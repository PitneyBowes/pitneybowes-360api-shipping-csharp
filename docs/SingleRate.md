# com.pitneybowes.api360.Model.SingleRate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DateOfShipment** | **string** | This defines the date of the Shipment in the format YYYY:MM:DD, required for future shipment rating | [optional] 
**FromAddress** | [**SingleRateFromAddress**](SingleRateFromAddress.md) |  | 
**Parcel** | [**SingleRateParcel**](SingleRateParcel.md) |  | 
**CarrierAccounts** | **List&lt;string&gt;** |  This provides a single carrier account Id in case of single rate request. It can be referred from response of &#x60;Get Carrier Accounts&#x60; API. | 
**ParcelType** | **string** | Parcel Type its value can be referred from response of &#x60;Get Parcel Types&#x60; API. | 
**ParcelId** | **string** | &gt;-Parcel Id is optional and required to be given in case of branded parcels which have brandedDimension and/or brandedWeight. If parcel has brandedDimension, in that case user need not to pass dimensionUnit and dimension details(length, width and height) in the parcel object. And if brandedWeight is also available for the parcel then in that case weightUnit and weight need not to be passed  in parcel object   | [optional] 
**ServiceId** | **string** | Service to be used for rating, it can be referred from response of &#x60;Get Services&#x60; API | 
**SpecialServices** | [**List&lt;SpecialService&gt;**](SpecialService.md) | Special services to be used for rating, it can be referred from response of &#x60;Get Special Services&#x60; API | [optional] 
**ToAddress** | [**SingleRateToAddress**](SingleRateToAddress.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

