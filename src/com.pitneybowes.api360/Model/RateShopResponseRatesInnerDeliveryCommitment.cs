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
    /// It specifies the delivery commitment provided by carrier for this shipment
    /// </summary>
    [DataContract(Name = "rateShopResponse_rates_inner_deliveryCommitment")]
    public partial class RateShopResponseRatesInnerDeliveryCommitment : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RateShopResponseRatesInnerDeliveryCommitment" /> class.
        /// </summary>
        /// <param name="additionalDetails">It specifies the additional details for the delivery commitment.</param>
        /// <param name="estimatedDeliveryDateTime">It specifies estimated delivery date time.</param>
        /// <param name="guarantee">It specifies if guarantee is provided..</param>
        /// <param name="maxEstimatedNumberOfDays">It specifies the maximum estimated number of days.</param>
        /// <param name="minEstimatedNumberOfDays">It specifies the minimum estimated number of days.</param>
        public RateShopResponseRatesInnerDeliveryCommitment(string additionalDetails = default(string), string estimatedDeliveryDateTime = default(string), string guarantee = default(string), string maxEstimatedNumberOfDays = default(string), string minEstimatedNumberOfDays = default(string))
        {
            this.AdditionalDetails = additionalDetails;
            this.EstimatedDeliveryDateTime = estimatedDeliveryDateTime;
            this.Guarantee = guarantee;
            this.MaxEstimatedNumberOfDays = maxEstimatedNumberOfDays;
            this.MinEstimatedNumberOfDays = minEstimatedNumberOfDays;
        }

        /// <summary>
        /// It specifies the additional details for the delivery commitment
        /// </summary>
        /// <value>It specifies the additional details for the delivery commitment</value>
        /// <example>By end of Day</example>
        [DataMember(Name = "additionalDetails", EmitDefaultValue = false)]
        public string AdditionalDetails { get; set; }

        /// <summary>
        /// It specifies estimated delivery date time
        /// </summary>
        /// <value>It specifies estimated delivery date time</value>
        /// <example>2023-12-01</example>
        [DataMember(Name = "estimatedDeliveryDateTime", EmitDefaultValue = false)]
        public string EstimatedDeliveryDateTime { get; set; }

        /// <summary>
        /// It specifies if guarantee is provided.
        /// </summary>
        /// <value>It specifies if guarantee is provided.</value>
        /// <example>NONE</example>
        [DataMember(Name = "guarantee", EmitDefaultValue = false)]
        public string Guarantee { get; set; }

        /// <summary>
        /// It specifies the maximum estimated number of days
        /// </summary>
        /// <value>It specifies the maximum estimated number of days</value>
        /// <example>3</example>
        [DataMember(Name = "maxEstimatedNumberOfDays", EmitDefaultValue = false)]
        public string MaxEstimatedNumberOfDays { get; set; }

        /// <summary>
        /// It specifies the minimum estimated number of days
        /// </summary>
        /// <value>It specifies the minimum estimated number of days</value>
        /// <example>3</example>
        [DataMember(Name = "minEstimatedNumberOfDays", EmitDefaultValue = false)]
        public string MinEstimatedNumberOfDays { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RateShopResponseRatesInnerDeliveryCommitment {\n");
            sb.Append("  AdditionalDetails: ").Append(AdditionalDetails).Append("\n");
            sb.Append("  EstimatedDeliveryDateTime: ").Append(EstimatedDeliveryDateTime).Append("\n");
            sb.Append("  Guarantee: ").Append(Guarantee).Append("\n");
            sb.Append("  MaxEstimatedNumberOfDays: ").Append(MaxEstimatedNumberOfDays).Append("\n");
            sb.Append("  MinEstimatedNumberOfDays: ").Append(MinEstimatedNumberOfDays).Append("\n");
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