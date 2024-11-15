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
    /// ShipmentERRCoversheet
    /// </summary>
    [DataContract(Name = "ShipmentERRCoversheet")]
    public partial class ShipmentERRCoversheet : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentERRCoversheet" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipmentERRCoversheet() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentERRCoversheet" /> class.
        /// </summary>
        /// <param name="externalId">This is a user-defined value provided by users just for their reference. This is for mapping purpose against each shipment..</param>
        /// <param name="fromAddress">fromAddress (required).</param>
        /// <param name="toAddress">toAddress (required).</param>
        /// <param name="parcel">parcel (required).</param>
        /// <param name="carrierAccountId">A unique identifier associated with the user&#39;s registered USPS account which is used by client users while shipment process..</param>
        /// <param name="parcelType">&gt;-Packaging type varies as per USPS selected services, e.g., LTR, LGENV..</param>
        /// <param name="serviceId">&gt;-A unique identifier given to the carrier-specific service. ERR supports two services: First Class Mail (FCM) and Priority Mail (PM)..</param>
        /// <param name="dateOfShipment">The date when shipment gets created..</param>
        /// <param name="specialServices">specialServices.</param>
        /// <param name="shipmentOptions">shipmentOptions.</param>
        /// <param name="metadata">Additional metadata that needs to be stored for this shipment, can be added here. For now, &#x60;costAccountName&#x60; is supported..</param>
        public ShipmentERRCoversheet(string externalId = default(string), FromAddress fromAddress = default(FromAddress), ToAddress toAddress = default(ToAddress), Parcel parcel = default(Parcel), string carrierAccountId = default(string), string parcelType = default(string), string serviceId = default(string), string dateOfShipment = default(string), List<SpecialServiceERRInner> specialServices = default(List<SpecialServiceERRInner>), ShipmentOptionsERR shipmentOptions = default(ShipmentOptionsERR), List<ShipmentERRCoversheetMetadataInner> metadata = default(List<ShipmentERRCoversheetMetadataInner>))
        {
            // to ensure "fromAddress" is required (not null)
            if (fromAddress == null)
            {
                throw new ArgumentNullException("fromAddress is a required property for ShipmentERRCoversheet and cannot be null");
            }
            this.FromAddress = fromAddress;
            // to ensure "toAddress" is required (not null)
            if (toAddress == null)
            {
                throw new ArgumentNullException("toAddress is a required property for ShipmentERRCoversheet and cannot be null");
            }
            this.ToAddress = toAddress;
            // to ensure "parcel" is required (not null)
            if (parcel == null)
            {
                throw new ArgumentNullException("parcel is a required property for ShipmentERRCoversheet and cannot be null");
            }
            this.Parcel = parcel;
            this.ExternalId = externalId;
            this.CarrierAccountId = carrierAccountId;
            this.ParcelType = parcelType;
            this.ServiceId = serviceId;
            this.DateOfShipment = dateOfShipment;
            this.SpecialServices = specialServices;
            this.ShipmentOptions = shipmentOptions;
            this.Metadata = metadata;
        }

        /// <summary>
        /// This is a user-defined value provided by users just for their reference. This is for mapping purpose against each shipment.
        /// </summary>
        /// <value>This is a user-defined value provided by users just for their reference. This is for mapping purpose against each shipment.</value>
        [DataMember(Name = "externalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets FromAddress
        /// </summary>
        [DataMember(Name = "fromAddress", IsRequired = true, EmitDefaultValue = true)]
        public FromAddress FromAddress { get; set; }

        /// <summary>
        /// Gets or Sets ToAddress
        /// </summary>
        [DataMember(Name = "toAddress", IsRequired = true, EmitDefaultValue = true)]
        public ToAddress ToAddress { get; set; }

        /// <summary>
        /// Gets or Sets Parcel
        /// </summary>
        [DataMember(Name = "parcel", IsRequired = true, EmitDefaultValue = true)]
        public Parcel Parcel { get; set; }

        /// <summary>
        /// A unique identifier associated with the user&#39;s registered USPS account which is used by client users while shipment process.
        /// </summary>
        /// <value>A unique identifier associated with the user&#39;s registered USPS account which is used by client users while shipment process.</value>
        /// <example>asas2223</example>
        [DataMember(Name = "carrierAccountId", EmitDefaultValue = false)]
        public string CarrierAccountId { get; set; }

        /// <summary>
        /// &gt;-Packaging type varies as per USPS selected services, e.g., LTR, LGENV.
        /// </summary>
        /// <value>&gt;-Packaging type varies as per USPS selected services, e.g., LTR, LGENV.</value>
        /// <example>LTR</example>
        [DataMember(Name = "parcelType", EmitDefaultValue = false)]
        public string ParcelType { get; set; }

        /// <summary>
        /// &gt;-A unique identifier given to the carrier-specific service. ERR supports two services: First Class Mail (FCM) and Priority Mail (PM).
        /// </summary>
        /// <value>&gt;-A unique identifier given to the carrier-specific service. ERR supports two services: First Class Mail (FCM) and Priority Mail (PM).</value>
        /// <example>FCM</example>
        [DataMember(Name = "serviceId", EmitDefaultValue = false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The date when shipment gets created.
        /// </summary>
        /// <value>The date when shipment gets created.</value>
        /// <example>2023-04-03</example>
        [DataMember(Name = "dateOfShipment", EmitDefaultValue = false)]
        public string DateOfShipment { get; set; }

        /// <summary>
        /// Gets or Sets SpecialServices
        /// </summary>
        /// <example>[{&quot;specialServiceID&quot;:&quot;ERR&quot;},{&quot;specialServiceID&quot;:&quot;Cert&quot;},{&quot;specialServiceID&quot;:&quot;CertRD&quot;}]</example>
        [DataMember(Name = "specialServices", EmitDefaultValue = false)]
        public List<SpecialServiceERRInner> SpecialServices { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentOptions
        /// </summary>
        [DataMember(Name = "shipmentOptions", EmitDefaultValue = false)]
        public ShipmentOptionsERR ShipmentOptions { get; set; }

        /// <summary>
        /// Additional metadata that needs to be stored for this shipment, can be added here. For now, &#x60;costAccountName&#x60; is supported.
        /// </summary>
        /// <value>Additional metadata that needs to be stored for this shipment, can be added here. For now, &#x60;costAccountName&#x60; is supported.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public List<ShipmentERRCoversheetMetadataInner> Metadata { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentERRCoversheet {\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
            sb.Append("  Parcel: ").Append(Parcel).Append("\n");
            sb.Append("  CarrierAccountId: ").Append(CarrierAccountId).Append("\n");
            sb.Append("  ParcelType: ").Append(ParcelType).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  DateOfShipment: ").Append(DateOfShipment).Append("\n");
            sb.Append("  SpecialServices: ").Append(SpecialServices).Append("\n");
            sb.Append("  ShipmentOptions: ").Append(ShipmentOptions).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
