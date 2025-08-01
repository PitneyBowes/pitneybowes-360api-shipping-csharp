# com.pitneybowes.api360.Model.ErrCoversheetRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of the coversheet. | 
**CarrierAccountId** | **string** | A unique identifier assigned to the specific carrier account. Its value can be referred from the response of &#x60;Get Carrier Accounts&#x60; API. | 
**ParcelType** | **string** | Type of the parcel, such as Letter or Envelope. | 
**ServiceId** | **string** | The unique identifier given to the carrier specific service, such as First Class Mail (FCM). It can be referred from response of &#x60;Get Services&#x60; API. | 
**SpecialServices** | [**List&lt;ErrCoversheetRequestSpecialServicesInner&gt;**](ErrCoversheetRequestSpecialServicesInner.md) | List of special services applied. | 
**FromAddress** | [**ErrCoversheetRequestFromAddress**](ErrCoversheetRequestFromAddress.md) |  | 
**Parcel** | [**ErrCoversheetRequestParcel**](ErrCoversheetRequestParcel.md) |  | 
**ToAddress** | [**ErrCoversheetRequestToAddress**](ErrCoversheetRequestToAddress.md) |  | 
**Format** | **string** | The file format of the coversheet. Default format is &#x60;PDF&#x60;. | [optional] 
**Size** | **string** | The size of the coversheet. Default size is &#x60;10&#x60;. | [optional] 
**ShipmentOptions** | [**ErrCoversheetRequestShipmentOptions**](ErrCoversheetRequestShipmentOptions.md) |  | [optional] 
**Metadata** | [**List&lt;MultipieceShipmentRequestMetadataInner&gt;**](MultipieceShipmentRequestMetadataInner.md) | Optional metadata for the shipment. | [optional] 
**ShippingReferences** | [**ErrCoversheetRequestShippingReferences**](ErrCoversheetRequestShippingReferences.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

