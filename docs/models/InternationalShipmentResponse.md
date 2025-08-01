# com.pitneybowes.api360.Model.InternationalShipmentResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | Key assigned by the shipping system to the transaction. | [optional] 
**Size** | **string** | Defines the label size of the Shipment, e.g., Shipping Label having Doc Size (8&#39; X 11&#39;). | [optional] 
**Type** | **string** | Defines the type of the Shipment, e.g., Shipping Label. | [optional] 
**Format** | **string** | Defines the type of the shipment which is printed. For example, Shipping label prints in PDF form. | [optional] 
**FromAddress** | [**InternationalShipmentResponseFromAddress**](InternationalShipmentResponseFromAddress.md) |  | [optional] 
**AltReturnAddress** | [**InternationalShipmentResponseAltReturnAddress**](InternationalShipmentResponseAltReturnAddress.md) |  | [optional] 
**Parcel** | [**ReturnLabelParcel**](ReturnLabelParcel.md) |  | [optional] 
**ParcelTrackingNumber** | **string** | The Tracking number given to the Parcel for tracking purpose. | [optional] 
**Rate** | [**InternationalShipmentResponseRate**](InternationalShipmentResponseRate.md) |  | [optional] 
**ShipmentId** | **string** | A unique identifier associated with the Shipment. | [optional] 
**ShipmentOptions** | [**GetAllShipmentsDataInnerShipmentOptions**](GetAllShipmentsDataInnerShipmentOptions.md) |  | [optional] 
**CarrierPayments** | [**List&lt;CarrierPaymentsInner&gt;**](CarrierPaymentsInner.md) | Defines how carrier charges are billed to a third party. Use this field to specify  account and charge type details for transportation and/or duties and taxes. This  field is optional and currently supported for FedEx, UPS, and DHL Express.  - If no &#x60;party&#x60; (who will pay for TRANSPORTATION_CHARGES or duties and taxes) is explicitly specified during shipment creation, the charges will automatically default to the sender (shipper). To direct charges to a different party, the appropriate bill-to details must be provided in the request.  | [optional] 
**ToAddress** | [**ReprintShipmentToAddress**](ReprintShipmentToAddress.md) |  | [optional] 
**Customs** | [**InternationalShipmentResponseCustoms**](InternationalShipmentResponseCustoms.md) |  | [optional] 
**SoldToAddress** | [**SoldToAddress**](SoldToAddress.md) |  | [optional] 
**AdditionalAddresses** | [**List&lt;AdditionalAddressesInner&gt;**](AdditionalAddressesInner.md) | A list of additional addresses associated with the shipment.  - Each object includes an address and its designated type, such as BROKER or other parties involved in customs or shipping processes.  - Additional address could be domestic or International both.   | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

