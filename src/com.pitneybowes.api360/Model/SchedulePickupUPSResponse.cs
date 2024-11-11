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
    /// SchedulePickupUPSResponse
    /// </summary>
    [DataContract(Name = "schedulePickupUPSResponse")]
    public partial class SchedulePickupUPSResponse : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulePickupUPSResponse" /> class.
        /// </summary>
        /// <param name="packageLocation">It specifies the location from where packages would be collected..</param>
        /// <param name="pickupConfirmationNumber">It displays the unique confirmation number of the pickup.</param>
        /// <param name="pickupId">It displays the unique pickup Id which can be further used to get scheduled PDF and cancel pdf if required..</param>
        /// <param name="carrier">It dispays the carrier.</param>
        /// <param name="carrierAccountId">It displays the carrier acount id which is used to create the shipment.</param>
        /// <param name="pickupAddress">pickupAddress.</param>
        /// <param name="shipmentIds">It indicates the shipmentIds for which pickup is scheduled..</param>
        /// <param name="pickupSummary">It displays the package details provided in the request..</param>
        /// <param name="additionalnotes">It displays additional comments or remarks provided in the request, it would be printed on the scheduled pickup document.</param>
        /// <param name="reference">It displays any reference information provided in the request..</param>
        /// <param name="pickupDateTime">It displays the scheduled pickup date and time (in UTC).</param>
        /// <param name="pickupTotalWeight">It displays the total package weight..</param>
        /// <param name="pickupTotalWeightUnit">It displays the weight unit..</param>
        /// <param name="pickupOptions">pickupOptions.</param>
        /// <param name="pickupRate">pickupRate.</param>
        public SchedulePickupUPSResponse(string packageLocation = default(string), string pickupConfirmationNumber = default(string), string pickupId = default(string), string carrier = default(string), string carrierAccountId = default(string), SchedulePickupDHLEXPResponsePickupAddress pickupAddress = default(SchedulePickupDHLEXPResponsePickupAddress), List<string> shipmentIds = default(List<string>), List<SchedulePickupUPSResponsePickupSummaryInner> pickupSummary = default(List<SchedulePickupUPSResponsePickupSummaryInner>), string additionalnotes = default(string), string reference = default(string), string pickupDateTime = default(string), decimal pickupTotalWeight = default(decimal), string pickupTotalWeightUnit = default(string), SchedulePickupUPSResponsePickupOptions pickupOptions = default(SchedulePickupUPSResponsePickupOptions), SchedulePickupUPSResponsePickupRate pickupRate = default(SchedulePickupUPSResponsePickupRate))
        {
            this.PackageLocation = packageLocation;
            this.PickupConfirmationNumber = pickupConfirmationNumber;
            this.PickupId = pickupId;
            this.Carrier = carrier;
            this.CarrierAccountId = carrierAccountId;
            this.PickupAddress = pickupAddress;
            this.ShipmentIds = shipmentIds;
            this.PickupSummary = pickupSummary;
            this.Additionalnotes = additionalnotes;
            this.Reference = reference;
            this.PickupDateTime = pickupDateTime;
            this.PickupTotalWeight = pickupTotalWeight;
            this.PickupTotalWeightUnit = pickupTotalWeightUnit;
            this.PickupOptions = pickupOptions;
            this.PickupRate = pickupRate;
        }

        /// <summary>
        /// It specifies the location from where packages would be collected.
        /// </summary>
        /// <value>It specifies the location from where packages would be collected.</value>
        /// <example>NONE</example>
        [DataMember(Name = "packageLocation", EmitDefaultValue = false)]
        public string PackageLocation { get; set; }

        /// <summary>
        /// It displays the unique confirmation number of the pickup
        /// </summary>
        /// <value>It displays the unique confirmation number of the pickup</value>
        /// <example>CBJ180121002626</example>
        [DataMember(Name = "pickupConfirmationNumber", EmitDefaultValue = false)]
        public string PickupConfirmationNumber { get; set; }

        /// <summary>
        /// It displays the unique pickup Id which can be further used to get scheduled PDF and cancel pdf if required.
        /// </summary>
        /// <value>It displays the unique pickup Id which can be further used to get scheduled PDF and cancel pdf if required.</value>
        /// <example>DHLEXP10191697701225617</example>
        [DataMember(Name = "pickupId", EmitDefaultValue = false)]
        public string PickupId { get; set; }

        /// <summary>
        /// It dispays the carrier
        /// </summary>
        /// <value>It dispays the carrier</value>
        /// <example>ups</example>
        [DataMember(Name = "carrier", EmitDefaultValue = false)]
        public string Carrier { get; set; }

        /// <summary>
        /// It displays the carrier acount id which is used to create the shipment
        /// </summary>
        /// <value>It displays the carrier acount id which is used to create the shipment</value>
        /// <example>j4pqLKjQ5dn</example>
        [DataMember(Name = "carrierAccountId", EmitDefaultValue = false)]
        public string CarrierAccountId { get; set; }

        /// <summary>
        /// Gets or Sets PickupAddress
        /// </summary>
        [DataMember(Name = "pickupAddress", EmitDefaultValue = false)]
        public SchedulePickupDHLEXPResponsePickupAddress PickupAddress { get; set; }

        /// <summary>
        /// It indicates the shipmentIds for which pickup is scheduled.
        /// </summary>
        /// <value>It indicates the shipmentIds for which pickup is scheduled.</value>
        [DataMember(Name = "shipmentIds", EmitDefaultValue = false)]
        public List<string> ShipmentIds { get; set; }

        /// <summary>
        /// It displays the package details provided in the request.
        /// </summary>
        /// <value>It displays the package details provided in the request.</value>
        [DataMember(Name = "pickupSummary", EmitDefaultValue = false)]
        public List<SchedulePickupUPSResponsePickupSummaryInner> PickupSummary { get; set; }

        /// <summary>
        /// It displays additional comments or remarks provided in the request, it would be printed on the scheduled pickup document
        /// </summary>
        /// <value>It displays additional comments or remarks provided in the request, it would be printed on the scheduled pickup document</value>
        /// <example>test notes</example>
        [DataMember(Name = "additionalnotes", EmitDefaultValue = false)]
        public string Additionalnotes { get; set; }

        /// <summary>
        /// It displays any reference information provided in the request.
        /// </summary>
        /// <value>It displays any reference information provided in the request.</value>
        /// <example>test reference</example>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// It displays the scheduled pickup date and time (in UTC)
        /// </summary>
        /// <value>It displays the scheduled pickup date and time (in UTC)</value>
        /// <example>2023-11-06T17:05:05Z</example>
        [DataMember(Name = "pickupDateTime", EmitDefaultValue = false)]
        public string PickupDateTime { get; set; }

        /// <summary>
        /// It displays the total package weight.
        /// </summary>
        /// <value>It displays the total package weight.</value>
        /// <example>16</example>
        [DataMember(Name = "pickupTotalWeight", EmitDefaultValue = false)]
        public decimal PickupTotalWeight { get; set; }

        /// <summary>
        /// It displays the weight unit.
        /// </summary>
        /// <value>It displays the weight unit.</value>
        /// <example>OZ</example>
        [DataMember(Name = "pickupTotalWeightUnit", EmitDefaultValue = false)]
        public string PickupTotalWeightUnit { get; set; }

        /// <summary>
        /// Gets or Sets PickupOptions
        /// </summary>
        [DataMember(Name = "pickupOptions", EmitDefaultValue = false)]
        public SchedulePickupUPSResponsePickupOptions PickupOptions { get; set; }

        /// <summary>
        /// Gets or Sets PickupRate
        /// </summary>
        [DataMember(Name = "pickupRate", EmitDefaultValue = false)]
        public SchedulePickupUPSResponsePickupRate PickupRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SchedulePickupUPSResponse {\n");
            sb.Append("  PackageLocation: ").Append(PackageLocation).Append("\n");
            sb.Append("  PickupConfirmationNumber: ").Append(PickupConfirmationNumber).Append("\n");
            sb.Append("  PickupId: ").Append(PickupId).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  CarrierAccountId: ").Append(CarrierAccountId).Append("\n");
            sb.Append("  PickupAddress: ").Append(PickupAddress).Append("\n");
            sb.Append("  ShipmentIds: ").Append(ShipmentIds).Append("\n");
            sb.Append("  PickupSummary: ").Append(PickupSummary).Append("\n");
            sb.Append("  Additionalnotes: ").Append(Additionalnotes).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
            sb.Append("  PickupDateTime: ").Append(PickupDateTime).Append("\n");
            sb.Append("  PickupTotalWeight: ").Append(PickupTotalWeight).Append("\n");
            sb.Append("  PickupTotalWeightUnit: ").Append(PickupTotalWeightUnit).Append("\n");
            sb.Append("  PickupOptions: ").Append(PickupOptions).Append("\n");
            sb.Append("  PickupRate: ").Append(PickupRate).Append("\n");
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
