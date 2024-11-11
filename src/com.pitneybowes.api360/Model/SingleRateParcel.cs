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
    /// Parcel dimension, weight and respective unit of measurement
    /// </summary>
    [DataContract(Name = "singleRate_parcel")]
    public partial class SingleRateParcel : IValidatableObject
    {
        /// <summary>
        /// DimUnit is a standard for measuring the physical quantities of specified dimension parameters.
        /// </summary>
        /// <value>DimUnit is a standard for measuring the physical quantities of specified dimension parameters.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DimUnitEnum
        {
            /// <summary>
            /// Enum IN for value: IN
            /// </summary>
            [EnumMember(Value = "IN")]
            IN = 1
        }


        /// <summary>
        /// DimUnit is a standard for measuring the physical quantities of specified dimension parameters.
        /// </summary>
        /// <value>DimUnit is a standard for measuring the physical quantities of specified dimension parameters.</value>
        /// <example>IN</example>
        [DataMember(Name = "dimUnit", IsRequired = true, EmitDefaultValue = true)]
        public DimUnitEnum DimUnit { get; set; }
        /// <summary>
        /// WeightUnit is a standard for measuring the physical quantities of specified weight.
        /// </summary>
        /// <value>WeightUnit is a standard for measuring the physical quantities of specified weight.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WeightUnitEnum
        {
            /// <summary>
            /// Enum OZ for value: OZ
            /// </summary>
            [EnumMember(Value = "OZ")]
            OZ = 1
        }


        /// <summary>
        /// WeightUnit is a standard for measuring the physical quantities of specified weight.
        /// </summary>
        /// <value>WeightUnit is a standard for measuring the physical quantities of specified weight.</value>
        /// <example>OZ</example>
        [DataMember(Name = "weightUnit", IsRequired = true, EmitDefaultValue = true)]
        public WeightUnitEnum WeightUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleRateParcel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SingleRateParcel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SingleRateParcel" /> class.
        /// </summary>
        /// <param name="height">Height is a part of Dimension objet where it helps determine a parcel’s girth. (required).</param>
        /// <param name="length">Length is a part of Dimension objet having highest numeric value out of three required parameters (length, width, and height) of Dimension. It helps determine a parcel’s girth. (required).</param>
        /// <param name="width">Width is a part of Dimension object having lowest numeric value out of three required parameters of dimension (length, width, and height). This helps determine a parcel’s girth. (required).</param>
        /// <param name="dimUnit">DimUnit is a standard for measuring the physical quantities of specified dimension parameters. (required).</param>
        /// <param name="weightUnit">WeightUnit is a standard for measuring the physical quantities of specified weight. (required).</param>
        /// <param name="weight">Weight is the measure of how heavy an object is (required).</param>
        public SingleRateParcel(decimal height = default(decimal), decimal length = default(decimal), decimal width = default(decimal), DimUnitEnum dimUnit = default(DimUnitEnum), WeightUnitEnum weightUnit = default(WeightUnitEnum), decimal weight = default(decimal))
        {
            this.Height = height;
            this.Length = length;
            this.Width = width;
            this.DimUnit = dimUnit;
            this.WeightUnit = weightUnit;
            this.Weight = weight;
        }

        /// <summary>
        /// Height is a part of Dimension objet where it helps determine a parcel’s girth.
        /// </summary>
        /// <value>Height is a part of Dimension objet where it helps determine a parcel’s girth.</value>
        /// <example>1</example>
        [DataMember(Name = "height", IsRequired = true, EmitDefaultValue = true)]
        public decimal Height { get; set; }

        /// <summary>
        /// Length is a part of Dimension objet having highest numeric value out of three required parameters (length, width, and height) of Dimension. It helps determine a parcel’s girth.
        /// </summary>
        /// <value>Length is a part of Dimension objet having highest numeric value out of three required parameters (length, width, and height) of Dimension. It helps determine a parcel’s girth.</value>
        /// <example>2</example>
        [DataMember(Name = "length", IsRequired = true, EmitDefaultValue = true)]
        public decimal Length { get; set; }

        /// <summary>
        /// Width is a part of Dimension object having lowest numeric value out of three required parameters of dimension (length, width, and height). This helps determine a parcel’s girth.
        /// </summary>
        /// <value>Width is a part of Dimension object having lowest numeric value out of three required parameters of dimension (length, width, and height). This helps determine a parcel’s girth.</value>
        /// <example>1</example>
        [DataMember(Name = "width", IsRequired = true, EmitDefaultValue = true)]
        public decimal Width { get; set; }

        /// <summary>
        /// Weight is the measure of how heavy an object is
        /// </summary>
        /// <value>Weight is the measure of how heavy an object is</value>
        /// <example>1</example>
        [DataMember(Name = "weight", IsRequired = true, EmitDefaultValue = true)]
        public decimal Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SingleRateParcel {\n");
            sb.Append("  Height: ").Append(Height).Append("\n");
            sb.Append("  Length: ").Append(Length).Append("\n");
            sb.Append("  Width: ").Append(Width).Append("\n");
            sb.Append("  DimUnit: ").Append(DimUnit).Append("\n");
            sb.Append("  WeightUnit: ").Append(WeightUnit).Append("\n");
            sb.Append("  Weight: ").Append(Weight).Append("\n");
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
