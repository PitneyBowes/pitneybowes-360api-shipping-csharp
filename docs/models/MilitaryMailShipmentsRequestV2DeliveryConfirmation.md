# com.pitneybowes.api360.Model.MilitaryMailShipmentsRequestV2DeliveryConfirmation
Indicates the supporting special service or document as an evidence of shipment delivery.  For the delivery confirmation, user can select any of the following special services, but they may vary as per the carrier selection. <br />   - Signature Required/ Indirect Signature Required : SIGNATURE   - Delivery confirmation: DELIVERY_CONFIRMATION   - Proof of age required (18 years) Adult Signature Required: ADULT_SIGNATURE   - Proof of age required (19 years): ADULT_SIGNATURE_19   - No Signature Required: NO_SIGNATURE   - Direct Signature Required: DIRECT_SIGNATURE   - Chain of Signature: CHAIN_OF_SIGNATURE       Carrier specific options:   - UPS supports *SIGNATURE and ADULT_SIGNATURE*.    - FedEx supports *SIGNATURE, ADULT_SIGNATURE, NO_SIGNATURE, and DIRECT_SIGNATURE*.   - Purolator supports *ADULT_SIGNATURE, NO_SIGNATURE, and CHAIN_OF_SIGNATURE*.   - GoFor supports *SIGNATURE*.   - CPC supports *SIGNATURE, DELIVERY_CONFIRMATION, ADULT_SIGNATURE, ADULT_SIGNATURE_19, and NO_SIGNATURE*.     

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The delivery confirmation Type. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)

