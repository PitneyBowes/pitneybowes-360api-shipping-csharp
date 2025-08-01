# com.pitneybowes.api360.Model.ShipmentDomesticByCarrierHandling
Few shipments need a special handling, and the reason can be fragile items or highly secured shipments. There might be other case scenarios. In a simple term, this field defines shipment handling, which provides users a capability to select handling options.<br/>  > Provide either the specialserviceId or the specialservice objects such as deliveryConfirmation, handling, insurance and returnOptions, but not both.  <br />User can select any of the following handling options (special services), but they may vary as per the carrier selection.   - Hold For Pickup: HOLD_FOR_PICKUP   - Saturday Delivery: SATURDAY_DELIVERY   - UPS Premium Care: PREMIUM_CARE   - Direct Delivery Only: DIRECT_DELIVERY_ONLY   - Additional Handling: ADDITIONAL_HANDLING       Carrier specific options:   - UPS supports all handling options mentioned above.    - FedEx supports *HOLD_FOR_PICKUP, SATURDAY_DELIVERY, and ADDITIONAL_HANDLING*.   - Purolator supports *HOLD_FOR_PICKUP, SATURDAY_DELIVERY, and ADDITIONAL_HANDLING*.    

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The special handling type. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

