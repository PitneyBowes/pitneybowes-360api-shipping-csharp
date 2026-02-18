# com.pitneybowes.api360.Model.CarrierFacilityOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The option name that controls a specific aspect of the facility search.  **Facility Options**  | Name                   | Description| Value                                      | |- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -- -|- -- -- -- -- -- -- -- -- -- -- -| | FACILITY_TYPE          | The type of facility to return. By default, the API returns type &#x60;POST_OFFICE&#x60;.                | POST_OFFICE                                | | FACILITY_TYPE_SERVICE  | A service the facility must offer. The API returns only facilities that provide this service.  | LABEL_BROKER_RETAIL, LABEL_BROKER_SELF_SERVICE_KIOSK | | FACILITY_WITHIN_RADIUS | Distance from the buyer in miles.                                                              | Default: 5, Max: 25                        | | NUMBER_OF_FACILITIES   | Number of facilities to return. To return only the closest one, set this to 1.                 | Default: 5, Max: 50                        |  | [optional] 
**Value** | **string** | The value for the given option name. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

