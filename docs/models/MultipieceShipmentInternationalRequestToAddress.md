# com.pitneybowes.api360.Model.MultipieceShipmentInternationalRequestToAddress
The recipient's address information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | The addressLine1 can contain the Flat number, Building or Apartment Name/number (if any) or company name (if not residential). | 
**CountryCode** | **string** |  The country in which the address is located. Use ISO 3166-1 Alpha-2 standard values. For best results this should be included, especially if the country name does not appear in any of the unparsedAddressLines. | 
**PostalCode** | **string** | The Postal Code or ZIP Code of the address. For US addresses, use either the 5-digit or 9-digit ZIP Code in one of the following formats: &#39;12345&#39; or &#39;12345-6789&#39;. If you use a different format, such as 12345- or 123451234, will receive an error. | 
**StateProvince** | **string** | The State or Province of the address. For a US or Canadian address, it is the 2-letter state or province code.  | 
**AddressLine2** | **string** | The addressLine2 contains Street address or Landmark (if any). | [optional] 
**AddressLine3** | **string** | The addressLine3 contains P.O. Box (if any) near the address. | [optional] 
**CityTown** | **string** | The name of the city or town to where the address belongs. | [optional] 
**Name** | **string** | Name of the recipient to which this address points. | [optional] 
**Phone** | **string** | This is recipient&#39;s phone number. Enter the digits with or without spaces or hyphens. The maximum limit of characters for Phone number is 10 digits.  | [optional] 
**Company** | **string** | The name of the company, in case if the receiver address is not residential. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;. | [optional] 
**Email** | **string** | This must be recipient&#39;s valid email. Email is required if the customer is using GoFor Carrier. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;  | [optional] 
**Residential** | **bool** | The specified address can be Residential or Official. In case if the address is Residential, the boolean value will be &#39;true&#39;, else it will take &#39;false&#39;. | [optional] 
**TaxId** | **string** | The Tax Identification Number (TIN). TIN Number is supported for FedEx as of now.&lt;br /&gt; &#x60;Max character length &#x3D; 18&#x60;.  - &#x60;EIN&#x60;, &#x60;VAT&#x60;, &#x60;GST&#x60;, and &#x60;IOSS&#x60; are mapped to &#x60;BUSINESS_NATIONAL&#x60;. - &#x60;EORI&#x60; is mapped to &#x60;BUSINESS_UNION&#x60;. - &#x60;RFC&#x60; with a length of 12 characters is mapped to &#x60;BUSINESS_NATIONAL&#x60;. - &#x60;RFC&#x60; with a length of 13 characters is mapped to &#x60;PERSONAL_NATIONAL&#x60;.  | [optional] 
**TaxIdType** | **string** | Specifies the type of tax identification being provided. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

