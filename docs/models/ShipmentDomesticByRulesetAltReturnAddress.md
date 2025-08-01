# com.pitneybowes.api360.Model.ShipmentDomesticByRulesetAltReturnAddress
This is an optional field. if a package shipped from Location_A to Location_B needs to return to Location_C. The alternate address will be printed on the label. Use this object to specify a return address different from the fromAddress. Supported by FedEx, UPS, and Purolator.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | The first line of the alternate return address, such as a street address or PO Box. | [optional] 
**AddressLine2** | **string** | The addressLine2 contains Street address or Landmark (if any). | [optional] 
**AddressLine3** | **string** | The addressLine3 contains P.O. Box (if any) near the address. | [optional] 
**Company** | **string** | The name of the company, in case if the alternate return address is not residential. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;. | [optional] 
**Email** | **string** | Specifies the valid email address associated with the alternate return address. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;  | [optional] 
**CityTown** | **string** | The city or town for the alternate return address. | [optional] 
**CountryCode** | **string** | The two-letter ISO country code for the alternate return address. | [optional] 
**Name** | **string** | The name of the recipient or organization for the alternate return address. | [optional] 
**Phone** | **string** | The phone number associated with the alternate return address. | [optional] 
**PostalCode** | **string** | The postal or ZIP code for the alternate return address. | [optional] 
**StateProvince** | **string** | The 2-letter state or province code for the alternate return address. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

