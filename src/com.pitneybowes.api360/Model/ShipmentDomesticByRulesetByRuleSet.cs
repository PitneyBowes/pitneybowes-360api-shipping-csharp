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
    /// User can create the Shipment using Rule Set.&lt;br /&gt; By Rule Set means a rule that is defined as one or more conditions resulting in an action (or more than one action). &lt;br /&gt; The conditions and actions can vary widely.
    /// </summary>
    [DataContract(Name = "shipmentDomesticByRuleset_byRuleSet")]
    public partial class ShipmentDomesticByRulesetByRuleSet : IValidatableObject
    {
        /// <summary>
        /// The Rule Type is a condition applied to RateGroup by Product side, which can be applicable for a client or set of client users.
        /// </summary>
        /// <value>The Rule Type is a condition applied to RateGroup by Product side, which can be applicable for a client or set of client users.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RuleTypeEnum
        {
            /// <summary>
            /// Enum Cheapest for value: Cheapest
            /// </summary>
            [EnumMember(Value = "Cheapest")]
            Cheapest = 1,

            /// <summary>
            /// Enum Fastest for value: Fastest
            /// </summary>
            [EnumMember(Value = "Fastest")]
            Fastest = 2
        }


        /// <summary>
        /// The Rule Type is a condition applied to RateGroup by Product side, which can be applicable for a client or set of client users.
        /// </summary>
        /// <value>The Rule Type is a condition applied to RateGroup by Product side, which can be applicable for a client or set of client users.</value>
        /// <example>Cheapest</example>
        [DataMember(Name = "ruleType", EmitDefaultValue = false)]
        public RuleTypeEnum? RuleType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentDomesticByRulesetByRuleSet" /> class.
        /// </summary>
        /// <param name="ruleType">The Rule Type is a condition applied to RateGroup by Product side, which can be applicable for a client or set of client users..</param>
        /// <param name="hazmat">This is for Hazardous material..</param>
        /// <param name="shipOption">The options for shipment usually created based on priority or Zone..</param>
        public ShipmentDomesticByRulesetByRuleSet(RuleTypeEnum? ruleType = default(RuleTypeEnum?), string hazmat = default(string), string shipOption = default(string))
        {
            this.RuleType = ruleType;
            this.Hazmat = hazmat;
            this.ShipOption = shipOption;
        }

        /// <summary>
        /// This is for Hazardous material.
        /// </summary>
        /// <value>This is for Hazardous material.</value>
        /// <example>test</example>
        [DataMember(Name = "hazmat", EmitDefaultValue = false)]
        public string Hazmat { get; set; }

        /// <summary>
        /// The options for shipment usually created based on priority or Zone.
        /// </summary>
        /// <value>The options for shipment usually created based on priority or Zone.</value>
        /// <example>STANDARD</example>
        [DataMember(Name = "shipOption", EmitDefaultValue = false)]
        public string ShipOption { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentDomesticByRulesetByRuleSet {\n");
            sb.Append("  RuleType: ").Append(RuleType).Append("\n");
            sb.Append("  Hazmat: ").Append(Hazmat).Append("\n");
            sb.Append("  ShipOption: ").Append(ShipOption).Append("\n");
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
