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
    /// ParcelTypesInnerDimensionRulesInner
    /// </summary>
    [DataContract(Name = "parcelTypes_inner_dimensionRules_inner")]
    public partial class ParcelTypesInnerDimensionRulesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ParcelTypesInnerDimensionRulesInner" /> class.
        /// </summary>
        /// <param name="maxLengthPlusGirth">This measures the parcel&#39;s maximum length and determine parcel’s girth..</param>
        /// <param name="maxParcelDimensions">maxParcelDimensions.</param>
        /// <param name="minLengthPlusGirth">This measures the parcel&#39;s minimum length and determine parcel’s girth..</param>
        /// <param name="minParcelDimensions">minParcelDimensions.</param>
        /// <param name="required">required.</param>
        /// <param name="unitOfMeasurement">UnitofMesurement is a standard for measuring the physical quantities of specified dimension parameters..</param>
        public ParcelTypesInnerDimensionRulesInner(decimal maxLengthPlusGirth = default(decimal), ParcelTypesInnerDimensionRulesInnerMaxParcelDimensions maxParcelDimensions = default(ParcelTypesInnerDimensionRulesInnerMaxParcelDimensions), decimal minLengthPlusGirth = default(decimal), ParcelTypesInnerDimensionRulesInnerMinParcelDimensions minParcelDimensions = default(ParcelTypesInnerDimensionRulesInnerMinParcelDimensions), bool required = default(bool), string unitOfMeasurement = default(string))
        {
            this.MaxLengthPlusGirth = maxLengthPlusGirth;
            this.MaxParcelDimensions = maxParcelDimensions;
            this.MinLengthPlusGirth = minLengthPlusGirth;
            this.MinParcelDimensions = minParcelDimensions;
            this.Required = required;
            this.UnitOfMeasurement = unitOfMeasurement;
        }

        /// <summary>
        /// This measures the parcel&#39;s maximum length and determine parcel’s girth.
        /// </summary>
        /// <value>This measures the parcel&#39;s maximum length and determine parcel’s girth.</value>
        /// <example>58</example>
        [DataMember(Name = "maxLengthPlusGirth", EmitDefaultValue = false)]
        public decimal MaxLengthPlusGirth { get; set; }

        /// <summary>
        /// Gets or Sets MaxParcelDimensions
        /// </summary>
        [DataMember(Name = "maxParcelDimensions", EmitDefaultValue = false)]
        public ParcelTypesInnerDimensionRulesInnerMaxParcelDimensions MaxParcelDimensions { get; set; }

        /// <summary>
        /// This measures the parcel&#39;s minimum length and determine parcel’s girth.
        /// </summary>
        /// <value>This measures the parcel&#39;s minimum length and determine parcel’s girth.</value>
        /// <example>0.001</example>
        [DataMember(Name = "minLengthPlusGirth", EmitDefaultValue = false)]
        public decimal MinLengthPlusGirth { get; set; }

        /// <summary>
        /// Gets or Sets MinParcelDimensions
        /// </summary>
        [DataMember(Name = "minParcelDimensions", EmitDefaultValue = false)]
        public ParcelTypesInnerDimensionRulesInnerMinParcelDimensions MinParcelDimensions { get; set; }

        /// <summary>
        /// Gets or Sets Required
        /// </summary>
        /// <example>true</example>
        [DataMember(Name = "required", EmitDefaultValue = true)]
        public bool Required { get; set; }

        /// <summary>
        /// UnitofMesurement is a standard for measuring the physical quantities of specified dimension parameters.
        /// </summary>
        /// <value>UnitofMesurement is a standard for measuring the physical quantities of specified dimension parameters.</value>
        /// <example>IN</example>
        [DataMember(Name = "unitOfMeasurement", EmitDefaultValue = false)]
        public string UnitOfMeasurement { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ParcelTypesInnerDimensionRulesInner {\n");
            sb.Append("  MaxLengthPlusGirth: ").Append(MaxLengthPlusGirth).Append("\n");
            sb.Append("  MaxParcelDimensions: ").Append(MaxParcelDimensions).Append("\n");
            sb.Append("  MinLengthPlusGirth: ").Append(MinLengthPlusGirth).Append("\n");
            sb.Append("  MinParcelDimensions: ").Append(MinParcelDimensions).Append("\n");
            sb.Append("  Required: ").Append(Required).Append("\n");
            sb.Append("  UnitOfMeasurement: ").Append(UnitOfMeasurement).Append("\n");
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
