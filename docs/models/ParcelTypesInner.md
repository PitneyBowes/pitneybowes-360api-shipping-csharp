# com.pitneybowes.api360.Model.ParcelTypesInner

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BrandedName** | **string** | The branded name of parcel type | [optional] 
**Carrier** | **string** | A unique identifier associated with the specific carrier. | [optional] 
**DimensionRules** | [**List&lt;ParcelTypesInnerDimensionRulesInner&gt;**](ParcelTypesInnerDimensionRulesInner.md) | Defines the maximum and minimum dimension supported for given parcel type. | [optional] 
**GroupName** | **string** |  | [optional] 
**BrandedDimensions** | [**ParcelTypesInnerBrandedDimensions**](ParcelTypesInnerBrandedDimensions.md) |  | [optional] 
**ParcelId** | **string** | A unique identifier associated with the Parcel. | [optional] 
**IsBranded** | **bool** | If the Parcel is Branded. If yes, it will take &#x60;true&#x60;, else will take &#x60;false&#x60;. | [optional] 
**ParcelType** | **string** | Defines the type of Parcel. | [optional] 
**ServiceId** | **string** | A unique identifier associated with the carrier-based service. | [optional] 
**ServiceName** | **string** | Name of the Carrier Service. | [optional] 
**SuggestedTrackableSpecialserviceId** | **string** | Defines the parcel has feature to track special serviceID. | [optional] 
**WeightRules** | [**List&lt;ParcelTypesInnerWeightRulesInner&gt;**](ParcelTypesInnerWeightRulesInner.md) | Defines the maximum and minimum weight supported for given parcel type. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

