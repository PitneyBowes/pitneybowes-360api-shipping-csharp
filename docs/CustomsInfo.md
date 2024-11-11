# com.pitneybowes.api360.Model.CustomsInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReasonForExport** | **string** | &gt;-The reason the commodity is being exported. Valid values are: Valid Values : [GIFT COMMERCIAL_SAMPLE MERCHANDISE DOCUMENTS RETURNED_GOODS OTHER SOLD NOT_SOLD] | [optional] 
**CurrencyCode** | **string** | &gt;-The type of currency used for the monetary values in this API request. Use three uppercase letters, per ISO 4217. For example, use USD for US Dollars, CAD for Canadian Dollars, and EUR for Euros. | 
**EELPFC** | **string** | &gt;- A number provided by the Automated Export System (AES). This field is required if the item is valued at more than $2,500 USD per Schedule B export codes. | [optional] 
**CertificateNumber** | **string** | The certificate number associated with the commodity. | [optional] 
**Comments** | **string** | &gt;-Free form comments regarding the exported shipment entered by the shipper. | [optional] 
**FromCustomsReference** | **string** | &gt;-Free form reference information provided by the requestor of the shipment. Depending on the carrier this information may or may not be rendered on the customs documents. | [optional] 
**ImporterCustomsReference** | **string** | &gt;- A reference number used by the importer, such as a VAT number, PO number, or insured number. &#x60;Shipments to the EU&#x60; : Merchants shipping to the European Union (EU) from outside the EU must provide a VAT or IOSS number. Enter the number in this field and specify the reference type in the importerCustomsReferenceType field. | [optional] 
**InvoiceNumber** | **string** | The commercial invoice number assigned by the exporter. It is rquired for DHL Express | [optional] 
**LicenseNumber** | **string** | The export license number associated with the commodity. | [optional] 
**DeclarationStatement** | **string** | This is declaration statement from the Shipper for the items being shipped. | [optional] 
**ImporterCustomsReferenceType** | **string** | &gt;-A reference type used by the importer to determine the type of importerCustomsReference. Valid Values are TAX_CODE, IMPORTER_CODE, VAT_NUMBER, IOSS_NUMBER. | [optional] 
**InsuredAmount** | **double** | Enter the insurance fee, if applicable. | [optional] 
**InsuredNumber** | **string** | &gt;- If the sender wishes to insure the contents, they complete an insurance receipt and affix the insured numbered label to the package. The insured number label is what this field represents. | [optional] 
**SdrValue** | **double** | &gt;-When an international parcel is insured, the insured value must be expressed in Special Drawing Rights values. E.g. $100 USD &#x3D; 66.87 SDR. | [optional] 
**TermsOfSale** | **string** | Three-digit codes describing Terms of sale required for DHL Express shipments. Terms of sale is some sort of agreement between a buyer and seller which serves the purpose of creating uniform expectations between them. Possible values are- CFR (description- Cost and Freight), CIF (description- Cost, Insurance and Freight), CIP (description- Carriage and Insurance Paid To), DAF (description- Delivered at Frontier), DAP (description- Delivered At Place), DAT (description- Delivered At Terminal), DDP (description- Delivered Duty Paid), DDU (description- Delivered Duty Unpaid), DEQ (description- Delivery ex Quay), DES (description- Delivered ex Ship), DPU (description- Delivered At Place Unloaded), EXW (description- Ex Works), FAS (description- FAS Free Alongside Ship), FCA (description- Free Carrier), FOB (description- FOB Free On Board) | [optional] 
**RecipientTaxType** | **string** | The tax type to choose for recipient. | [optional] 
**RecipientTaxID** | **string** | The respective taxID for the taxType chosen | [optional] 
**SenderTaxType** | **string** | The tax type to choose for recipient. | [optional] 
**SenderTaxID** | **string** | The respective taxID for the taxType chosen | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

