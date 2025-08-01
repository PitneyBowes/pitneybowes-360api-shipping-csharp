# com.pitneybowes.api360.Model.SoldToAddressV2
Billing address of the buyer responsible for the shipment payment. It can be domestic or international address.  - If the importer is the same as the final recipient, the `toAddress` and `soldToAddress` must match. - If the importer is different from the final recipient, enter the importer address in the `soldToAddress` and enter the final recipient's address in the `toAddress`. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | Primary street address of the billing entity. | [optional] 
**AddressLine2** | **string** | Additional address information such as apartment, suite, or unit number. | [optional] 
**AddressLine3** | **string** | Optional extra address details. | [optional] 
**Company** | **string** | The name of the company associated with the SoldTo address. | [optional] 
**Name** | **string** | The contact person&#39;s full name for the billing entity. | [optional] 
**Phone** | **string** | Phone number of the SoldTo entity. | [optional] 
**Email** | **string** | Email address of the SoldTo entity. | [optional] 
**Residential** | **bool** | Indicates whether the SoldTo address is a residential location (true/false). | [optional] 
**CityTown** | **string** | City or town of the billing address. | [optional] 
**StateProvince** | **string** | State or province of the billing address. | [optional] 
**PostalCode** | **string** | Postal or ZIP code of the billing address. | [optional] 
**CountryCode** | **string** | Two-letter country code of the billing address (ISO 3166-1 alpha-2). | [optional] 
**TaxId** | **string** | The Tax Identification Number (TIN). TIN Number is supported for FedEx as of now.&lt;br /&gt; &#x60;Max character length &#x3D; 18&#x60;.  - &#x60;EIN&#x60;, &#x60;VAT&#x60;, &#x60;GST&#x60;, and &#x60;IOSS&#x60; are mapped to &#x60;BUSINESS_NATIONAL&#x60;. - &#x60;EORI&#x60; is mapped to &#x60;BUSINESS_UNION&#x60;. - &#x60;RFC&#x60; with a length of 12 characters is mapped to &#x60;BUSINESS_NATIONAL&#x60;. - &#x60;RFC&#x60; with a length of 13 characters is mapped to &#x60;PERSONAL_NATIONAL&#x60;.  | [optional] 
**TaxIdType** | **string** | Specifies the type of tax identification being provided. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

