# com.pitneybowes.api360.Model.Address

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | The addressLine1 can contain the Flat number, Building or Apartment Name/number (if any) or company name (if not residential). | 
**AddressLine2** | **string** | The addressLine2 contains Street address or Landmark (if any). | [optional] 
**AddressLine3** | **string** | The addressLine3 contains P.O.Box (if any) near the address. | [optional] 
**CityTown** | **string** |  This indicates the city or town in the Address. | [optional] 
**Company** | **string** |  This indicates the name of the company. | [optional] 
**CountryCode** | **string** | This indicates the two-character ISO code of the country. | 
**Email** | **string** | The email address of the Recipient or Department where the delivery address is pointed to. | [optional] 
**Name** | **string** | The first and last name of the Recipient or Department. | [optional] 
**Phone** | **string** | &gt;-The phone number. Enter the digits with or without spaces or hyphens. When used for Pickups, the maximum is 10 digits. | [optional] 
**PostalCode** | **string** | The postal code or ZIP code of the Address. | 
**Residential** | **bool** | &gt;-Indicates whether this is a residential address. Pitney Bowes recommends including this parameter to improve address verification. | [optional] 
**StateProvince** | **string** | &gt;-The state or province. For a US or Canadian address, use the 2-letter state or province code. | 
**Status** | **string** | &gt;- This field applies to the Validate Address and Suggest Addresses APIs. The field indicates whether the submitted address is valid and whether the API made changes to the address. Possible values are: &#x60;VALIDATED_CHANGED&#x60;: The address is valid, but the API made changes to improve the address. For example, if an address has a valid street number and street name (e.g. “100 Elm”) but is missing the street suffix (e.g. “St”), the API would add the suffix. &#x60;VALIDATED_AND_NOT_CHANGED&#x60;: The address is valid. The API made no changes. | [optional] 
**TaxId** | **string** | &gt;-Tax identification number (TIN) or Employer Identification number (EIN) or GST or VAT number or RFC or EORI. | [optional] 
**TaxIdType** | **string** | &gt;-Tax identification Type, valid values are EIN or GST or VAT or RFC or EORI. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

