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
    /// DefaultResponse
    /// </summary>
    [DataContract(Name = "DefaultResponse")]
    public partial class DefaultResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DefaultResponse" /> class.
        /// </summary>
        /// <param name="name">Name of the created Default. For example: Domestic..</param>
        /// <param name="defaultID">Unique identifier assigned to the Default while its creation using CreateDefaults API..</param>
        /// <param name="createdDate">The timestamp when the Default is created..</param>
        /// <param name="updatedDate">The timestamp when the Default is updated..</param>
        /// <param name="sendingOptions">sendingOptions.</param>
        public DefaultResponse(string name = default(string), string defaultID = default(string), string createdDate = default(string), string updatedDate = default(string), SendingOptionsResponse sendingOptions = default(SendingOptionsResponse))
        {
            this.Name = name;
            this.DefaultID = defaultID;
            this.CreatedDate = createdDate;
            this.UpdatedDate = updatedDate;
            this.SendingOptions = sendingOptions;
        }

        /// <summary>
        /// Name of the created Default. For example: Domestic.
        /// </summary>
        /// <value>Name of the created Default. For example: Domestic.</value>
        /// <example>Domestic</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Unique identifier assigned to the Default while its creation using CreateDefaults API.
        /// </summary>
        /// <value>Unique identifier assigned to the Default while its creation using CreateDefaults API.</value>
        /// <example>0d4f3c51-059b-4c28-a83b-a8defa2962cc</example>
        [DataMember(Name = "defaultID", EmitDefaultValue = false)]
        public string DefaultID { get; set; }

        /// <summary>
        /// The timestamp when the Default is created.
        /// </summary>
        /// <value>The timestamp when the Default is created.</value>
        /// <example>2024-08-06T06:12:46.258Z</example>
        [DataMember(Name = "createdDate", EmitDefaultValue = false)]
        public string CreatedDate { get; set; }

        /// <summary>
        /// The timestamp when the Default is updated.
        /// </summary>
        /// <value>The timestamp when the Default is updated.</value>
        /// <example>2024-08-06T06:12:46.258Z</example>
        [DataMember(Name = "updatedDate", EmitDefaultValue = false)]
        public string UpdatedDate { get; set; }

        /// <summary>
        /// Gets or Sets SendingOptions
        /// </summary>
        [DataMember(Name = "sendingOptions", EmitDefaultValue = false)]
        public SendingOptionsResponse SendingOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DefaultResponse {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DefaultID: ").Append(DefaultID).Append("\n");
            sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
            sb.Append("  UpdatedDate: ").Append(UpdatedDate).Append("\n");
            sb.Append("  SendingOptions: ").Append(SendingOptions).Append("\n");
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
