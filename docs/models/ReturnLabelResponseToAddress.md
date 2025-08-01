# com.pitneybowes.api360.Model.ReturnLabelResponseToAddress

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | The addressLine1 can contain the Flat number, Building or Apartment Name/number (if any) or company name (if not residential). | 
**AddressLine2** | **string** | The addressLine2 contains Street address or Landmark (if any). | [optional] 
**AddressLine3** | **string** | The addressLine3 contains P.O. Box (if any) near the address. | [optional] 
**Company** | **string** | The name of the company, in case if the receiver address is not residential. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;. | [optional] 
**Email** | **string** | Email id | [optional] 
**CityTown** | **string** | The name of the city or town to where the address belongs. | [optional] 
**CountryCode** | **string** | The two-character ISO Code of the destination country from this ISO country list. The country in which the address is located. Use ISO 3166-1 Alpha-2 standard values. For best results this should be included, especially if the country name does not appear in any of the unparsedAddressLines. | [optional] 
**Name** | **string** | Name of the recipient to which this address points. | [optional] 
**Phone** | **string** | This is recipient&#39;s phone number. Enter the digits with or without spaces or hyphens. The maximum limit of characters for Phone number is 10 digits.  | [optional] 
**PostalCode** | **string** | The Postal Code or ZIP Code of the address. For US addresses, use either the 5-digit or 9-digit ZIP Code in one of the following formats: &#39;12345&#39; or &#39;12345-6789&#39;. If you use a different format, such as 12345- or 123451234, will receive an error. | [optional] 
**StateProvince** | **string** | The State or Province of the address. For a US or Canadian address, it is the 2-letter state or province code.  | [optional] 
**Residential** | **bool** | The specified address can be Residential or Official. In case if the address is Residential, the boolean value will be &#39;true&#39;, else it will take &#39;false&#39;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

