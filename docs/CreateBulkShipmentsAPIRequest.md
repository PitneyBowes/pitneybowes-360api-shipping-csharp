# com.pitneybowes.api360.Model.CreateBulkShipmentsAPIRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupName** | **string** |  | [optional] 
**Size** | **string** | This indicates the label size of the Bulk Shipment, e.g., DocSize can be 8&#39; X 11&#39;. | 
**Type** | **string** | This indicates the type of the Batch Shipment, e.g., Shipping Label. | 
**Format** | **string** | This defines the type of the shipment which is printed, e.g., Shipping label gets printed in PDF form. | [optional] 
**Name** | **string** |  | 
**CarrierAccountId** | **string** | Default &#x60;carrierAccountId&#x60; to be used for this batch. You can override this value by defining it at shipment level. | 
**ParcelType** | **string** | Default &#x60;parcelType&#x60; specific to the carrier, e.g., FRPKG, LGENV, TUBE,PKG to be used for this batch. You can override this value by defining it at shipment level. | 
**ServiceId** | **string** | Default abbreviated name &#x60;serviceId&#x60; of the carrier-specific service to be used for this batch. You can override this value by defining it at shipment level. | 
**SpecialServices** | [**List&lt;SpecialService&gt;**](SpecialService.md) | Default &#x60;specialServices&#x60; to be used for this batch. You can override this value by defining it at shipment level. | [optional] 
**Shipments** | [**List&lt;ShipmentInternational&gt;**](ShipmentInternational.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

