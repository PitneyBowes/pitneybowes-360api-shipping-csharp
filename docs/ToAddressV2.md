# com.pitneybowes.api360.Model.ToAddressV2
The complete address of the Recipient or Department (in case if the address is not pointed to any individual recipient).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the Recipient. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60; | 
**AddressLine1** | **string** | The addressLine1 contains the Flat number, Building or Apartment Name/number (if any) or company name (if not residential) of the Recipient. &lt;br /&gt; &#x60;Max length &#x3D; 35&#x60;. | 
**CityTown** | **string** | The name of the city or town the Recipient belongs to. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;. | 
**StateProvince** | **string** | The name of the State or Province the Sender belongs to. It is the &#x60;2-letter&#x60; State or Province Code for US or Canadian address(es). &lt;br /&gt; Below is the hyperlink for CA country that will navigate to its Province/State Codes page. Similarly, respective country users can check for their country- State/Province codes. &lt;br /&gt; Please switch to the &#x60;Search&#x60; tab, select &#x60;Country codes&#x60; radio button, enter the required country name or country code, and then click &#x60;SEARCH&#x60; button . &lt;br /&gt; &#x60;Max length &#x3D; 2&#x60; | 
**PostalCode** | **string** | The Postal Code or ZIP Code of the address.&lt;br /&gt; For CA addresses, use a &#x60;six-character&#x60; alphanumeric string Postal Code in this format: &#39;A1A 1A1&#39;.&lt;br /&gt; While for US addresses, use either the &#x60;5-digit&#x60; or &#x60;9-digit&#x60; ZIP Code in one of the following formats: &#39;12345&#39; or &#39;12345-6789&#39;.&lt;br /&gt; &#x60;Max length &#x3D; 30&#x60; | 
**CountryCode** | **string** | The country in which the recipient&#39;s address is located. The value will be the two-character ISO Code of the country from the ISO country list. &lt;br /&gt; Use ISO 3166-1 Alpha-2 standard values. For best results this should be included, especially if the country name does not appear in any of the unparsedAddressLines. &lt;br /&gt; Below is the hyperlink, please select &#x60;Country codes&#x60; and then click &#x60;SEARCH&#x60; button. &lt;br /&gt; &#x60;Max length &#x3D; 10&#x60; | 
**Company** | **string** | The name of the company, in case if the recipient address is not residential. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;. | [optional] 
**Phone** | **string** | This is Recipient&#39;s phone number. Enter the digits with or without spaces or hyphens. &lt;br /&gt; &#x60;Max length &#x3D; 15&#x60;. | 
**Email** | **string** | This must be recipient&#39;s valid email. Email is required if the customer is using GoFor Carrier. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;  | [optional] 
**Residential** | **bool** | The specified address can be Residential or Official. In case if the address is Residential, the boolean value will be &#39;true&#39;, else it will take &#39;false&#39;. | [optional] 
**IsPOBox** | **bool** | Checks if the specified address has the PO Box. In case if Yes, the boolean value will be &#39;true&#39;, else it will take &#39;false&#39;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)
