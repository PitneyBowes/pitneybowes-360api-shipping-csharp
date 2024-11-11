# com.pitneybowes.api360.Model.InternationalShipmentResponseCustomsCustomsInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EELPFC** | **string** | A number provided by the Automated Export System (AES). This is required if the item is valued at more than $2,500 USD per Schedule B export codes. | [optional] 
**CertificateNumber** | **string** | The certificate number associated with the commodity. | [optional] 
**Comments** | **string** | Free-form comments regarding the exported shipment. | [optional] 
**CurrencyCode** | **string** | The currency used for declared value. Use three uppercase letters, per ISO 4217. | [optional] 
**FromCustomsReference** | **string** | Free-form reference information provided by the requestor of the shipment. Depending on the carrier this information may or may not be rendered on the customs documents. | [optional] 
**ImporterCustomsReference** | **string** | A reference number used by the importer, such as a VAT number, PO number, or insured number. | [optional] 
**InvoiceNumber** | **string** | The commercial invoice number assigned by the exporter. It is rquired for DHL Express. | [optional] 
**LicenseNumber** | **string** | The export license number associated with the commodity. | [optional] 
**ReasonForExport** | **string** | The reason the commodity is being exported. | [optional] 
**SdrValue** | **decimal** | When an international parcel is insured, the insured value must be expressed in Special Drawing Rights values. | [optional] 
**TermsOfSale** | **string** | Three-digit codes describing Terms of sale required for DHL Express shipments. Terms of sale is some sort of agreement between a buyer and seller which serves the purpose of creating uniform expectations between them. Possible values are- CFR (description- Cost and Freight), CIF (description- Cost, Insurance and Freight), CIP (description- Carriage and Insurance Paid To), DAF (description- Delivered at Frontier), DAP (description- Delivered At Place), DAT (description- Delivered At Terminal), DDP (description- Delivered Duty Paid), DDU (description- Delivered Duty Unpaid), DEQ (description- Delivery ex Quay), DES (description- Delivered ex Ship), DPU (description- Delivered At Place Unloaded), EXW (description- Ex Works), FAS (description- FAS Free Alongside Ship), FCA (description- Free Carrier), FOB (description- FOB Free On Board) | [optional] 
**RecipientTaxType** | **string** | The tax type to choose for recipient. | [optional] 
**RecipientTaxID** | **string** | The respective taxID for the taxType chosen | [optional] 
**SenderTaxType** | **string** | The tax type to choose for recipient. | [optional] 
**SenderTaxID** | **string** | The respective taxID for the taxType chosen | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

