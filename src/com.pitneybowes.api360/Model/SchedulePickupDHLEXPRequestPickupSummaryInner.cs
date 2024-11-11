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
    /// SchedulePickupDHLEXPRequestPickupSummaryInner
    /// </summary>
    [DataContract(Name = "schedulePickupDHLEXPRequest_pickupSummary_inner")]
    public partial class SchedulePickupDHLEXPRequestPickupSummaryInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulePickupDHLEXPRequestPickupSummaryInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SchedulePickupDHLEXPRequestPickupSummaryInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SchedulePickupDHLEXPRequestPickupSummaryInner" /> class.
        /// </summary>
        /// <param name="serviceId">The service id (required).</param>
        /// <param name="packageCount">The total number of packages (required).</param>
        /// <param name="totalWeight">The total weight of the packages (required).</param>
        /// <param name="weightUnit">Weight Unit, supported values are &#x60;OZ&#x60; and &#x60;GM&#x60; (required).</param>
        /// <param name="currencyCode">Currency code (required).</param>
        /// <param name="totalCustomsDeclaredValue">It indicates the custom declared value. It is required in case of international shipment..</param>
        /// <param name="packageDetails">It descibes the individual package details (required).</param>
        public SchedulePickupDHLEXPRequestPickupSummaryInner(string serviceId = default(string), decimal packageCount = default(decimal), decimal totalWeight = default(decimal), string weightUnit = default(string), string currencyCode = default(string), decimal totalCustomsDeclaredValue = default(decimal), List<SchedulePickupDHLEXPRequestPickupSummaryInnerPackageDetailsInner> packageDetails = default(List<SchedulePickupDHLEXPRequestPickupSummaryInnerPackageDetailsInner>))
        {
            // to ensure "serviceId" is required (not null)
            if (serviceId == null)
            {
                throw new ArgumentNullException("serviceId is a required property for SchedulePickupDHLEXPRequestPickupSummaryInner and cannot be null");
            }
            this.ServiceId = serviceId;
            this.PackageCount = packageCount;
            this.TotalWeight = totalWeight;
            // to ensure "weightUnit" is required (not null)
            if (weightUnit == null)
            {
                throw new ArgumentNullException("weightUnit is a required property for SchedulePickupDHLEXPRequestPickupSummaryInner and cannot be null");
            }
            this.WeightUnit = weightUnit;
            // to ensure "currencyCode" is required (not null)
            if (currencyCode == null)
            {
                throw new ArgumentNullException("currencyCode is a required property for SchedulePickupDHLEXPRequestPickupSummaryInner and cannot be null");
            }
            this.CurrencyCode = currencyCode;
            // to ensure "packageDetails" is required (not null)
            if (packageDetails == null)
            {
                throw new ArgumentNullException("packageDetails is a required property for SchedulePickupDHLEXPRequestPickupSummaryInner and cannot be null");
            }
            this.PackageDetails = packageDetails;
            this.TotalCustomsDeclaredValue = totalCustomsDeclaredValue;
        }

        /// <summary>
        /// The service id
        /// </summary>
        /// <value>The service id</value>
        /// <example>NDA</example>
        [DataMember(Name = "serviceId", IsRequired = true, EmitDefaultValue = true)]
        public string ServiceId { get; set; }

        /// <summary>
        /// The total number of packages
        /// </summary>
        /// <value>The total number of packages</value>
        /// <example>2</example>
        [DataMember(Name = "packageCount", IsRequired = true, EmitDefaultValue = true)]
        public decimal PackageCount { get; set; }

        /// <summary>
        /// The total weight of the packages
        /// </summary>
        /// <value>The total weight of the packages</value>
        /// <example>15</example>
        [DataMember(Name = "totalWeight", IsRequired = true, EmitDefaultValue = true)]
        public decimal TotalWeight { get; set; }

        /// <summary>
        /// Weight Unit, supported values are &#x60;OZ&#x60; and &#x60;GM&#x60;
        /// </summary>
        /// <value>Weight Unit, supported values are &#x60;OZ&#x60; and &#x60;GM&#x60;</value>
        /// <example>OZ</example>
        [DataMember(Name = "weightUnit", IsRequired = true, EmitDefaultValue = true)]
        public string WeightUnit { get; set; }

        /// <summary>
        /// Currency code
        /// </summary>
        /// <value>Currency code</value>
        /// <example>USD</example>
        [DataMember(Name = "currencyCode", IsRequired = true, EmitDefaultValue = true)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// It indicates the custom declared value. It is required in case of international shipment.
        /// </summary>
        /// <value>It indicates the custom declared value. It is required in case of international shipment.</value>
        /// <example>100</example>
        [DataMember(Name = "totalCustomsDeclaredValue", EmitDefaultValue = false)]
        public decimal TotalCustomsDeclaredValue { get; set; }

        /// <summary>
        /// It descibes the individual package details
        /// </summary>
        /// <value>It descibes the individual package details</value>
        [DataMember(Name = "packageDetails", IsRequired = true, EmitDefaultValue = true)]
        public List<SchedulePickupDHLEXPRequestPickupSummaryInnerPackageDetailsInner> PackageDetails { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SchedulePickupDHLEXPRequestPickupSummaryInner {\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  PackageCount: ").Append(PackageCount).Append("\n");
            sb.Append("  TotalWeight: ").Append(TotalWeight).Append("\n");
            sb.Append("  WeightUnit: ").Append(WeightUnit).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  TotalCustomsDeclaredValue: ").Append(TotalCustomsDeclaredValue).Append("\n");
            sb.Append("  PackageDetails: ").Append(PackageDetails).Append("\n");
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
