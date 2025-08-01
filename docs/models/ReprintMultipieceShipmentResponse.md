# com.pitneybowes.api360.Model.ReprintMultipieceShipmentResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | Key assigned by the shipping system to the transaction. | [optional] 
**LabelLayout** | [**List&lt;MultipieceShipmentResponseLabelLayoutInner&gt;**](MultipieceShipmentResponseLabelLayoutInner.md) | Defines the layout and content details of the shipping label. | [optional] 
**FromAddress** | [**ReprintMultipieceShipmentResponseFromAddress**](ReprintMultipieceShipmentResponseFromAddress.md) |  | [optional] 
**MultiPieceRates** | [**List&lt;ReprintMultipieceShipmentResponseMultiPieceRatesInner&gt;**](ReprintMultipieceShipmentResponseMultiPieceRatesInner.md) | Details of the rates for multipiece shipments, including carrier information and parcel-specific charges. | [optional] 
**ParcelTrackingNumber** | **string** | The tracking number assigned to the entire shipment. | [optional] 
**ShipmentId** | **string** | A unique identifier for the shipment. | [optional] 
**ShipmentOptions** | [**ReprintMultipieceShipmentResponseShipmentOptions**](ReprintMultipieceShipmentResponseShipmentOptions.md) |  | [optional] 
**ToAddress** | [**ReprintMultipieceShipmentResponseToAddress**](ReprintMultipieceShipmentResponseToAddress.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

