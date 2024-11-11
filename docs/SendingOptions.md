# com.pitneybowes.api360.Model.SendingOptions
Sending Options will include carrier and its account details, sender details, and parcel details.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Carrier** | **string** | Name of the carrier. E.g., FedEx. | [optional] 
**Service** | **string** | Name of the carrier-based service. E.g., 2DA. | [optional] 
**CarrierAccounts** | [**SendingOptionsCarrierAccounts**](SendingOptionsCarrierAccounts.md) |  | [optional] 
**LabelSize** | **string** | Size of the label, e.g., DOC_4X6. | [optional] 
**LabelType** | **string** | Type of the Label, e.g., Shipping_Label. | [optional] 
**LabelFormat** | **string** | Format of the Label, e.g., PDF. | [optional] 
**FromAddress** | [**FromAddressV2**](FromAddressV2.md) |  | [optional] 
**Parcel** | [**ParcelV2**](ParcelV2.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

