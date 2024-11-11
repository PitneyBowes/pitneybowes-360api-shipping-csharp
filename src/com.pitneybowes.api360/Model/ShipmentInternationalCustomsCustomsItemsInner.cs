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
    /// ShipmentInternationalCustomsCustomsItemsInner
    /// </summary>
    [DataContract(Name = "ShipmentInternational_customs_customsItems_inner")]
    public partial class ShipmentInternationalCustomsCustomsItemsInner : IValidatableObject
    {
        /// <summary>
        /// The unit of measurement. This field is required by the unitWeight object.
        /// </summary>
        /// <value>The unit of measurement. This field is required by the unitWeight object.</value>
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
        /// The unit of measurement. This field is required by the unitWeight object.
        /// </summary>
        /// <value>The unit of measurement. This field is required by the unitWeight object.</value>
        [DataMember(Name = "weightUnit", EmitDefaultValue = false)]
        public WeightUnitEnum? WeightUnit { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentInternationalCustomsCustomsItemsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipmentInternationalCustomsCustomsItemsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentInternationalCustomsCustomsItemsInner" /> class.
        /// </summary>
        /// <param name="description">A detailed description of the commodity, up to 255 characters. The description will appear on the customs form. If the shipment has multiple types of items, create a separate customsItems object for each. Each description will appear on the form. (required).</param>
        /// <param name="hSTariffCode">The destination country’s tariff-classification number (HS code) for the commodity. Most countries use the six-digit Harmonized System (HS) as the basis for their tariff classifications and then add digits for more detail. The maximum length for an HS code is 14 characters. The HS code will appear on the customs form. If the shipment has multiple types of items, create a separate customsItems object for each..</param>
        /// <param name="originCountryCode">The two-character ISO country code of the shipment’s origin country. Use ISO 3166-1 alpha-2 standard values..</param>
        /// <param name="quantity">Enter the total number of items of this type of commodity. (required).</param>
        /// <param name="unitPrice">The price of one item of this type of commodity. (required).</param>
        /// <param name="weightUnit">The unit of measurement. This field is required by the unitWeight object..</param>
        /// <param name="weight">The weight of the item..</param>
        public ShipmentInternationalCustomsCustomsItemsInner(string description = default(string), string hSTariffCode = default(string), string originCountryCode = default(string), decimal quantity = default(decimal), decimal unitPrice = default(decimal), WeightUnitEnum? weightUnit = default(WeightUnitEnum?), decimal weight = default(decimal))
        {
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for ShipmentInternationalCustomsCustomsItemsInner and cannot be null");
            }
            this.Description = description;
            this.Quantity = quantity;
            this.UnitPrice = unitPrice;
            this.HSTariffCode = hSTariffCode;
            this.OriginCountryCode = originCountryCode;
            this.WeightUnit = weightUnit;
            this.Weight = weight;
        }

        /// <summary>
        /// A detailed description of the commodity, up to 255 characters. The description will appear on the customs form. If the shipment has multiple types of items, create a separate customsItems object for each. Each description will appear on the form.
        /// </summary>
        /// <value>A detailed description of the commodity, up to 255 characters. The description will appear on the customs form. If the shipment has multiple types of items, create a separate customsItems object for each. Each description will appear on the form.</value>
        /// <example>Books</example>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The destination country’s tariff-classification number (HS code) for the commodity. Most countries use the six-digit Harmonized System (HS) as the basis for their tariff classifications and then add digits for more detail. The maximum length for an HS code is 14 characters. The HS code will appear on the customs form. If the shipment has multiple types of items, create a separate customsItems object for each.
        /// </summary>
        /// <value>The destination country’s tariff-classification number (HS code) for the commodity. Most countries use the six-digit Harmonized System (HS) as the basis for their tariff classifications and then add digits for more detail. The maximum length for an HS code is 14 characters. The HS code will appear on the customs form. If the shipment has multiple types of items, create a separate customsItems object for each.</value>
        /// <example>AST559</example>
        [DataMember(Name = "hSTariffCode", EmitDefaultValue = false)]
        public string HSTariffCode { get; set; }

        /// <summary>
        /// The two-character ISO country code of the shipment’s origin country. Use ISO 3166-1 alpha-2 standard values.
        /// </summary>
        /// <value>The two-character ISO country code of the shipment’s origin country. Use ISO 3166-1 alpha-2 standard values.</value>
        /// <example>US</example>
        [DataMember(Name = "originCountryCode", EmitDefaultValue = false)]
        public string OriginCountryCode { get; set; }

        /// <summary>
        /// Enter the total number of items of this type of commodity.
        /// </summary>
        /// <value>Enter the total number of items of this type of commodity.</value>
        /// <example>1</example>
        [DataMember(Name = "quantity", IsRequired = true, EmitDefaultValue = true)]
        public decimal Quantity { get; set; }

        /// <summary>
        /// The price of one item of this type of commodity.
        /// </summary>
        /// <value>The price of one item of this type of commodity.</value>
        /// <example>3000</example>
        [DataMember(Name = "unitPrice", IsRequired = true, EmitDefaultValue = true)]
        public decimal UnitPrice { get; set; }

        /// <summary>
        /// The weight of the item.
        /// </summary>
        /// <value>The weight of the item.</value>
        /// <example>0.1</example>
        [DataMember(Name = "weight", EmitDefaultValue = false)]
        public decimal Weight { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentInternationalCustomsCustomsItemsInner {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  HSTariffCode: ").Append(HSTariffCode).Append("\n");
            sb.Append("  OriginCountryCode: ").Append(OriginCountryCode).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
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