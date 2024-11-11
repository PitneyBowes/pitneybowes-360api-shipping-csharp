# com.pitneybowes.api360.Model.SingleRateResponseFromAddress
Sender address details

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | The addressLine1 can contain the Flat number, Building or Apartment Name/number (if any) or company name (if not residential). | [optional] 
**AddressLine2** | **string** | The addressLine2 contains Street address or Landmark (if any). | [optional] 
**AddressLine3** | **string** | The addressLine3 contains P.O.Box (if any) near the address. | [optional] 
**CityTown** | **string** | The name of the city or town to where the sender&#39;s address belongs. | [optional] 
**Company** | **string** | This indicates the name of the company, in case if the sender address is not residential. | [optional] 
**CountryCode** | **string** | This indicates the two-character ISO code of the source country from the ISO country list. | [optional] 
**Name** | **string** | Name of the sender to which this address points. | [optional] 
**PostalCode** | **string** | The postal code or ZIP code of the address. For US addresses, use either the 5-digit or 9-digit ZIP code in one of the following formats: &#39;12345&#39; or &#39;12345-6789&#39;. If you use a different format, such as 12345- or 123451234, will receive an error. | [optional] 
**StateProvince** | **string** | The State or Province of the address. For a US or Canadian address, it is the 2-letter state or province code.  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

