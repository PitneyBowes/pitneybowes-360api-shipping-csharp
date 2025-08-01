# com.pitneybowes.api360.Model.ErrCoversheetResponseFromAddress

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the person or entity. | [optional] 
**AddressLine1** | **string** | First line of the address. | [optional] 
**AddressLine2** | **string** | The addressLine2 contains Street address or Landmark (if any). | [optional] 
**AddressLine3** | **string** | The addressLine3 contains P.O. Box (if any) near the address. | [optional] 
**CityTown** | **string** | City or town of the address. | [optional] 
**StateProvince** | **string** | State or province of the address. It is the &#x60;2-letter&#x60; State or Province Code for US address(es). | [optional] 
**PostalCode** | **string** | The Postal Code or ZIP Code of the address. &lt;br /&gt; For US addresses, use only &#x60;9-digit&#x60; ZIP Code. | [optional] 
**CountryCode** | **string** | Country code of the address. | [optional] 
**Phone** | **string** | Phone number associated with the address. | [optional] 
**Company** | **string** | The name of the company, in case if the sender address is not residential. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;. | [optional] 
**Email** | **string** | This must be sender&#39;s valid email. Email is required if the customer is using GoFor Carrier. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;  | [optional] 
**InductionPostalCode** | **string** | The postal code where the shipment is tendered to the carrier. If an induction postal code is specified in the \&quot;fromAddress\&quot;, it will be used for rate calculations and determining manifest eligibility instead of the standard postal code. If not specified, the postal code from the \&quot;fromAddress\&quot; will be used. | [optional] 
**Residential** | **bool** | The specified address can be Residential or Official. In case if the address is Residential, the boolean value is &#39;true&#39;, else it is &#39;false&#39;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

