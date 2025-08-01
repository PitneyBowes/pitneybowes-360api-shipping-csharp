# com.pitneybowes.api360.Model.IMbLabelSampleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ServiceId** | **string** | Service identifier. For IMB, use &#39;FCM&#39; (First-Class Mail). | 
**ParcelType** | **string** | Type of USPS package (e.g., LETTER, FLAT, IRRPKG, NMLETTER). | 
**Size** | **string** | Label size. For IMB labels, use &#39;DOC_6X4&#39; or &#39;DOC_9X4&#39; (LETTER only). | 
**FromAddress** | [**FromAddressV2**](FromAddressV2.md) |  | 
**ToAddress** | [**ToAddressV2**](ToAddressV2.md) |  | 
**Type** | **string** | Document type to be generated (e.g., SHIPPING_LABEL). | [optional] 
**Format** | **string** | File format for the label (e.g., PDF, PNG, ZPL2). | [optional] 
**CarrierAccountId** | **string** | The account ID associated with the USPS carrier. | [optional] 
**Metadata** | **List&lt;Object&gt;** | Optional metadata array. | [optional] 
**Parcel** | [**IMbLabelSampleRequestParcel**](IMbLabelSampleRequestParcel.md) |  | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

