# com.pitneybowes.api360.Model.MultipieceShipmentInternationalResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | Key assigned by the shipping system to the transaction. | [optional] 
**LabelLayout** | [**List&lt;MultipieceShipmentResponseLabelLayoutInner&gt;**](MultipieceShipmentResponseLabelLayoutInner.md) | Defines the layout and content details of the shipping label. | [optional] 
**FromAddress** | [**MultipieceShipmentInternationalResponseFromAddress**](MultipieceShipmentInternationalResponseFromAddress.md) |  | [optional] 
**MultiPieceRates** | [**List&lt;MultipieceShipmentInternationalResponseMultiPieceRatesInner&gt;**](MultipieceShipmentInternationalResponseMultiPieceRatesInner.md) | Details of the rates for multipiece shipments, including carrier information and parcel-specific charges. | [optional] 
**ParcelTrackingNumber** | **string** | The tracking number assigned to the entire shipment. | [optional] 
**ShipmentId** | **string** | A unique identifier for the shipment. | [optional] 
**ShipmentOptions** | [**MultipieceShipmentResponseShipmentOptions**](MultipieceShipmentResponseShipmentOptions.md) |  | [optional] 
**CarrierPayments** | [**List&lt;CarrierPaymentsInner&gt;**](CarrierPaymentsInner.md) | Defines how carrier charges are billed to a third party. Use this field to specify  account and charge type details for transportation and/or duties and taxes. This  field is optional and currently supported for FedEx, UPS, and DHL Express.  - If no &#x60;party&#x60; (who will pay for TRANSPORTATION_CHARGES or duties and taxes) is explicitly specified during shipment creation, the charges will automatically default to the sender (shipper). To direct charges to a different party, the appropriate bill-to details must be provided in the request.  | [optional] 
**ToAddress** | [**MultipieceShipmentInternationalResponseToAddress**](MultipieceShipmentInternationalResponseToAddress.md) |  | [optional] 
**AltReturnAddress** | [**MultipieceShipmentRequestAltReturnAddress**](MultipieceShipmentRequestAltReturnAddress.md) |  | [optional] 
**AdditionalAddresses** | [**List&lt;AdditionalAddressesInner&gt;**](AdditionalAddressesInner.md) | A list of additional addresses associated with the shipment.  - Each object includes an address and its designated type, such as BROKER or other parties involved in customs or shipping processes.  - Additional address could be domestic or International both.   | [optional] 
**Customs** | [**MultipieceShipmentInternationalResponseCustoms**](MultipieceShipmentInternationalResponseCustoms.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

