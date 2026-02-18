# com.pitneybowes.api360.Model.CarrierFacilityResponse
Response payload containing the original request context and suggested facilities that match the search criteria. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | [**FacilityAddress**](FacilityAddress.md) |  | [optional] 
**Carrier** | **string** | The carrier used for the facility lookup. | [optional] 
**CarrierFacilityOptions** | [**List&lt;CarrierFacilityOptions&gt;**](CarrierFacilityOptions.md) | Filters the types of facilities returned. Each object in the array is a name-value pair that specifies a carrier facility option. Each object contains a &#x60;name&#x60; field (the option) and a &#x60;value&#x60; field (the option value). Both fields take strings.  | [optional] 
**CarrierFacilitySuggestions** | [**List&lt;CarrierFacilitySuggestion&gt;**](CarrierFacilitySuggestion.md) | List of facilities that match the search criteria  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

