# com.pitneybowes.api360.Model.ManifestDetailedResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarrierAccountId** | **string** | A unique identifier associated with the Carrier account which is used while creating Manifest. | [optional] 
**CarrierName** | **string** | Name of the Carrier. | [optional] 
**ManifestDocuments** | [**List&lt;ManifestDetailedResponseManifestDocumentsInner&gt;**](ManifestDetailedResponseManifestDocumentsInner.md) | The electronically generated document that has manifest (end-of-day) records of all shipments of the day. | [optional] 
**ManifestID** | **string** | The unique manifest ID. This field is not returned for APAC Services. | [optional] 
**ManifestTrackingNumber** | **string** | The manifest tracking number. This is returned only if the carrier has a pre-defined valid value, e.g., UPS, FedEX, or USPS. | [optional] 
**FromAddress** | [**ManifestDetailedResponseFromAddress**](ManifestDetailedResponseFromAddress.md) |  | [optional] 
**ParcelTrackingNumbers** | **List&lt;Object&gt;** |  | [optional] 
**SubmissionDate** | **string** | The date the shipments are to be tendered to the carrier, entered as YYYY-MM-DD. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

