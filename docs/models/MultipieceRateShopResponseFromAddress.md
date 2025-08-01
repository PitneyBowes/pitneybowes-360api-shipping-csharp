# com.pitneybowes.api360.Model.MultipieceRateShopResponseFromAddress
Details of the sender's address.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | The addressLine1 can contain the Flat number, Building or Apartment Name/number (if any) or company name (if not residential). | [optional] 
**AddressLine2** | **string** | The addressLine2 contains Street address or Landmark (if any). | [optional] 
**AddressLine3** | **string** | The addressLine3 contains P.O. Box (if any) near the address. | [optional] 
**CityTown** | **string** | The name of the city or town to where the address belongs. | [optional] 
**StateProvince** | **string** | The State or Province of the address. For a US or Canadian address, it is the 2-letter state or province code. | [optional] 
**PostalCode** | **string** | The Postal Code or ZIP Code of the address. For US addresses, use either the 5-digit or 9-digit ZIP Code in one of the following formats: &#39;12345&#39; or &#39;12345-6789&#39;. | [optional] 
**CountryCode** | **string** | The two-character ISO Code of the source country from the ISO country list. The country in which the address is located. | [optional] 
**Company** | **string** | The company name associated with the sender&#39;s address. | [optional] 
**Name** | **string** | Name of the sender. | [optional] 
**Phone** | **string** | Phone number of the sender. | [optional] 
**Email** | **string** | Email address of the sender. | [optional] 
**Residential** | **bool** | Indicates if the Recipient&#39;s address is residential (&#x60;true&#x60; or &#x60;false&#x60;). | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

