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
    /// DomesticShipmentResponseV2
    /// </summary>
    [DataContract(Name = "domesticShipmentResponseV2")]
    public partial class DomesticShipmentResponseV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DomesticShipmentResponseV2" /> class.
        /// </summary>
        /// <param name="correlationId">Key assigned by the shipping system to the transaction..</param>
        /// <param name="shipmentId">The shipmentId, a unique identifier for an individual Shipment..</param>
        /// <param name="parcelTrackingNumber">The Tracking number given to the Parcel for tracking purpose..</param>
        /// <param name="labelLayout">It defines the layout of the shipping label..</param>
        /// <param name="parcel">parcel.</param>
        /// <param name="rate">rate.</param>
        /// <param name="references">references.</param>
        /// <param name="printStatus">Status of the Printed Label..</param>
        /// <param name="printError">printError.</param>
        /// <param name="fromAddress">fromAddress.</param>
        /// <param name="toAddress">toAddress.</param>
        /// <param name="shipmentOptions">shipmentOptions.</param>
        public DomesticShipmentResponseV2(string correlationId = default(string), string shipmentId = default(string), string parcelTrackingNumber = default(string), List<DomesticShipmentResponseV2LabelLayoutInner> labelLayout = default(List<DomesticShipmentResponseV2LabelLayoutInner>), ParcelV2 parcel = default(ParcelV2), RateResponseV2 rate = default(RateResponseV2), ReferenceV2 references = default(ReferenceV2), string printStatus = default(string), DomesticShipmentResponseV2PrintError printError = default(DomesticShipmentResponseV2PrintError), FromAddressV2Response fromAddress = default(FromAddressV2Response), ToAddressV2Response toAddress = default(ToAddressV2Response), ShipmentOptions shipmentOptions = default(ShipmentOptions))
        {
            this.CorrelationId = correlationId;
            this.ShipmentId = shipmentId;
            this.ParcelTrackingNumber = parcelTrackingNumber;
            this.LabelLayout = labelLayout;
            this.Parcel = parcel;
            this.Rate = rate;
            this.References = references;
            this.PrintStatus = printStatus;
            this.PrintError = printError;
            this.FromAddress = fromAddress;
            this.ToAddress = toAddress;
            this.ShipmentOptions = shipmentOptions;
        }

        /// <summary>
        /// Key assigned by the shipping system to the transaction.
        /// </summary>
        /// <value>Key assigned by the shipping system to the transaction.</value>
        /// <example>3e2a71cc421e40b7970db9d540b1c7f2</example>
        [DataMember(Name = "correlationId", EmitDefaultValue = false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// The shipmentId, a unique identifier for an individual Shipment.
        /// </summary>
        /// <value>The shipmentId, a unique identifier for an individual Shipment.</value>
        /// <example>PUROLATOR2200626443337314</example>
        [DataMember(Name = "shipmentId", EmitDefaultValue = false)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// The Tracking number given to the Parcel for tracking purpose.
        /// </summary>
        /// <value>The Tracking number given to the Parcel for tracking purpose.</value>
        /// <example>329039098457</example>
        [DataMember(Name = "parcelTrackingNumber", EmitDefaultValue = false)]
        public string ParcelTrackingNumber { get; set; }

        /// <summary>
        /// It defines the layout of the shipping label.
        /// </summary>
        /// <value>It defines the layout of the shipping label.</value>
        [DataMember(Name = "labelLayout", EmitDefaultValue = false)]
        public List<DomesticShipmentResponseV2LabelLayoutInner> LabelLayout { get; set; }

        /// <summary>
        /// Gets or Sets Parcel
        /// </summary>
        [DataMember(Name = "parcel", EmitDefaultValue = false)]
        public ParcelV2 Parcel { get; set; }

        /// <summary>
        /// Gets or Sets Rate
        /// </summary>
        [DataMember(Name = "rate", EmitDefaultValue = false)]
        public RateResponseV2 Rate { get; set; }

        /// <summary>
        /// Gets or Sets References
        /// </summary>
        [DataMember(Name = "references", EmitDefaultValue = false)]
        public ReferenceV2 References { get; set; }

        /// <summary>
        /// Status of the Printed Label.
        /// </summary>
        /// <value>Status of the Printed Label.</value>
        /// <example>submitted</example>
        [DataMember(Name = "printStatus", EmitDefaultValue = false)]
        public string PrintStatus { get; set; }

        /// <summary>
        /// Gets or Sets PrintError
        /// </summary>
        [DataMember(Name = "printError", EmitDefaultValue = false)]
        public DomesticShipmentResponseV2PrintError PrintError { get; set; }

        /// <summary>
        /// Gets or Sets FromAddress
        /// </summary>
        [DataMember(Name = "fromAddress", EmitDefaultValue = false)]
        public FromAddressV2Response FromAddress { get; set; }

        /// <summary>
        /// Gets or Sets ToAddress
        /// </summary>
        [DataMember(Name = "toAddress", EmitDefaultValue = false)]
        public ToAddressV2Response ToAddress { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentOptions
        /// </summary>
        [DataMember(Name = "shipmentOptions", EmitDefaultValue = false)]
        public ShipmentOptions ShipmentOptions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DomesticShipmentResponseV2 {\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  ParcelTrackingNumber: ").Append(ParcelTrackingNumber).Append("\n");
            sb.Append("  LabelLayout: ").Append(LabelLayout).Append("\n");
            sb.Append("  Parcel: ").Append(Parcel).Append("\n");
            sb.Append("  Rate: ").Append(Rate).Append("\n");
            sb.Append("  References: ").Append(References).Append("\n");
            sb.Append("  PrintStatus: ").Append(PrintStatus).Append("\n");
            sb.Append("  PrintError: ").Append(PrintError).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  ShipmentOptions: ").Append(ShipmentOptions).Append("\n");
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
