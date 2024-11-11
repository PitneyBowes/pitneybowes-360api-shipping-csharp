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
    /// ProcessShipmentResponse
    /// </summary>
    [DataContract(Name = "ProcessShipmentResponse")]
    public partial class ProcessShipmentResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ProcessShipmentResponse" /> class.
        /// </summary>
        /// <param name="batchId"> This is a system-generated unique identifier assigned to the Batch while it is processed..</param>
        /// <param name="name">Name of the of Batch which consists of multiple shipments (shipments in bulk)..</param>
        /// <param name="groupName">Indicates the name of the group of batches, which consists of multiple Batch groups..</param>
        /// <param name="status"> The batch will show the status &#x60;SUBMITTED&#x60; on successful execution of Batch..</param>
        public ProcessShipmentResponse(string batchId = default(string), string name = default(string), string groupName = default(string), string status = default(string))
        {
            this.BatchId = batchId;
            this.Name = name;
            this.GroupName = groupName;
            this.Status = status;
        }

        /// <summary>
        ///  This is a system-generated unique identifier assigned to the Batch while it is processed.
        /// </summary>
        /// <value> This is a system-generated unique identifier assigned to the Batch while it is processed.</value>
        [DataMember(Name = "batchId", EmitDefaultValue = false)]
        public string BatchId { get; set; }

        /// <summary>
        /// Name of the of Batch which consists of multiple shipments (shipments in bulk).
        /// </summary>
        /// <value>Name of the of Batch which consists of multiple shipments (shipments in bulk).</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Indicates the name of the group of batches, which consists of multiple Batch groups.
        /// </summary>
        /// <value>Indicates the name of the group of batches, which consists of multiple Batch groups.</value>
        [DataMember(Name = "groupName", EmitDefaultValue = false)]
        public string GroupName { get; set; }

        /// <summary>
        ///  The batch will show the status &#x60;SUBMITTED&#x60; on successful execution of Batch.
        /// </summary>
        /// <value> The batch will show the status &#x60;SUBMITTED&#x60; on successful execution of Batch.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ProcessShipmentResponse {\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  GroupName: ").Append(GroupName).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
