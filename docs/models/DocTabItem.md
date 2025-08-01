# com.pitneybowes.api360.Model.DocTabItem
This field will either be part of the request or response payload or will be marked as a custom field. We need to pass this field only if we need to print it on the label.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | This is a mandatory field. It will be displayed on the label | [optional] 
**Value** | **string** | If the field is part of a request or response, the value will be picked up from there. In the case of custom fields, the user-provided value will be printed. | [optional] 
**Row** | **int** | Row Position of the Item. The min value is 1. | [optional] 
**Column** | **int** | Column Position of the Item. The min value is 1. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

