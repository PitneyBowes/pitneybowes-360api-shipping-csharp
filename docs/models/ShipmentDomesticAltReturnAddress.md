# com.pitneybowes.api360.Model.ShipmentDomesticAltReturnAddress
This is an optional field. if a package shipped from Location_A to Location_B needs to return to Location_C. The alternate address will be printed on the label. Use this object to specify a return address different from the fromAddress. Supported by FedEx, UPS, and Purolator.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AddressLine1** | **string** | The first line of the alternate return address, such as a street address or PO Box. | [optional] 
**AddressLine2** | **string** | The addressLine2 contains Street address or Landmark (if any). | [optional] 
**AddressLine3** | **string** | The addressLine3 contains P.O. Box (if any) near the address. | [optional] 
**Company** | **string** | The name of the company for the alternate return address, in case if the recipient&#39;s address is not residential. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;. | [optional] 
**Email** | **string** | The email address of the recipient. It can be person&#39;s email address or company email address (for non-residential). | [optional] 
**Residential** | **bool** | The specified address can be Residential or Official. In case if the address is Residential, the boolean value will be &#39;true&#39;, else it will take &#39;false&#39;. | [optional] 
**CityTown** | **string** | The city or town for the alternate return address. | [optional] 
**CountryCode** | **string** | The two-character ISO Code of the source country from this ISO country list.  The country in which the address is located. Use ISO 3166-1 Alpha-2 standard values. For best results this should be included, especially if the country name does not appear in any of the unparsedAddressLines. | [optional] 
**Name** | **string** | The name of the recipient or organization for the alternate return address. | [optional] 
**Phone** | **string** | The phone number associated with the alternate return address. | [optional] 
**PostalCode** | **string** | The postal or ZIP code for the alternate return address. | [optional] 
**StateProvince** | **string** | The 2-letter state or province code for the alternate return address. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

