# com.pitneybowes.api360.Model.CarrierFacilityRequest
Request payload to locate carrier facilities near a given address. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | [**FacilityAddress**](FacilityAddress.md) |  | 
**Carrier** | **string** | The carrier for which to locate facilities. This operation currently supports searching for USPS facilities.  | 
**CarrierFacilityOptions** | [**List&lt;CarrierFacilityOptions&gt;**](CarrierFacilityOptions.md) | Filters the types of facilities returned. Each object in the array is a name-value pair that specifies a carrier facility option. Each object contains a &#x60;name&#x60; field (the option) and a &#x60;value&#x60; field (the option value). Both fields take strings.      | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

