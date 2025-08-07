# com.pitneybowes.api360.Model.ShipmentDomesticByCarrier

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromAddress** | [**FromAddressV2**](FromAddressV2.md) |  | 
**ToAddress** | [**ToAddressV2**](ToAddressV2.md) |  | 
**ParcelType** | **string** | Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection.&lt;br /&gt; ParcelType can have categories like Package, Envelopes, Paks, Boxes, Tube, etc. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;  | 
**RateShopBy** | **string** | RateShop, which is attached to an Enterprise or Location, is done through three approaches: by Carrier, by RateGroup, and by Ruleset. &lt;br /&gt;  Through Carrier, customers can choose the carriers as per requirement, based on which services, parcel types, and special services can be selected, and RateShop is done. &lt;br /&gt; Through RateGroup, customers can select the RateGroup, which has been divided into two categories: Cheapest (w.r.t. price) and Fastest (w.r.t. delivery hours). &lt;br /&gt; Through Ruleset, customers can define the Condition/rule for selecting carriers and their services, so they do not need to worry for Rate Shopping every time they create Shipment. For example, For a particular location, they can set one definite carrier, or apply RateGroup - Cheapest/Fastest. Similarly, for a particular amount like below $1000 Dollars, they can select a definite carrier service, based on RateGroup. | 
**LabelSize** | **string** | Defines the label size of the Shipment, that is, the Shipping Label is available in different Doc Size. &lt;br /&gt; &#x60;Max length &#x3D; 10&#x60; | 
**LabelType** | **string** | Defines the type of the Shipment. QR_CODE supported for carrier USPS only as of now. &lt;br /&gt; &#x60;Max length &#x3D; 14&#x60; | 
**LabelFormat** | **string** | \&quot;Defines the file/format in which the label is printed.&lt;br /&gt; For ZPL2, DOC_4X6 will be supported, while for PDF, both the sizes are supported. QR_CODE can be generated only in GIF format. &#x60;Max length &#x3D; 14&#x60;\&quot;  | 
**SoldToAddress** | [**SoldToAddressV2**](SoldToAddressV2.md) |  | [optional] 
**AdditionalAddresses** | [**List&lt;AdditionalAddressesInner&gt;**](AdditionalAddressesInner.md) | A list of additional addresses associated with the shipment.  - Each object includes an address and its designated type, such as BROKER or other parties involved in customs or shipping processes.  - Additional address could be domestic or International both.   | [optional] 
**AltReturnAddress** | [**ShipmentDomesticByCarrierAltReturnAddress**](ShipmentDomesticByCarrierAltReturnAddress.md) |  | [optional] 
**Parcel** | [**ParcelV2**](ParcelV2.md) |  | [optional] 
**ByCarrier** | [**ByCarrierV2**](ByCarrierV2.md) |  | [optional] 
**ShipmentOptions** | [**ShipmentDomesticByCarrierShipmentOptions**](ShipmentDomesticByCarrierShipmentOptions.md) |  | [optional] 
**CarrierPayments** | [**List&lt;CarrierPaymentsInner&gt;**](CarrierPaymentsInner.md) | Defines how carrier charges are billed to a third party. Use this field to specify  account and charge type details for transportation and/or duties and taxes. This  field is optional and currently supported for FedEx, UPS, and DHL Express.  - If no &#x60;party&#x60; (who will pay for TRANSPORTATION_CHARGES or duties and taxes) is explicitly specified during shipment creation, the charges will automatically default to the sender (shipper). To direct charges to a different party, the appropriate bill-to details must be provided in the request.  | [optional] 
**DocTab** | [**ShipmentDomesticByCarrierDocTab**](ShipmentDomesticByCarrierDocTab.md) |  | [optional] 
**SpecialServices** | [**List&lt;SpecialService&gt;**](SpecialService.md) | It provides a carrier based special or extra service, which also varies as per selected service and parcel type. User can override this value by defining it at shipment level.&lt;br/&gt;  &gt; Provide either the specialserviceId or the specialservice objects such as deliveryConfirmation, handling, insurance and returnOptions, but not both.  | [optional] 
**DeliveryConfirmation** | [**ShipmentDomesticByCarrierDeliveryConfirmation**](ShipmentDomesticByCarrierDeliveryConfirmation.md) |  | [optional] 
**Handling** | [**ShipmentDomesticByCarrierHandling**](ShipmentDomesticByCarrierHandling.md) |  | [optional] 
**Insurance** | [**ShipmentDomesticByCarrierInsurance**](ShipmentDomesticByCarrierInsurance.md) |  | [optional] 
**References** | [**ReferenceV2**](ReferenceV2.md) |  | [optional] 
**Metadata** | [**List&lt;MilitaryMailShipmentsRequestV2MetadataInner&gt;**](MilitaryMailShipmentsRequestV2MetadataInner.md) | Additional metadata that needs to be stored for this shipment can be added here.&lt;br /&gt; For now, &#39;Cost Account Name&#39; is supported. | [optional] 
**ContentType** | **string** | Specifies how the label content is encoded.&lt;br/&gt; URL is supported for &#x60;PDF&#x60; and &#x60;GIF&#x60;. &lt;br/&gt; BASE64 is supported for &#x60;ZPL2&#x60;, &#x60;PNG&#x60;, and &#x60;GIF&#x60;.  | [optional] 
**PrinterAliasName** | **string** | Refers to a printer connected (directly or via network) to a computer. &#x60;Max length &#x3D; 60&#x60; | [optional] 
**DateOfShipment** | **DateTime** | The date when shipment is created/shipped. The format of the Date is YYYY-MM-DD. | [optional] 
**DeliveryOption** | [**MilitaryMailShipmentsRequestV2DeliveryOption**](MilitaryMailShipmentsRequestV2DeliveryOption.md) |  | [optional] 
**ReturnOptions** | [**ShipmentDomesticByCarrierReturnOptions**](ShipmentDomesticByCarrierReturnOptions.md) |  | [optional] 
**Customs** | [**ShipmentDomesticByCarrierCustoms**](ShipmentDomesticByCarrierCustoms.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

