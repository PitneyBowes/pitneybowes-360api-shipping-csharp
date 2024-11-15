# com.pitneybowes.api360.Model.ShipmentDomesticByCarrier

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromAddress** | [**FromAddressV2**](FromAddressV2.md) |  | 
**ToAddress** | [**ToAddressV2**](ToAddressV2.md) |  | 
**Parcel** | [**ParcelV2**](ParcelV2.md) |  | [optional] 
**ParcelType** | **string** | Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection.&lt;br /&gt; ParcelType can have categories like Package, Envelopes, Paks, Boxes, Tube, etc. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60;  | 
**RateShopBy** | **string** | RateShop, which is attached to an Enterprise or Location, is done through three approaches: by Carrier, by RateGroup, and by Ruleset. &lt;br /&gt;  Through Carrier, customers can choose the carriers as per requirement, based on which services, parcel types, and special services can be selected, and RateShop is done. &lt;br /&gt; Through RateGroup, customers can select the RateGroup, which has been divided into two categories: Cheapest (w.r.t. price) and Fastest (w.r.t. delivery hours). &lt;br /&gt; Through Ruleset, customers can define the Condition/rule for selecting carriers and their services, so they do not need to worry for Rate Shopping every time they create Shipment. For example, For a particular location, they can set one definite carrier, or apply RateGroup - Cheapest/Fastest. Similarly, for a particular amount like below $1000 Dollars, they can select a definite carrier service, based on RateGroup. | 
**ByCarrier** | [**ByCarrierV2**](ByCarrierV2.md) |  | [optional] 
**ShipmentOptions** | [**ShipmentDomesticByCarrierShipmentOptions**](ShipmentDomesticByCarrierShipmentOptions.md) |  | [optional] 
**DocTab** | [**ShipmentDomesticByCarrierDocTab**](ShipmentDomesticByCarrierDocTab.md) |  | [optional] 
**DeliveryConfirmation** | **string** | Indicates the supporting special service or document as an evidence of shipment delivery.  For the delivery confirmation, user can select any of the following special services, but they may vary as per the carrier selection. &lt;br /&gt;   - Signature Required/ Indirect Signature Required : SIG   - Signed Hard Copy: SIGHC   - Delivery confirmation: DEL_CON   - Proof of age required (18 years) Adult Signature Required: ADULT_SIG   - Proof of age required (19 years): ADULT_SIG_19   - No Signature Required: NO_SIG   - Direct Signature Required: DIRECT_SIG   - Chain of Signature: COS       Carrier specific options:   - UPS supports *SIG and ADULT_SIG*.    - FedEx supports *SIG, ADULT_SIG, NO_SIG, and DIRECT_SIG*.   - Purolator supports *ADULT_SIG, NO_SIG, and COS*.   - GoFor supports *SIG*.   - CPC supports *SIG, SIGHC, DEL_CON, ADULT_SIG, ADULT_SIG_19, and NO_SIG*.      | [optional] 
**Handling** | **string** | Few shipments need a special handling, and the reason can be fragile items or highly secured shipments. There might be other case scenarios. In a simple term, this field defines shipment handling, which provides users a capability to select handling options. &lt;br /&gt; User can select any of the following handling options (special services), but they may vary as per the carrier selection.   - Hold For Pickup: HOLD   - Saturday Delivery: SAT_DELIVERY   - UPS Premium Care: PREM_CARE   - Direct Delivery Only: DIRECT   - Additional Handling: ADD_HDL       Carrier specific options:   - UPS supports all handling options mentioned above.    - FedEx supports *HOLD, SAT_DELIVERY, and ADD_HDL*.   - Purolator supports *HOLD, SAT_DELIVERY, and ADD_HDL*.     | [optional] 
**Insurance** | **string** | Indicates the insurance coverage, which is selected by users while create shipment - rate shopping. User can select below-mentioned special service for insurance:    - Declared Value Surcharge: INS      Carrier specific options:   - UPS, FedEx, Purolator, and CPC support special service *INS*.     | [optional] 
**References** | [**ReferenceV2**](ReferenceV2.md) |  | [optional] 
**Metadata** | [**List&lt;ShipmentDomesticByCarrierMetadataInner&gt;**](ShipmentDomesticByCarrierMetadataInner.md) | Additional metadata that needs to be stored for this shipment can be added here.&lt;br /&gt; For now, &#39;Cost Account Name&#39; is supported. | [optional] 
**LabelSize** | **string** | Defines the label size of the Shipment, that is, the Shipping Label is available in different Doc Size. &lt;br /&gt; &#x60;Max length &#x3D; 10&#x60; | 
**LabelType** | **string** | Defines the type of the Shipment.  &lt;br /&gt; &#x60;Max length &#x3D; 14&#x60; | 
**LabelFormat** | **string** | Defines the file/format in which the label is printed.&lt;br /&gt; For ZPL2, DOC_4X6 will be supported, while for PDF, both the sizes are supported. &#x60;Max length &#x3D; 14&#x60; | 
**PrinterAliasName** | **string** | Refers to a printer connected (directly or via network) to a computer. &#x60;Max length &#x3D; 60&#x60; | [optional] 
**DateOfShipment** | **DateOnly** | The date when shipment is created/shipped. The format of the Date is YYYY-MM-DD. | [optional] 
**DeliveryOption** | [**ShipmentDomesticByCarrierDeliveryOption**](ShipmentDomesticByCarrierDeliveryOption.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

