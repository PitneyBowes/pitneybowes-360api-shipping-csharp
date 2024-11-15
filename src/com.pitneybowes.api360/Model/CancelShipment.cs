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
    /// CancelShipment
    /// </summary>
    [DataContract(Name = "cancelShipment")]
    public partial class CancelShipment : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CancelShipment" /> class.
        /// </summary>
        /// <param name="carrier">The name of the Carrier..</param>
        /// <param name="totalCarrierCharge">The total amount payable to the carrier, including special service fees, surcharges, and any international taxes and duties, except as noted below:.</param>
        /// <param name="parcelTrackingNumber">The Tracking number given to the Parcel for tracking purpose..</param>
        /// <param name="status">Status of the Shipment..</param>
        public CancelShipment(string carrier = default(string), decimal totalCarrierCharge = default(decimal), string parcelTrackingNumber = default(string), string status = default(string))
        {
            this.Carrier = carrier;
            this.TotalCarrierCharge = totalCarrierCharge;
            this.ParcelTrackingNumber = parcelTrackingNumber;
            this.Status = status;
        }

        /// <summary>
        /// The name of the Carrier.
        /// </summary>
        /// <value>The name of the Carrier.</value>
        /// <example>USPS</example>
        [DataMember(Name = "carrier", EmitDefaultValue = false)]
        public string Carrier { get; set; }

        /// <summary>
        /// The total amount payable to the carrier, including special service fees, surcharges, and any international taxes and duties, except as noted below:
        /// </summary>
        /// <value>The total amount payable to the carrier, including special service fees, surcharges, and any international taxes and duties, except as noted below:</value>
        /// <example>0</example>
        [DataMember(Name = "totalCarrierCharge", EmitDefaultValue = false)]
        public decimal TotalCarrierCharge { get; set; }

        /// <summary>
        /// The Tracking number given to the Parcel for tracking purpose.
        /// </summary>
        /// <value>The Tracking number given to the Parcel for tracking purpose.</value>
        /// <example>9471309105156000624885</example>
        [DataMember(Name = "parcelTrackingNumber", EmitDefaultValue = false)]
        public string ParcelTrackingNumber { get; set; }

        /// <summary>
        /// Status of the Shipment.
        /// </summary>
        /// <value>Status of the Shipment.</value>
        /// <example>INITIATED</example>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CancelShipment {\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  TotalCarrierCharge: ").Append(TotalCarrierCharge).Append("\n");
            sb.Append("  ParcelTrackingNumber: ").Append(ParcelTrackingNumber).Append("\n");
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
