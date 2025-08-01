# com.pitneybowes.api360.Model.DomesticShipmentResponseV2

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | Key assigned by the shipping system to the transaction. | [optional] 
**ShipmentId** | **string** | The shipmentId, a unique identifier for an individual Shipment. | [optional] 
**ParcelTrackingNumber** | **string** | The Tracking number given to the Parcel for tracking purpose. | [optional] 
**LabelLayout** | [**List&lt;DomesticShipmentResponseV2LabelLayoutInner&gt;**](DomesticShipmentResponseV2LabelLayoutInner.md) |  | [optional] 
**Parcel** | [**ParcelV2**](ParcelV2.md) |  | [optional] 
**Rate** | [**DomesticShipmentResponseV2Rate**](DomesticShipmentResponseV2Rate.md) |  | [optional] 
**References** | [**ReferenceV2**](ReferenceV2.md) |  | [optional] 
**PrintStatus** | **string** | Status of the Printed Label. | [optional] 
**PrintError** | [**DomesticShipmentResponseV2PrintError**](DomesticShipmentResponseV2PrintError.md) |  | [optional] 
**FromAddress** | [**FromAddressV2Response**](FromAddressV2Response.md) |  | [optional] 
**ToAddress** | [**ToAddressV2Response**](ToAddressV2Response.md) |  | [optional] 
**SoldToAddress** | [**SoldToAddress**](SoldToAddress.md) |  | [optional] 
**AdditionalAddresses** | [**List&lt;AdditionalAddressesInner&gt;**](AdditionalAddressesInner.md) | A list of additional addresses associated with the shipment.  - Each object includes an address and its designated type, such as BROKER or other parties involved in customs or shipping processes.  - Additional address could be domestic or International both.   | [optional] 
**ShipmentOptions** | [**ReprintShipmentShipmentOptions**](ReprintShipmentShipmentOptions.md) |  | [optional] 
**CarrierPayments** | [**List&lt;CarrierPaymentsInner&gt;**](CarrierPaymentsInner.md) | Defines how carrier charges are billed to a third party. Use this field to specify  account and charge type details for transportation and/or duties and taxes. This  field is optional and currently supported for FedEx, UPS, and DHL Express.  - If no &#x60;party&#x60; (who will pay for TRANSPORTATION_CHARGES or duties and taxes) is explicitly specified during shipment creation, the charges will automatically default to the sender (shipper). To direct charges to a different party, the appropriate bill-to details must be provided in the request.  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

