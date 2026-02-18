# com.pitneybowes.api360.Model.ShipmentDomesticByExternalSystemCode

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromAddress** | [**FromAddressV2**](FromAddressV2.md) |  | 
**ToAddress** | [**ToAddressV2**](ToAddressV2.md) |  | 
**RateShopBy** | **string** | Specifies that shipment creation uses a predefined configuration from an external system. When externalSystemCode is selected, the system retrieves carrier, account, service, and parcel details based on the external system codes provided in the request.  | 
**LabelSize** | **string** | Defines the label size of the Shipment, that is, the Shipping Label is available in different Doc Size. &lt;br /&gt; &#x60;Max length &#x3D; 10&#x60; | 
**LabelType** | **string** | Defines the type of the Shipment. QR_CODE supported for carrier USPS only as of now. &lt;br /&gt; &#x60;Max length &#x3D; 14&#x60; | 
**LabelFormat** | **string** | \&quot;Defines the file/format in which the label is printed.&lt;br /&gt; For ZPL2, DOC_4X6 will be supported, while for PDF, both the sizes are supported. QR_CODE can be generated only in GIF format. &#x60;Max length &#x3D; 14&#x60;\&quot;  | 
**Parcel** | [**ParcelV2**](ParcelV2.md) |  | [optional] 
**ByExternalSystemCode** | [**ByExternalSystemCodeV2**](ByExternalSystemCodeV2.md) |  | [optional] 
**SpecialServices** | [**List&lt;SpecialService&gt;**](SpecialService.md) | It provides a carrier based special or extra service, which also varies as per selected service and parcel type. User can override this value by defining it at shipment level.&lt;br/&gt;  &gt; Provide either the specialserviceId or the specialservice objects such as deliveryConfirmation, handling, insurance and returnOptions, but not both.  | [optional] 
**ShipmentOptions** | [**ShipmentDomesticByExternalSystemCodeShipmentOptions**](ShipmentDomesticByExternalSystemCodeShipmentOptions.md) |  | [optional] 
**References** | [**ReferenceV2**](ReferenceV2.md) |  | [optional] 
**Metadata** | [**List&lt;MilitaryMailShipmentsRequestV2MetadataInner&gt;**](MilitaryMailShipmentsRequestV2MetadataInner.md) | Additional metadata that needs to be stored for this shipment can be added here.&lt;br /&gt; Supported values are [Cost Account Name, Cost Account Id, Cost Account Code](/openapi/costaccount/operation/addCostAccount/), [Account Code](/openapi/billingcodes/operation/createAccountCode/) and [Company Code](/openapi/billingcodes/operation/createCompanyCode/). &lt;br/&gt;If Cost Account metadata is provided, all three Cost Account fields are required. | [optional] 
**ContentType** | **string** | Specifies how the label content is encoded.&lt;br/&gt; URL is supported for &#x60;PDF&#x60; and &#x60;GIF&#x60;. &lt;br/&gt; BASE64 is supported for &#x60;ZPL2&#x60;, &#x60;PNG&#x60;, and &#x60;GIF&#x60;.  | [optional] 
**DateOfShipment** | **DateTime** | The date when shipment is created/shipped. The format of the Date is YYYY-MM-DD. | [optional] 
**DeliveryOption** | [**MilitaryMailShipmentsRequestV2DeliveryOption**](MilitaryMailShipmentsRequestV2DeliveryOption.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

