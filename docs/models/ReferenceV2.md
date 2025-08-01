# com.pitneybowes.api360.Model.ReferenceV2
References are tags or information that is printed on Shipping Label based on the customer's requirement. <br /> Reference Fields can have values/indication like department name, invoice no., package description, purchase order no., carrier note, cost account no., transportation no., or PO no., print custom message etc.<br /> Each of the reference field can have only one indication/value. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reference1** | **string** | Reference 1 can have one of the above-indicated values/information, which is printed on Label. For FedEx, it is a Reference number in the invoice. For USPS, it is a print custom message that will be printed vertically at the top of the label. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;. | [optional] 
**Reference2** | **string** | Reference 2 can have other details as indicated in the example values above. This is also printed on Label. For FedEx, this is the department. For USPS, it is a print custom message that will be printed horizontally at the bottom of the label. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;. | [optional] 
**Reference3** | **string** | Reference 3 can have the information which were not fulfilled in Ref1 and Ref2. For FedEx, this is the invoice number. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;. | [optional] 
**Reference4** | **string** | Reference 4 can have more information which were not provided in Ref1, Ref2, or Ref3. For FedEx, this is the PO number. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;. | [optional] 
**PoNumber** | **string** | The Purchase Order Number. For FedEx, the PO number is passed in the Reference 2 field. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;. | [optional] 
**Department** | **string** | The department of the Recipient.For FedEx, the Department is passed in reference4 field. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;. | [optional] 
**AdditionalReference1** | **string** | Additional Reference is hardly used, but sender can mention anything as per requirement, just for Recipient&#39;s information. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;. | [optional] 
**AdditionalReference2** | **string** | Any tags or information that to be shown to Recipient, can be mentioned by Sender, which is not indicated on AdditionalReference1 field, e.g., PO No, Order No. etc.&lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

