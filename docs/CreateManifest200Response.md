# com.pitneybowes.api360.Model.CreateManifest200Response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierAccountId** | **string** | A unique identifier associated with the Carrier account which is used while creating Manifest. | [optional] 
**CarrierName** | **string** | Name of the Carrier. | [optional] 
**ManifestDocuments** | [**List&lt;ManifestCompactResponseManifestDocumentsInner&gt;**](ManifestCompactResponseManifestDocumentsInner.md) |  | [optional] 
**ManifestID** | **string** |  | [optional] 
**ManifestTrackingNumber** | **string** |  | [optional] 
**FromAddress** | [**ManifestDetailedResponseFromAddress**](ManifestDetailedResponseFromAddress.md) |  | [optional] 
**ParcelTrackingNumbers** | **List&lt;Object&gt;** |  | [optional] 
**SubmissionDate** | **string** | The date the shipments are to be tendered to the carrier, entered as YYYY-MM-DD. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

