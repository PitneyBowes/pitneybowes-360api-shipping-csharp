# com.pitneybowes.api360.Model.CarrierFacilitySuggestion
A suggested carrier facility that matches the search criteria. 

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Address** | [**FacilityAddress**](FacilityAddress.md) |  | [optional] 
**CarrierFacilityAttributes** | [**List&lt;CarrierFacilitySuggestionCarrierFacilityAttributesInner&gt;**](CarrierFacilitySuggestionCarrierFacilityAttributesInner.md) | List of facility attributes that describe the services available at this location.  This array is populated only when: - You did not specify a FACILITY_TYPE_SERVICE value in the request, and - A FACILITY_TYPE_SERVICE value applies for the facility.  Each object in the array is a name–value pair describing a facility service. Both &#x60;name&#x60; and &#x60;value&#x60; are strings.  Note: If you specified a FACILITY_TYPE_SERVICE value in the request, this array does not populate in the response.  | [optional] [readonly] 
**FacilityHours** | [**List&lt;FacilityHours&gt;**](FacilityHours.md) | Days and hours of operation for the facility. Each object in the array defines the hours for a specific day of the week.  | [optional] 
**FacilityParking** | **string** | The type of parking available at the facility. Values include: - NONE - LOT - STREET  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

