# com.pitneybowes.api360.Model.SoldToAddress
Billing address of the buyer responsible for the shipment payment. It can be domestic or international address. This is a required field for carrier UPS. - If the importer is the same as the final recipient, the `toAddress` and `soldToAddress` must match. - If the importer is different from the final recipient, enter the importer address in the `soldToAddress` and enter the final recipient's address in the `toAddress`. 

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

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

