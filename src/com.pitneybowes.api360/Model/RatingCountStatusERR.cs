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
    /// This indicates the status count of shipments which are at Rating stage. Rating is a process of assessing the shipping/freight charge associated with the ERR Bulk shipment. Rates are calculated based on selected special/extra services corresponding to the selected Services and ParcelType for USPS.
    /// </summary>
    [DataContract(Name = "RatingCountStatusERR")]
    public partial class RatingCountStatusERR : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RatingCountStatusERR" /> class.
        /// </summary>
        /// <param name="success">The number of shipments that have been successfully processed for Ratings..</param>
        /// <param name="failed">The number of shipments which failed processing at Ratings due to some scenarios like unsupported extra services or incompatible extra services combined for a shipment..</param>
        /// <param name="pending">The number of shipments which are pending and in-queue to be processed..</param>
        public RatingCountStatusERR(decimal success = default(decimal), decimal failed = default(decimal), decimal pending = default(decimal))
        {
            this.Success = success;
            this.Failed = failed;
            this.Pending = pending;
        }

        /// <summary>
        /// The number of shipments that have been successfully processed for Ratings.
        /// </summary>
        /// <value>The number of shipments that have been successfully processed for Ratings.</value>
        /// <example>20</example>
        [DataMember(Name = "success", EmitDefaultValue = false)]
        public decimal Success { get; set; }

        /// <summary>
        /// The number of shipments which failed processing at Ratings due to some scenarios like unsupported extra services or incompatible extra services combined for a shipment.
        /// </summary>
        /// <value>The number of shipments which failed processing at Ratings due to some scenarios like unsupported extra services or incompatible extra services combined for a shipment.</value>
        /// <example>10</example>
        [DataMember(Name = "failed", EmitDefaultValue = false)]
        public decimal Failed { get; set; }

        /// <summary>
        /// The number of shipments which are pending and in-queue to be processed.
        /// </summary>
        /// <value>The number of shipments which are pending and in-queue to be processed.</value>
        /// <example>10</example>
        [DataMember(Name = "pending", EmitDefaultValue = false)]
        public decimal Pending { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RatingCountStatusERR {\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Failed: ").Append(Failed).Append("\n");
            sb.Append("  Pending: ").Append(Pending).Append("\n");
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
