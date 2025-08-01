# com.pitneybowes.api360.Model.ReprintShipment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CorrelationId** | **string** | Key assigned by the shipping system to the transaction. | [optional] 
**Size** | **string** | Defines the label size of the Shipment, e.g., Shipping Label having Doc Size (8&#39; X 11&#39;). | [optional] 
**Type** | **string** | Defines the type of the Shipment, e.g., Shipping Label. | [optional] 
**Format** | **string** | Defines the type of the shipment which is printed. For example, Shipping label prints in PDF form. | [optional] 
**FromAddress** | [**ReprintShipmentFromAddress**](ReprintShipmentFromAddress.md) |  | [optional] 
**Parcel** | [**ReprintShipmentParcel**](ReprintShipmentParcel.md) |  | [optional] 
**ParcelTrackingNumber** | **string** | The Tracking number given to the Parcel for tracking purpose. | [optional] 
**Rate** | [**ReprintShipmentRate**](ReprintShipmentRate.md) |  | [optional] 
**ShipmentId** | **string** | A unique identifier associated with Shipment ID, which is used for Reprint and Cancel. | [optional] 
**ShipmentOptions** | [**ReprintShipmentShipmentOptions**](ReprintShipmentShipmentOptions.md) |  | [optional] 
**ToAddress** | [**ReprintShipmentToAddress**](ReprintShipmentToAddress.md) |  | [optional] 
**SoldToAddress** | [**SoldToAddress**](SoldToAddress.md) |  | [optional] 
**AdditionalAddresses** | [**List&lt;AdditionalAddressesInner&gt;**](AdditionalAddressesInner.md) | A list of additional addresses associated with the shipment.  - Each object includes an address and its designated type, such as BROKER or other parties involved in customs or shipping processes.  - Additional address could be domestic or International both.   | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

