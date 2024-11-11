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
    /// This field will either be part of the request or response payload or will be marked as a custom field. We need to pass this field only if we need to print it on the label.
    /// </summary>
    [DataContract(Name = "docTabItem")]
    public partial class DocTabItem : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DocTabItem" /> class.
        /// </summary>
        /// <param name="displayName">This is a mandatory field. It will be displayed on the label.</param>
        /// <param name="value">If the field is part of a request or response, the value will be picked up from there. In the case of custom fields, the user-provided value will be printed..</param>
        /// <param name="row">Row Position of the Item. The min value is 1..</param>
        /// <param name="column">Column Position of the Item. The min value is 1..</param>
        public DocTabItem(string displayName = default(string), string value = default(string), int row = default(int), int column = default(int))
        {
            this.DisplayName = displayName;
            this.Value = value;
            this.Row = row;
            this.Column = column;
        }

        /// <summary>
        /// This is a mandatory field. It will be displayed on the label
        /// </summary>
        /// <value>This is a mandatory field. It will be displayed on the label</value>
        /// <example>TO</example>
        [DataMember(Name = "displayName", EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// If the field is part of a request or response, the value will be picked up from there. In the case of custom fields, the user-provided value will be printed.
        /// </summary>
        /// <value>If the field is part of a request or response, the value will be picked up from there. In the case of custom fields, the user-provided value will be printed.</value>
        /// <example>Test1</example>
        [DataMember(Name = "value", EmitDefaultValue = false)]
        public string Value { get; set; }

        /// <summary>
        /// Row Position of the Item. The min value is 1.
        /// </summary>
        /// <value>Row Position of the Item. The min value is 1.</value>
        /// <example>1</example>
        [DataMember(Name = "row", EmitDefaultValue = false)]
        public int Row { get; set; }

        /// <summary>
        /// Column Position of the Item. The min value is 1.
        /// </summary>
        /// <value>Column Position of the Item. The min value is 1.</value>
        /// <example>1</example>
        [DataMember(Name = "column", EmitDefaultValue = false)]
        public int Column { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DocTabItem {\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Row: ").Append(Row).Append("\n");
            sb.Append("  Column: ").Append(Column).Append("\n");
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