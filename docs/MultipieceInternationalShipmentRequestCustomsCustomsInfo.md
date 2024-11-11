# com.pitneybowes.api360.Model.MultipieceInternationalShipmentRequestCustomsCustomsInfo
This is additional customs information required along with item details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReasonForExport** | **string** | The reason the commodity is being exported. | 
**CustomsDeclaredValue** | **decimal** | Item value in mentioned currencyCode | 
**CurrencyCode** | **string** | The currency used for declared value. Use three uppercase letters, per ISO 4217 | 
**EELPFC** | **string** | A number provided by the Automated Export System (AES). This is required if the item is valued at more than $2,500 USD per Schedule B export codes. | [optional] 
**CertificateNumber** | **string** | The certificate number associated with the commodity. | [optional] 
**Comments** | **string** | Free-form comments regarding the exported shipment. | [optional] 
**FromCustomsReference** | **string** | Free-form reference information provided by the requestor of the shipment. Depending on the carrier this information may or may not be rendered on the customs documents. | [optional] 
**ImporterCustomsReference** | **string** | A reference number used by the importer, such as a VAT number, PO number, or insured number. | [optional] 
**InvoiceNumber** | **string** | The commercial invoice number assigned by the exporter. | [optional] 
**LicenseNumber** | **string** | The export license number associated with the commodity. | [optional] 
**SdrValue** | **decimal** | When an international parcel is insured, the insured value must be expressed in Special Drawing Rights values. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

