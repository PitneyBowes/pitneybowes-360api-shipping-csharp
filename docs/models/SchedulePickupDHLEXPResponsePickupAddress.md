# com.pitneybowes.api360.Model.SchedulePickupDHLEXPResponsePickupAddress

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the person or entity at the pickup address. | [optional] 
**AddressLine1** | **string** | First line of the address where the pickup will occur. | [optional] 
**CityTown** | **string** | The city or town where the pickup address is located. | [optional] 
**StateProvince** | **string** | The state or province of the pickup address. For a US or Canadian address, it is the 2-letter state or province code. | [optional] 
**PostalCode** | **string** | The postal or ZIP code for the pickup address. For US addresses, use either the 5-digit or 9-digit ZIP Code in one of the following formats: &#39;12345&#39; or &#39;12345-6789&#39;. If you use a different format, such as 12345- or 123451234, will receive an error. | [optional] 
**CountryCode** | **string** | The two-letter country code for the pickup address. | [optional] 
**Phone** | **string** | The contact phone number for the pickup location. | [optional] 
**Company** | **string** | The name of the company at the pickup address, if the recipient address is not residential. | [optional] 
**Email** | **string** | The email address associated with the pickup location. | [optional] 
**Residential** | **bool** | Indicates whether the pickup address is a residential location. Set to &#39;false&#39; for commercial addresses. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

