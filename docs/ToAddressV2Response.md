# com.pitneybowes.api360.Model.ToAddressV2Response
The complete address of the Sender.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the Sender to which this address points. | [optional] 
**AddressLine1** | **string** | The addressLine1 contains the Flat number, Building or Apartment Name/number (if any) or company name (if not residential) of the Sender.  | [optional] 
**CityTown** | **string** | The name of the city or town the Sender&#39;s address belongs to.  | [optional] 
**StateProvince** | **string** | The name of the State or Province the Sender belongs to. It is the &#x60;2-letter&#x60; State or ProvinceCode for US or Canadian address(es). &lt;br /&gt; Below is the hyperlink for CA country that will navigate to its Province/State Codes page. Similarly, respective country users can check for their country- State/Province codes. &lt;br /&gt; Please switch to the &#x60;Search&#x60; tab, select &#x60;Country codes&#x60; radio button, enter the required country name or country code, and then click &#x60;SEARCH&#x60; button.  | [optional] 
**PostalCode** | **string** | The Postal Code or ZIP Code of the address. &lt;br /&gt; For CA addresses, use a &#x60;six-character&#x60; alphanumeric string Postal Code in this format: &#39;A1A 1A1&#39;. &lt;br /&gt; While for US addresses, use either the &#x60;5-digit&#x60; or &#x60;9-digit&#x60; ZIP Code in one of the following formats: &#39;12345&#39; or &#39;12345-6789&#39;.  | [optional] 
**CountryCode** | **string** | The country in which the sender&#39;s address is located. The value will be the two-character ISO Code of the country from the ISO country list. &lt;br /&gt; Use ISO 3166-1 Alpha-2 standard values. For best results this should be included, especially if the country name does not appear in any of the unparsedAddressLines. &lt;br /&gt; Below is the hyperlink, please select &#x60;Country codes&#x60; and then click &#x60;SEARCH&#x60; button.  | [optional] 
**Company** | **string** | The name of the company, in case if the sender address is not residential.  | [optional] 
**Phone** | **string** | This is sender&#39;s phone number. Enter the digits with or without spaces or hyphens. . | [optional] 
**Email** | **string** | This must be sender&#39;s valid email. Email is required if the customer is using GoFor Carrier.   | [optional] 
**Residential** | **bool** | The specified address can be Residential or Official. In case if the address is Residential, the boolean value will be &#39;true&#39;, else it will take &#39;false&#39;. | [optional] 
**IsPOBox** | **bool** | Checks if the specified address has the PO Box. In case if Yes, the boolean value will be &#39;true&#39;, else it will take &#39;false&#39;. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

