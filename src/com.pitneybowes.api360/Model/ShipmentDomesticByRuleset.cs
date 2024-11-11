/*
 * Shipping APIs
 *
 * ### Introduction  The Shipping APIs include a variety of operations that allow users to manage and track their shipping requests.   Some of the key API operations available in the Shipping API includes: ### Shipment API  | Operation      | Description | | - -- -- -- -- -- | - -- -- -- -- -- |  | Get Carriers    | This operation fetches all onboarded carriers. Typically, user will use this service to get list of onboarded carriers and supported properties for those carriers.  |  | Get Countries | This operation fetches list of supported destination countries for a provided carrier and origin country.  |  | Get Services | This operation fetches a list of supported services for a carrier with respect to specific origin and destination country. |  | Get ParcelTypes| This operation fetches ParcelTypes based on carrier, origin and destination country. |  | Get Special Services| This operation fetches Special Services for a given carrier, service, origin and destination country. |  | Get Carrier Accounts| This operation retrieves onboarded Carriers with their Carrier Account Ids which uniquely identify multiple accounts of same carrier.  |  | Rate Shop and Get Single Rate| This API contains 2 operations, rate shop and single rate. Rate shop will fetch rates for all carrier services based on the given addresses (From and To), weight, and dimension for given parcelType. Single rate will get rate for specific service and special service (if requested) based on the given addresses (From and To), weight, and dimension, parcelType and serviceId with or without specialServices. Single rate will be used mainly to a rate a shipment before creating shipment.  |  | Create Shipment| This operation creates a new Shipment or Shipment Label. This is for both Domestic and International. | | Get All Shipments| This operation fetches all created Shipments. |  | Get Shipment by Id| Retrieves single shipment using Shipment Id. |  | Reprint Shipment| This operation reprints Shipment by the shipmentId. It retrieves an existing shipping label to reprint. The API sends the shipmentId returned by the original Created Shipment request. Use this only if the shipping label in the Create Shipment response was spoilt or lost. |  | Cancel Shipment| This operation cancels previously created shipment. |  
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = com.pitneybowes.api360.Client.OpenAPIDateConverter;

namespace com.pitneybowes.api360.Model
{
    /// <summary>
    /// ShipmentDomesticByRuleset
    /// </summary>
    [DataContract(Name = "shipmentDomesticByRuleset")]
    public partial class ShipmentDomesticByRuleset : IValidatableObject
    {
        /// <summary>
        /// RateShop, which is attached to an Enterprise or Location, is done through three approaches: by Carrier, by RateGroup, and by Ruleset. &lt;br /&gt;  Through Carrier, customers can choose the carriers as per requirement, based on which services, parcel types, and special services can be selected, and RateShop is done. &lt;br /&gt; Through RateGroup, customers can select the RateGroup, which has been divided into two categories: Cheapest (w.r.t. price) and Fastest (w.r.t. delivery hours). &lt;br /&gt; Through Ruleset, customers can define the Condition/rule for selecting carriers and their services, so they do not need to worry for Rate Shopping every time they create Shipment. For example, For a particular location, they can set one definite carrier, or apply RateGroup - Cheapest/Fastest. Similarly, for a particular amount like below $1000 Dollars, they can select a definite carrier service, based on RateGroup.
        /// </summary>
        /// <value>RateShop, which is attached to an Enterprise or Location, is done through three approaches: by Carrier, by RateGroup, and by Ruleset. &lt;br /&gt;  Through Carrier, customers can choose the carriers as per requirement, based on which services, parcel types, and special services can be selected, and RateShop is done. &lt;br /&gt; Through RateGroup, customers can select the RateGroup, which has been divided into two categories: Cheapest (w.r.t. price) and Fastest (w.r.t. delivery hours). &lt;br /&gt; Through Ruleset, customers can define the Condition/rule for selecting carriers and their services, so they do not need to worry for Rate Shopping every time they create Shipment. For example, For a particular location, they can set one definite carrier, or apply RateGroup - Cheapest/Fastest. Similarly, for a particular amount like below $1000 Dollars, they can select a definite carrier service, based on RateGroup.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RateShopByEnum
        {
            /// <summary>
            /// Enum Carrier for value: carrier
            /// </summary>
            [EnumMember(Value = "carrier")]
            Carrier = 1,

            /// <summary>
            /// Enum RateGroup for value: rateGroup
            /// </summary>
            [EnumMember(Value = "rateGroup")]
            RateGroup = 2,

            /// <summary>
            /// Enum Ruleset for value: ruleset
            /// </summary>
            [EnumMember(Value = "ruleset")]
            Ruleset = 3
        }


        /// <summary>
        /// RateShop, which is attached to an Enterprise or Location, is done through three approaches: by Carrier, by RateGroup, and by Ruleset. &lt;br /&gt;  Through Carrier, customers can choose the carriers as per requirement, based on which services, parcel types, and special services can be selected, and RateShop is done. &lt;br /&gt; Through RateGroup, customers can select the RateGroup, which has been divided into two categories: Cheapest (w.r.t. price) and Fastest (w.r.t. delivery hours). &lt;br /&gt; Through Ruleset, customers can define the Condition/rule for selecting carriers and their services, so they do not need to worry for Rate Shopping every time they create Shipment. For example, For a particular location, they can set one definite carrier, or apply RateGroup - Cheapest/Fastest. Similarly, for a particular amount like below $1000 Dollars, they can select a definite carrier service, based on RateGroup.
        /// </summary>
        /// <value>RateShop, which is attached to an Enterprise or Location, is done through three approaches: by Carrier, by RateGroup, and by Ruleset. &lt;br /&gt;  Through Carrier, customers can choose the carriers as per requirement, based on which services, parcel types, and special services can be selected, and RateShop is done. &lt;br /&gt; Through RateGroup, customers can select the RateGroup, which has been divided into two categories: Cheapest (w.r.t. price) and Fastest (w.r.t. delivery hours). &lt;br /&gt; Through Ruleset, customers can define the Condition/rule for selecting carriers and their services, so they do not need to worry for Rate Shopping every time they create Shipment. For example, For a particular location, they can set one definite carrier, or apply RateGroup - Cheapest/Fastest. Similarly, for a particular amount like below $1000 Dollars, they can select a definite carrier service, based on RateGroup.</value>
        /// <example>ruleset</example>
        [DataMember(Name = "rateShopBy", EmitDefaultValue = false)]
        public RateShopByEnum? RateShopBy { get; set; }
        /// <summary>
        /// Indicates the supporting special service or document as an evidence of shipment delivery.  For the delivery confirmation, user can select any of the following special services, but they may vary as per the carrier selection. &lt;br /&gt;   - Signature Required/ Indirect Signature Required : SIG   - Signed Hard Copy: SIGHC   - Delivery confirmation: DEL_CON   - Proof of age required (18 years) Adult Signature Required: ADULT_SIG   - Proof of age required (19 years): ADULT_SIG_19   - No Signature Required: NO_SIG   - Direct Signature Required: DIRECT_SIG   - Chain of Signature: COS       Carrier specific options:   - UPS supports *SIG and ADULT_SIG*.    - FedEx supports *SIG, ADULT_SIG, NO_SIG, and DIRECT_SIG*.   - Purolator supports *ADULT_SIG, NO_SIG, and COS*.   - GoFor supports *SIG*.   - CPC supports *SIG, SIGHC, DEL_CON, ADULT_SIG, ADULT_SIG_19, and NO_SIG*.     
        /// </summary>
        /// <value>Indicates the supporting special service or document as an evidence of shipment delivery.  For the delivery confirmation, user can select any of the following special services, but they may vary as per the carrier selection. &lt;br /&gt;   - Signature Required/ Indirect Signature Required : SIG   - Signed Hard Copy: SIGHC   - Delivery confirmation: DEL_CON   - Proof of age required (18 years) Adult Signature Required: ADULT_SIG   - Proof of age required (19 years): ADULT_SIG_19   - No Signature Required: NO_SIG   - Direct Signature Required: DIRECT_SIG   - Chain of Signature: COS       Carrier specific options:   - UPS supports *SIG and ADULT_SIG*.    - FedEx supports *SIG, ADULT_SIG, NO_SIG, and DIRECT_SIG*.   - Purolator supports *ADULT_SIG, NO_SIG, and COS*.   - GoFor supports *SIG*.   - CPC supports *SIG, SIGHC, DEL_CON, ADULT_SIG, ADULT_SIG_19, and NO_SIG*.     </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DeliveryConfirmationEnum
        {
            /// <summary>
            /// Enum SIG for value: SIG
            /// </summary>
            [EnumMember(Value = "SIG")]
            SIG = 1,

            /// <summary>
            /// Enum SIGHC for value: SIGHC
            /// </summary>
            [EnumMember(Value = "SIGHC")]
            SIGHC = 2,

            /// <summary>
            /// Enum DELCON for value: DEL_CON
            /// </summary>
            [EnumMember(Value = "DEL_CON")]
            DELCON = 3,

            /// <summary>
            /// Enum ADULTSIG for value: ADULT_SIG
            /// </summary>
            [EnumMember(Value = "ADULT_SIG")]
            ADULTSIG = 4,

            /// <summary>
            /// Enum ADULTSIG19 for value: ADULT_SIG_19
            /// </summary>
            [EnumMember(Value = "ADULT_SIG_19")]
            ADULTSIG19 = 5,

            /// <summary>
            /// Enum NOSIG for value: NO_SIG
            /// </summary>
            [EnumMember(Value = "NO_SIG")]
            NOSIG = 6,

            /// <summary>
            /// Enum DIRECTSIG for value: DIRECT_SIG
            /// </summary>
            [EnumMember(Value = "DIRECT_SIG")]
            DIRECTSIG = 7,

            /// <summary>
            /// Enum COS for value: COS
            /// </summary>
            [EnumMember(Value = "COS")]
            COS = 8
        }


        /// <summary>
        /// Indicates the supporting special service or document as an evidence of shipment delivery.  For the delivery confirmation, user can select any of the following special services, but they may vary as per the carrier selection. &lt;br /&gt;   - Signature Required/ Indirect Signature Required : SIG   - Signed Hard Copy: SIGHC   - Delivery confirmation: DEL_CON   - Proof of age required (18 years) Adult Signature Required: ADULT_SIG   - Proof of age required (19 years): ADULT_SIG_19   - No Signature Required: NO_SIG   - Direct Signature Required: DIRECT_SIG   - Chain of Signature: COS       Carrier specific options:   - UPS supports *SIG and ADULT_SIG*.    - FedEx supports *SIG, ADULT_SIG, NO_SIG, and DIRECT_SIG*.   - Purolator supports *ADULT_SIG, NO_SIG, and COS*.   - GoFor supports *SIG*.   - CPC supports *SIG, SIGHC, DEL_CON, ADULT_SIG, ADULT_SIG_19, and NO_SIG*.     
        /// </summary>
        /// <value>Indicates the supporting special service or document as an evidence of shipment delivery.  For the delivery confirmation, user can select any of the following special services, but they may vary as per the carrier selection. &lt;br /&gt;   - Signature Required/ Indirect Signature Required : SIG   - Signed Hard Copy: SIGHC   - Delivery confirmation: DEL_CON   - Proof of age required (18 years) Adult Signature Required: ADULT_SIG   - Proof of age required (19 years): ADULT_SIG_19   - No Signature Required: NO_SIG   - Direct Signature Required: DIRECT_SIG   - Chain of Signature: COS       Carrier specific options:   - UPS supports *SIG and ADULT_SIG*.    - FedEx supports *SIG, ADULT_SIG, NO_SIG, and DIRECT_SIG*.   - Purolator supports *ADULT_SIG, NO_SIG, and COS*.   - GoFor supports *SIG*.   - CPC supports *SIG, SIGHC, DEL_CON, ADULT_SIG, ADULT_SIG_19, and NO_SIG*.     </value>
        /// <example>SIG</example>
        [DataMember(Name = "deliveryConfirmation", EmitDefaultValue = false)]
        public DeliveryConfirmationEnum? DeliveryConfirmation { get; set; }
        /// <summary>
        /// Few shipments need a special handling, and the reason can be fragile items or highly secured shipments. There might be other case scenarios. In a simple term, this field defines shipment handling, which provides users a capability to select handling options. &lt;br /&gt; User can select any of the following handling options (special services), but they may vary as per the carrier selection.   - Hold For Pickup: HOLD   - Saturday Delivery: SAT_DELIVERY   - UPS Premium Care: PREM_CARE   - Direct Delivery Only: DIRECT   - Additional Handling: ADD_HDL       Carrier specific options:   - UPS supports all handling options mentioned above.    - FedEx supports *HOLD, SAT_DELIVERY, and ADD_HDL*.   - Purolator supports *HOLD, SAT_DELIVERY, and ADD_HDL*.    
        /// </summary>
        /// <value>Few shipments need a special handling, and the reason can be fragile items or highly secured shipments. There might be other case scenarios. In a simple term, this field defines shipment handling, which provides users a capability to select handling options. &lt;br /&gt; User can select any of the following handling options (special services), but they may vary as per the carrier selection.   - Hold For Pickup: HOLD   - Saturday Delivery: SAT_DELIVERY   - UPS Premium Care: PREM_CARE   - Direct Delivery Only: DIRECT   - Additional Handling: ADD_HDL       Carrier specific options:   - UPS supports all handling options mentioned above.    - FedEx supports *HOLD, SAT_DELIVERY, and ADD_HDL*.   - Purolator supports *HOLD, SAT_DELIVERY, and ADD_HDL*.    </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HandlingEnum
        {
            /// <summary>
            /// Enum HOLD for value: HOLD
            /// </summary>
            [EnumMember(Value = "HOLD")]
            HOLD = 1,

            /// <summary>
            /// Enum SATDELIVERY for value: SAT_DELIVERY
            /// </summary>
            [EnumMember(Value = "SAT_DELIVERY")]
            SATDELIVERY = 2,

            /// <summary>
            /// Enum PREMCARE for value: PREM_CARE
            /// </summary>
            [EnumMember(Value = "PREM_CARE")]
            PREMCARE = 3,

            /// <summary>
            /// Enum DIRECT for value: DIRECT
            /// </summary>
            [EnumMember(Value = "DIRECT")]
            DIRECT = 4,

            /// <summary>
            /// Enum ADDHDL for value: ADD_HDL
            /// </summary>
            [EnumMember(Value = "ADD_HDL")]
            ADDHDL = 5
        }


        /// <summary>
        /// Few shipments need a special handling, and the reason can be fragile items or highly secured shipments. There might be other case scenarios. In a simple term, this field defines shipment handling, which provides users a capability to select handling options. &lt;br /&gt; User can select any of the following handling options (special services), but they may vary as per the carrier selection.   - Hold For Pickup: HOLD   - Saturday Delivery: SAT_DELIVERY   - UPS Premium Care: PREM_CARE   - Direct Delivery Only: DIRECT   - Additional Handling: ADD_HDL       Carrier specific options:   - UPS supports all handling options mentioned above.    - FedEx supports *HOLD, SAT_DELIVERY, and ADD_HDL*.   - Purolator supports *HOLD, SAT_DELIVERY, and ADD_HDL*.    
        /// </summary>
        /// <value>Few shipments need a special handling, and the reason can be fragile items or highly secured shipments. There might be other case scenarios. In a simple term, this field defines shipment handling, which provides users a capability to select handling options. &lt;br /&gt; User can select any of the following handling options (special services), but they may vary as per the carrier selection.   - Hold For Pickup: HOLD   - Saturday Delivery: SAT_DELIVERY   - UPS Premium Care: PREM_CARE   - Direct Delivery Only: DIRECT   - Additional Handling: ADD_HDL       Carrier specific options:   - UPS supports all handling options mentioned above.    - FedEx supports *HOLD, SAT_DELIVERY, and ADD_HDL*.   - Purolator supports *HOLD, SAT_DELIVERY, and ADD_HDL*.    </value>
        /// <example>ADD_HDL</example>
        [DataMember(Name = "handling", EmitDefaultValue = false)]
        public HandlingEnum? Handling { get; set; }
        /// <summary>
        /// Indicates the insurance coverage, which is selected by users while create shipment - rate shopping. User can select below-mentioned special service for insurance:    - Declared Value Surcharge: INS      Carrier specific options:   - UPS, FedEx, Purolator, and CPC support special service *INS*.    
        /// </summary>
        /// <value>Indicates the insurance coverage, which is selected by users while create shipment - rate shopping. User can select below-mentioned special service for insurance:    - Declared Value Surcharge: INS      Carrier specific options:   - UPS, FedEx, Purolator, and CPC support special service *INS*.    </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InsuranceEnum
        {
            /// <summary>
            /// Enum INS for value: INS
            /// </summary>
            [EnumMember(Value = "INS")]
            INS = 1
        }


        /// <summary>
        /// Indicates the insurance coverage, which is selected by users while create shipment - rate shopping. User can select below-mentioned special service for insurance:    - Declared Value Surcharge: INS      Carrier specific options:   - UPS, FedEx, Purolator, and CPC support special service *INS*.    
        /// </summary>
        /// <value>Indicates the insurance coverage, which is selected by users while create shipment - rate shopping. User can select below-mentioned special service for insurance:    - Declared Value Surcharge: INS      Carrier specific options:   - UPS, FedEx, Purolator, and CPC support special service *INS*.    </value>
        /// <example>INS</example>
        [DataMember(Name = "insurance", EmitDefaultValue = false)]
        public InsuranceEnum? Insurance { get; set; }
        /// <summary>
        /// Defines the label size of the Shipment, that is, the Shipping Label is available in different Doc Size. &lt;br /&gt; &#x60;Max length &#x3D; 10&#x60;
        /// </summary>
        /// <value>Defines the label size of the Shipment, that is, the Shipping Label is available in different Doc Size. &lt;br /&gt; &#x60;Max length &#x3D; 10&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LabelSizeEnum
        {
            /// <summary>
            /// Enum _8X11 for value: DOC_8X11
            /// </summary>
            [EnumMember(Value = "DOC_8X11")]
            _8X11 = 1,

            /// <summary>
            /// Enum _4X8 for value: DOC_4X8
            /// </summary>
            [EnumMember(Value = "DOC_4X8")]
            _4X8 = 2,

            /// <summary>
            /// Enum _4X6 for value: DOC_4X6
            /// </summary>
            [EnumMember(Value = "DOC_4X6")]
            _4X6 = 3
        }


        /// <summary>
        /// Defines the label size of the Shipment, that is, the Shipping Label is available in different Doc Size. &lt;br /&gt; &#x60;Max length &#x3D; 10&#x60;
        /// </summary>
        /// <value>Defines the label size of the Shipment, that is, the Shipping Label is available in different Doc Size. &lt;br /&gt; &#x60;Max length &#x3D; 10&#x60;</value>
        /// <example>DOC_4X6</example>
        [DataMember(Name = "labelSize", IsRequired = true, EmitDefaultValue = true)]
        public LabelSizeEnum LabelSize { get; set; }
        /// <summary>
        /// Defines the type of the Shipment. &lt;br /&gt; &#x60;Max length &#x3D; 14&#x60;
        /// </summary>
        /// <value>Defines the type of the Shipment. &lt;br /&gt; &#x60;Max length &#x3D; 14&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LabelTypeEnum
        {
            /// <summary>
            /// Enum SHIPPINGLABEL for value: SHIPPING_LABEL
            /// </summary>
            [EnumMember(Value = "SHIPPING_LABEL")]
            SHIPPINGLABEL = 1
        }


        /// <summary>
        /// Defines the type of the Shipment. &lt;br /&gt; &#x60;Max length &#x3D; 14&#x60;
        /// </summary>
        /// <value>Defines the type of the Shipment. &lt;br /&gt; &#x60;Max length &#x3D; 14&#x60;</value>
        /// <example>SHIPPING_LABEL</example>
        [DataMember(Name = "labelType", IsRequired = true, EmitDefaultValue = true)]
        public LabelTypeEnum LabelType { get; set; }
        /// <summary>
        /// Defines the file/format in which the label is printed. &lt;br /&gt; &#x60;Max length &#x3D; 14&#x60;
        /// </summary>
        /// <value>Defines the file/format in which the label is printed. &lt;br /&gt; &#x60;Max length &#x3D; 14&#x60;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum LabelFormatEnum
        {
            /// <summary>
            /// Enum ZPL2 for value: ZPL2
            /// </summary>
            [EnumMember(Value = "ZPL2")]
            ZPL2 = 1,

            /// <summary>
            /// Enum PDF for value: PDF
            /// </summary>
            [EnumMember(Value = "PDF")]
            PDF = 2
        }


        /// <summary>
        /// Defines the file/format in which the label is printed. &lt;br /&gt; &#x60;Max length &#x3D; 14&#x60;
        /// </summary>
        /// <value>Defines the file/format in which the label is printed. &lt;br /&gt; &#x60;Max length &#x3D; 14&#x60;</value>
        /// <example>ZPL2</example>
        [DataMember(Name = "labelFormat", IsRequired = true, EmitDefaultValue = true)]
        public LabelFormatEnum LabelFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentDomesticByRuleset" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipmentDomesticByRuleset() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentDomesticByRuleset" /> class.
        /// </summary>
        /// <param name="fromAddress">fromAddress (required).</param>
        /// <param name="toAddress">toAddress (required).</param>
        /// <param name="parcel">parcel.</param>
        /// <param name="parcelType">Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection.&lt;br /&gt; ParcelType can have categories like Package, Envelopes, Paks, Boxes, Tube, etc. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60; .</param>
        /// <param name="rateShopBy">RateShop, which is attached to an Enterprise or Location, is done through three approaches: by Carrier, by RateGroup, and by Ruleset. &lt;br /&gt;  Through Carrier, customers can choose the carriers as per requirement, based on which services, parcel types, and special services can be selected, and RateShop is done. &lt;br /&gt; Through RateGroup, customers can select the RateGroup, which has been divided into two categories: Cheapest (w.r.t. price) and Fastest (w.r.t. delivery hours). &lt;br /&gt; Through Ruleset, customers can define the Condition/rule for selecting carriers and their services, so they do not need to worry for Rate Shopping every time they create Shipment. For example, For a particular location, they can set one definite carrier, or apply RateGroup - Cheapest/Fastest. Similarly, for a particular amount like below $1000 Dollars, they can select a definite carrier service, based on RateGroup..</param>
        /// <param name="byRuleSet">byRuleSet.</param>
        /// <param name="shipmentOptions">shipmentOptions.</param>
        /// <param name="docTab">docTab.</param>
        /// <param name="deliveryConfirmation">Indicates the supporting special service or document as an evidence of shipment delivery.  For the delivery confirmation, user can select any of the following special services, but they may vary as per the carrier selection. &lt;br /&gt;   - Signature Required/ Indirect Signature Required : SIG   - Signed Hard Copy: SIGHC   - Delivery confirmation: DEL_CON   - Proof of age required (18 years) Adult Signature Required: ADULT_SIG   - Proof of age required (19 years): ADULT_SIG_19   - No Signature Required: NO_SIG   - Direct Signature Required: DIRECT_SIG   - Chain of Signature: COS       Carrier specific options:   - UPS supports *SIG and ADULT_SIG*.    - FedEx supports *SIG, ADULT_SIG, NO_SIG, and DIRECT_SIG*.   - Purolator supports *ADULT_SIG, NO_SIG, and COS*.   - GoFor supports *SIG*.   - CPC supports *SIG, SIGHC, DEL_CON, ADULT_SIG, ADULT_SIG_19, and NO_SIG*.     .</param>
        /// <param name="handling">Few shipments need a special handling, and the reason can be fragile items or highly secured shipments. There might be other case scenarios. In a simple term, this field defines shipment handling, which provides users a capability to select handling options. &lt;br /&gt; User can select any of the following handling options (special services), but they may vary as per the carrier selection.   - Hold For Pickup: HOLD   - Saturday Delivery: SAT_DELIVERY   - UPS Premium Care: PREM_CARE   - Direct Delivery Only: DIRECT   - Additional Handling: ADD_HDL       Carrier specific options:   - UPS supports all handling options mentioned above.    - FedEx supports *HOLD, SAT_DELIVERY, and ADD_HDL*.   - Purolator supports *HOLD, SAT_DELIVERY, and ADD_HDL*.    .</param>
        /// <param name="insurance">Indicates the insurance coverage, which is selected by users while create shipment - rate shopping. User can select below-mentioned special service for insurance:    - Declared Value Surcharge: INS      Carrier specific options:   - UPS, FedEx, Purolator, and CPC support special service *INS*.    .</param>
        /// <param name="references">references.</param>
        /// <param name="metadata">Additional metadata that needs to be stored for this shipment can be added here.&lt;br /&gt; For now, &#39;Cost Account Name&#39; is supported..</param>
        /// <param name="labelSize">Defines the label size of the Shipment, that is, the Shipping Label is available in different Doc Size. &lt;br /&gt; &#x60;Max length &#x3D; 10&#x60; (required).</param>
        /// <param name="labelType">Defines the type of the Shipment. &lt;br /&gt; &#x60;Max length &#x3D; 14&#x60; (required).</param>
        /// <param name="labelFormat">Defines the file/format in which the label is printed. &lt;br /&gt; &#x60;Max length &#x3D; 14&#x60; (required).</param>
        /// <param name="printerAliasName">Refers to a printer connected (directly or via network) to a computer. &#x60;Max length &#x3D; 60&#x60;.</param>
        /// <param name="dateOfShipment">The date when shipment is created/shipped. The format of the Date is YYYY-MM-DD..</param>
        /// <param name="deliveryOption">deliveryOption.</param>
        public ShipmentDomesticByRuleset(FromAddressV2 fromAddress = default(FromAddressV2), ToAddressV2 toAddress = default(ToAddressV2), ParcelV2 parcel = default(ParcelV2), string parcelType = default(string), RateShopByEnum? rateShopBy = default(RateShopByEnum?), ShipmentDomesticByRulesetByRuleSet byRuleSet = default(ShipmentDomesticByRulesetByRuleSet), ShipmentDomesticByRulesetShipmentOptions shipmentOptions = default(ShipmentDomesticByRulesetShipmentOptions), ShipmentDomesticByCarrierDocTab docTab = default(ShipmentDomesticByCarrierDocTab), DeliveryConfirmationEnum? deliveryConfirmation = default(DeliveryConfirmationEnum?), HandlingEnum? handling = default(HandlingEnum?), InsuranceEnum? insurance = default(InsuranceEnum?), ReferenceV2 references = default(ReferenceV2), List<ShipmentDomesticByRulesetMetadataInner> metadata = default(List<ShipmentDomesticByRulesetMetadataInner>), LabelSizeEnum labelSize = default(LabelSizeEnum), LabelTypeEnum labelType = default(LabelTypeEnum), LabelFormatEnum labelFormat = default(LabelFormatEnum), string printerAliasName = default(string), DateOnly dateOfShipment = default(DateOnly), ShipmentDomesticByRulesetDeliveryOption deliveryOption = default(ShipmentDomesticByRulesetDeliveryOption))
        {
            // to ensure "fromAddress" is required (not null)
            if (fromAddress == null)
            {
                throw new ArgumentNullException("fromAddress is a required property for ShipmentDomesticByRuleset and cannot be null");
            }
            this.FromAddress = fromAddress;
            // to ensure "toAddress" is required (not null)
            if (toAddress == null)
            {
                throw new ArgumentNullException("toAddress is a required property for ShipmentDomesticByRuleset and cannot be null");
            }
            this.ToAddress = toAddress;
            this.LabelSize = labelSize;
            this.LabelType = labelType;
            this.LabelFormat = labelFormat;
            this.Parcel = parcel;
            this.ParcelType = parcelType;
            this.RateShopBy = rateShopBy;
            this.ByRuleSet = byRuleSet;
            this.ShipmentOptions = shipmentOptions;
            this.DocTab = docTab;
            this.DeliveryConfirmation = deliveryConfirmation;
            this.Handling = handling;
            this.Insurance = insurance;
            this.References = references;
            this.Metadata = metadata;
            this.PrinterAliasName = printerAliasName;
            this.DateOfShipment = dateOfShipment;
            this.DeliveryOption = deliveryOption;
        }

        /// <summary>
        /// Gets or Sets FromAddress
        /// </summary>
        [DataMember(Name = "fromAddress", IsRequired = true, EmitDefaultValue = true)]
        public FromAddressV2 FromAddress { get; set; }

        /// <summary>
        /// Gets or Sets ToAddress
        /// </summary>
        [DataMember(Name = "toAddress", IsRequired = true, EmitDefaultValue = true)]
        public ToAddressV2 ToAddress { get; set; }

        /// <summary>
        /// Gets or Sets Parcel
        /// </summary>
        [DataMember(Name = "parcel", EmitDefaultValue = false)]
        public ParcelV2 Parcel { get; set; }

        /// <summary>
        /// Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection.&lt;br /&gt; ParcelType can have categories like Package, Envelopes, Paks, Boxes, Tube, etc. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60; 
        /// </summary>
        /// <value>Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection.&lt;br /&gt; ParcelType can have categories like Package, Envelopes, Paks, Boxes, Tube, etc. &lt;br /&gt; &#x60;Max length &#x3D; 30&#x60; </value>
        /// <example>PKG</example>
        [DataMember(Name = "parcelType", EmitDefaultValue = false)]
        public string ParcelType { get; set; }

        /// <summary>
        /// Gets or Sets ByRuleSet
        /// </summary>
        [DataMember(Name = "byRuleSet", EmitDefaultValue = false)]
        public ShipmentDomesticByRulesetByRuleSet ByRuleSet { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentOptions
        /// </summary>
        [DataMember(Name = "shipmentOptions", EmitDefaultValue = false)]
        public ShipmentDomesticByRulesetShipmentOptions ShipmentOptions { get; set; }

        /// <summary>
        /// Gets or Sets DocTab
        /// </summary>
        [DataMember(Name = "docTab", EmitDefaultValue = false)]
        public ShipmentDomesticByCarrierDocTab DocTab { get; set; }

        /// <summary>
        /// Gets or Sets References
        /// </summary>
        [DataMember(Name = "references", EmitDefaultValue = false)]
        public ReferenceV2 References { get; set; }

        /// <summary>
        /// Additional metadata that needs to be stored for this shipment can be added here.&lt;br /&gt; For now, &#39;Cost Account Name&#39; is supported.
        /// </summary>
        /// <value>Additional metadata that needs to be stored for this shipment can be added here.&lt;br /&gt; For now, &#39;Cost Account Name&#39; is supported.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public List<ShipmentDomesticByRulesetMetadataInner> Metadata { get; set; }

        /// <summary>
        /// Refers to a printer connected (directly or via network) to a computer. &#x60;Max length &#x3D; 60&#x60;
        /// </summary>
        /// <value>Refers to a printer connected (directly or via network) to a computer. &#x60;Max length &#x3D; 60&#x60;</value>
        /// <example>test</example>
        [DataMember(Name = "printerAliasName", EmitDefaultValue = false)]
        public string PrinterAliasName { get; set; }

        /// <summary>
        /// The date when shipment is created/shipped. The format of the Date is YYYY-MM-DD.
        /// </summary>
        /// <value>The date when shipment is created/shipped. The format of the Date is YYYY-MM-DD.</value>
        /// <example>Wed Mar 20 05:30:00 IST 2024</example>
        [DataMember(Name = "dateOfShipment", EmitDefaultValue = false)]
        public DateOnly DateOfShipment { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryOption
        /// </summary>
        [DataMember(Name = "deliveryOption", EmitDefaultValue = false)]
        public ShipmentDomesticByRulesetDeliveryOption DeliveryOption { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentDomesticByRuleset {\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  Parcel: ").Append(Parcel).Append("\n");
            sb.Append("  ParcelType: ").Append(ParcelType).Append("\n");
            sb.Append("  RateShopBy: ").Append(RateShopBy).Append("\n");
            sb.Append("  ByRuleSet: ").Append(ByRuleSet).Append("\n");
            sb.Append("  ShipmentOptions: ").Append(ShipmentOptions).Append("\n");
            sb.Append("  DocTab: ").Append(DocTab).Append("\n");
            sb.Append("  DeliveryConfirmation: ").Append(DeliveryConfirmation).Append("\n");
            sb.Append("  Handling: ").Append(Handling).Append("\n");
            sb.Append("  Insurance: ").Append(Insurance).Append("\n");
            sb.Append("  References: ").Append(References).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  LabelSize: ").Append(LabelSize).Append("\n");
            sb.Append("  LabelType: ").Append(LabelType).Append("\n");
            sb.Append("  LabelFormat: ").Append(LabelFormat).Append("\n");
            sb.Append("  PrinterAliasName: ").Append(PrinterAliasName).Append("\n");
            sb.Append("  DateOfShipment: ").Append(DateOfShipment).Append("\n");
            sb.Append("  DeliveryOption: ").Append(DeliveryOption).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
