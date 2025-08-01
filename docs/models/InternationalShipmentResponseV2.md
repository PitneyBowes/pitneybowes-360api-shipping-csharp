# com.pitneybowes.api360.Model.InternationalShipmentResponseV2

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | Key assigned by the shipping system to the transaction. | [optional] 
**ShipmentId** | **string** | A unique identifier shipment tracking number. | [optional] 
**ParcelTrackingNumber** | **string** | The unique tracking number assigned to the parcel for tracking purposes. | [optional] 
**LabelLayout** | [**List&lt;InternationalShipmentResponseV2LabelLayoutInner&gt;**](InternationalShipmentResponseV2LabelLayoutInner.md) | Details about the shipping label generated. | [optional] 
**Parcel** | [**InternationalShipmentResponseV2Parcel**](InternationalShipmentResponseV2Parcel.md) |  | [optional] 
**Rate** | [**InternationalShipmentResponseV2Rate**](InternationalShipmentResponseV2Rate.md) |  | [optional] 
**References** | [**InternationalShipmentResponseV2References**](InternationalShipmentResponseV2References.md) |  | [optional] 
**Print** | [**InternationalShipmentResponseV2Print**](InternationalShipmentResponseV2Print.md) |  | [optional] 
**FromAddress** | [**FromAddressV2internationalResponse**](FromAddressV2internationalResponse.md) |  | [optional] 
**ToAddress** | [**ToAddressV2internationalResponse**](ToAddressV2internationalResponse.md) |  | [optional] 
**SoldToAddress** | [**SoldToAddressV2**](SoldToAddressV2.md) |  | [optional] 
**AdditionalAddresses** | [**List&lt;AdditionalAddressesInner&gt;**](AdditionalAddressesInner.md) | A list of additional addresses associated with the shipment.  - Each object includes an address and its designated type, such as BROKER or other parties involved in customs or shipping processes.  - Additional address could be domestic or International both.   | [optional] 
**AltReturnAddress** | [**ShipmentInternationalAltReturnAddress**](ShipmentInternationalAltReturnAddress.md) |  | [optional] 
**ShipmentOptions** | [**InternationalShipmentResponseV2ShipmentOptions**](InternationalShipmentResponseV2ShipmentOptions.md) |  | [optional] 
**CarrierPayments** | [**List&lt;CarrierPaymentsInner&gt;**](CarrierPaymentsInner.md) | Defines how carrier charges are billed to a third party. Use this field to specify  account and charge type details for transportation and/or duties and taxes. This  field is optional and currently supported for FedEx, UPS, and DHL Express.  - If no &#x60;party&#x60; (who will pay for TRANSPORTATION_CHARGES or duties and taxes) is explicitly specified during shipment creation, the charges will automatically default to the sender (shipper). To direct charges to a different party, the appropriate bill-to details must be provided in the request.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

