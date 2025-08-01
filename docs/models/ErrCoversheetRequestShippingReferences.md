# com.pitneybowes.api360.Model.ErrCoversheetRequestShippingReferences
Contains additional reference fields that can be passed with an ERR request (single piece or batch). While USPS only accepts a single reference, these fields are used for internal tracking, exports, and reporting.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Reference1** | **string** | Primary reference field, printed on the coversheet under the label &#x60;Shipper Ref&#x60;. If &#x60;reference1&#x60; and &#x60;printCustomMessage&#x60; are both supplied, they will be concatenated and printed on the coversheet under the label &#x60;Shipper Ref&#x60;. | [optional] 
**Reference2** | **string** | Secondary reference field. | [optional] 
**Reference3** | **string** | Tertiary reference field. | [optional] 
**Reference4** | **string** | Additional reference field. | [optional] 
**ShipperReference** | **string** | Reference provided by the shipper. | [optional] 
**TransportationReference** | **string** | Reference related to transportation. | [optional] 
**ShipperNotes** | **string** | Optional notes from the shipper. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

