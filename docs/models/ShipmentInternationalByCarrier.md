# com.pitneybowes.api360.Model.ShipmentInternationalByCarrier

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromAddress** | [**ShipmentInternationalByCarrierFromAddress**](ShipmentInternationalByCarrierFromAddress.md) |  | 
**ToAddress** | [**ShipmentInternationalByCarrierToAddress**](ShipmentInternationalByCarrierToAddress.md) |  | 
**ParcelType** | **string** | Type of parcel, such as Package, Envelope, Box, etc. | 
**RateShopBy** | **string** | Determines the rate shopping method. | 
**ByCarrier** | [**ByCarrierV2**](.md) |  | 
**LabelSize** | **string** | Defines the label size of the Shipment, that is, the Shipping Label is available in different Doc Size. &lt;br /&gt; &#x60;Max length &#x3D; 10&#x60; | 
**LabelType** | **string** | Defines the type of the Shipment. &lt;br /&gt; &#x60;Max length &#x3D; 14&#x60; | 
**LabelFormat** | **string** | Defines the file/format in which the label is printed.&lt;br /&gt; For ZPL2, DOC_4X6 will be supported, while for PDF, both the sizes are supported. &#x60;Max length &#x3D; 14&#x60; | 
**Customs** | [**ShipmentInternationalByCarrierCustoms**](ShipmentInternationalByCarrierCustoms.md) |  | 
**SoldToAddress** | [**SoldToAddressV2**](SoldToAddressV2.md) |  | [optional] 
**AdditionalAddresses** | [**List&lt;AdditionalAddressesInner&gt;**](AdditionalAddressesInner.md) | A list of additional addresses associated with the shipment.  - Each object includes an address and its designated type, such as BROKER or other parties involved in customs or shipping processes.  - Additional address could be domestic or International both.   | [optional] 
**AltReturnAddress** | [**ShipmentInternationalAltReturnAddress**](ShipmentInternationalAltReturnAddress.md) |  | [optional] 
**Parcel** | [**ParcelV2**](.md) |  | [optional] 
**ShipmentOptions** | [**ShipmentInternationalByCarrierShipmentOptions**](ShipmentInternationalByCarrierShipmentOptions.md) |  | [optional] 
**CarrierPayments** | [**List&lt;CarrierPaymentsInner&gt;**](CarrierPaymentsInner.md) | Defines how carrier charges are billed to a third party. Use this field to specify  account and charge type details for transportation and/or duties and taxes. This  field is optional and currently supported for FedEx, UPS, and DHL Express.  - If no &#x60;party&#x60; (who will pay for TRANSPORTATION_CHARGES or duties and taxes) is explicitly specified during shipment creation, the charges will automatically default to the sender (shipper). To direct charges to a different party, the appropriate bill-to details must be provided in the request.  | [optional] 
**SpecialServices** | [**List&lt;SpecialService&gt;**](SpecialService.md) | It provides a carrier based special or extra service, which also varies as per selected service and parcel type. User can override this value by defining it at shipment level.&lt;br/&gt;  &gt; Provide either the specialserviceId or the specialservice objects such as deliveryConfirmation, handling, insurance and returnOptions, but not both.  | [optional] 
**References** | [**ReferenceV2**](.md) |  | [optional] 
**Metadata** | [**List&lt;MilitaryMailShipmentsRequestV2MetadataInner&gt;**](MilitaryMailShipmentsRequestV2MetadataInner.md) | Additional metadata that needs to be stored for this shipment can be added here.&lt;br /&gt; For now, &#39;Cost Account Name&#39; is supported. | [optional] 
**ContentType** | **string** | Specifies how the label content is encoded.&lt;br/&gt; URL is supported for &#x60;PDF&#x60; and &#x60;GIF&#x60;. &lt;br/&gt; BASE64 is supported for &#x60;ZPL2&#x60;, &#x60;PNG&#x60;, and &#x60;GIF&#x60;.  | [optional] 
**PrinterAliasName** | **string** | Refers to a printer connected (directly or via network) to a computer. &#x60;Max length &#x3D; 60&#x60; | [optional] 
**DateOfShipment** | **DateTime** | The date when shipment is created/shipped. The format of the Date is YYYY-MM-DD. | [optional] 
**DeliveryOption** | [**ShipmentInternationalByCarrierDeliveryOption**](ShipmentInternationalByCarrierDeliveryOption.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

