# com.pitneybowes.api360.Model.MilitaryMailShipmentsRequestV2ReturnOptions
This object defines return shipment options. It should be passed when requesting return labels. Supported only for carriers UPS and FedEx as of now.</br> For UPS, this object is required. </br> For FedEx, this object is optional. </br> Note: The `returnOptions` object must be sent with the `isReturn` query parameter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Specifies the return type. This is the value of special service code for the carrier-supported return service. | 
**InputParameters** | [**List&lt;MilitaryMailShipmentsRequestV2ReturnOptionsInputParametersInner&gt;**](MilitaryMailShipmentsRequestV2ReturnOptionsInputParametersInner.md) | List of input parameters required for return processing. | 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

