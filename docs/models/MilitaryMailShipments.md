# com.pitneybowes.api360.Model.MilitaryMailShipments
For domestic USPS Military Mail shipments (APO/FPO/DPO Address), `customs` object is required if any of the following are true:   - Weight is greater than or equal to 16 ounces.   - Weight is less than 16 ounces AND shipment contains items other than documents. Specify the items in customs.customsInfo.reasonForExport.   - Shipment uses Priority Mail Express (EM). A customs form is always required for Priority Mail Express. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Size** | **string** | Defines the label size of the Shipment, e.g., Shipping Label having Doc Size (4&#39; X 6&#39; or 8.5&#39; X 11&#39;). | 
**Type** | **string** | Defines the type of the Shipment, e.g., Shipping Label.QR_CODE supported for carrier USPS only as of now. | 
**FromAddress** | [**MilitaryMailShipmentsFromAddress**](MilitaryMailShipmentsFromAddress.md) |  | 
**Parcel** | [**MilitaryMailShipmentsParcel**](MilitaryMailShipmentsParcel.md) |  | 
**CarrierAccountId** | **string** |  A unique identifier associated with the Carrier account used by client users during shipment process. | 
**ParcelType** | **string** | &gt;-Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection. It has categories like Package, Envelopes, Paks, Boxes, Tube, defined per specific carrier and used in abbreviated form, e.g., FRPKG, LGENV, TUBE, PKG. | 
**ServiceId** | **string** | &gt;-A unique identifier given to the carrier-specific service. This is required for creating a shipment, while it is optional for rating a parcel. | 
**ToAddress** | [**MilitaryMailShipmentsToAddress**](MilitaryMailShipmentsToAddress.md) |  | 
**Format** | **string** | Defines the type of the shipment label that is printed. QR_CODE can be generated only in GIF format. | [optional] 
**ContentType** | **string** | Specifies how the label content is encoded.&lt;br/&gt; URL is supported for &#x60;PDF&#x60; and &#x60;GIF&#x60;. &lt;br/&gt; BASE64 is supported for &#x60;ZPL2&#x60;, &#x60;PNG&#x60;, and &#x60;GIF&#x60;.  | [optional] 
**DateOfShipment** | **DateOnly** | The date when shipment is created/shipped. The format of the Date is YYYY-MM-DD. | [optional] 
**SpecialServices** | [**List&lt;SpecialService&gt;**](SpecialService.md) |  It provides a carrier-service based special or extra service. | [optional] 
**ShipmentOptions** | [**ShipmentOptions**](ShipmentOptions.md) |  | [optional] 
**CarrierPayments** | [**List&lt;CarrierPaymentsInner&gt;**](CarrierPaymentsInner.md) | Defines how carrier charges are billed to a third party. Use this field to specify  account and charge type details for transportation and/or duties and taxes. This  field is optional and currently supported for FedEx, UPS, and DHL Express.  - If no &#x60;party&#x60; (who will pay for TRANSPORTATION_CHARGES or duties and taxes) is explicitly specified during shipment creation, the charges will automatically default to the sender (shipper). To direct charges to a different party, the appropriate bill-to details must be provided in the request.  | [optional] 
**Metadata** | [**List&lt;ShipmentDomesticMetadataInner&gt;**](ShipmentDomesticMetadataInner.md) | Additional metadata that needs to be stored for this shipment can be added here. For now, &#39;Cost Account Name&#39; is supported. | [optional] 
**SoldToAddress** | [**SoldToAddress**](SoldToAddress.md) |  | [optional] 
**Customs** | [**MilitaryMailShipmentsCustoms**](MilitaryMailShipmentsCustoms.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

