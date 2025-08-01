# com.pitneybowes.api360.Model.MultipieceShipmentInternationalRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Size** | **string** | Defines the label size of the Shipment, e.g., Shipping Label having Doc Size ( 8&#39; X 11&#39;). It supports the document sizes as per the eligible carrier size support. | [optional] 
**Format** | **string** | Defines the type of the multipiece shipment label that is printed.&lt;br&gt;PDF supports content type URL.&lt;br&gt; ZPL2 supports content type BASE64. | [optional] 
**Type** | **string** | Defines the type of the Shipment, e.g., Shipping Label. | [optional] 
**ContentType** | **string** | Specifies how the label content is encoded.&lt;br/&gt; URL is supported for &#x60;PDF&#x60; . &lt;br/&gt; BASE64 is supported for &#x60;ZPL2&#x60;.  | [optional] 
**FromAddress** | [**MultipieceShipmentInternationalRequestFromAddress**](MultipieceShipmentInternationalRequestFromAddress.md) |  | [optional] 
**CarrierAccountId** | **string** |  A unique identifier associated with the Carrier account used by client users during shipment process. | [optional] 
**ServiceId** | **string** | &gt;-A unique identifier given to the carrier-specific service. This is required for creating a shipment, while it is optional for rating a parcel. | [optional] 
**ShipmentOptions** | [**MultipieceShipmentInternationalRequestShipmentOptions**](MultipieceShipmentInternationalRequestShipmentOptions.md) |  | [optional] 
**CarrierPayments** | [**List&lt;CarrierPaymentsInner&gt;**](CarrierPaymentsInner.md) | Defines how carrier charges are billed to a third party. Use this field to specify  account and charge type details for transportation and/or duties and taxes. This  field is optional and currently supported for FedEx, UPS, and DHL Express.  - If no &#x60;party&#x60; (who will pay for TRANSPORTATION_CHARGES or duties and taxes) is explicitly specified during shipment creation, the charges will automatically default to the sender (shipper). To direct charges to a different party, the appropriate bill-to details must be provided in the request.  | [optional] 
**Metadata** | [**List&lt;MultipieceShipmentRequestMetadataInner&gt;**](MultipieceShipmentRequestMetadataInner.md) | An array containing custom metadata for the shipment. | [optional] 
**MultiPieceParcels** | [**List&lt;MultipieceShipmentInternationalRequestMultiPieceParcelsInner&gt;**](MultipieceShipmentInternationalRequestMultiPieceParcelsInner.md) | Details of each parcel in the shipment. | [optional] 
**ToAddress** | [**MultipieceShipmentInternationalRequestToAddress**](MultipieceShipmentInternationalRequestToAddress.md) |  | [optional] 
**AdditionalAddresses** | [**List&lt;AdditionalAddressesInner&gt;**](AdditionalAddressesInner.md) | A list of additional addresses associated with the shipment.  - Each object includes an address and its designated type, such as BROKER or other parties involved in customs or shipping processes.  - Additional address could be domestic or International both.   | [optional] 
**AltReturnAddress** | [**MultipieceShipmentRequestAltReturnAddress**](MultipieceShipmentRequestAltReturnAddress.md) |  | [optional] 
**Customs** | [**MultipieceShipmentInternationalRequestCustoms**](MultipieceShipmentInternationalRequestCustoms.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

