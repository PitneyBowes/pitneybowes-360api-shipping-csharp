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
    /// ShipmentInternationalToAddress
    /// </summary>
    [DataContract(Name = "ShipmentInternational_toAddress")]
    public partial class ShipmentInternationalToAddress : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentInternationalToAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipmentInternationalToAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentInternationalToAddress" /> class.
        /// </summary>
        /// <param name="addressLine1">addressLine1 (required).</param>
        /// <param name="addressLine2">addressLine2.</param>
        /// <param name="addressLine3">addressLine3.</param>
        /// <param name="cityTown">cityTown.</param>
        /// <param name="countryCode">countryCode (required).</param>
        /// <param name="name">name.</param>
        /// <param name="phone">phone.</param>
        /// <param name="postalCode">postalCode (required).</param>
        /// <param name="stateProvince">stateProvince (required).</param>
        public ShipmentInternationalToAddress(string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string cityTown = default(string), string countryCode = default(string), string name = default(string), string phone = default(string), string postalCode = default(string), string stateProvince = default(string))
        {
            // to ensure "addressLine1" is required (not null)
            if (addressLine1 == null)
            {
                throw new ArgumentNullException("addressLine1 is a required property for ShipmentInternationalToAddress and cannot be null");
            }
            this.AddressLine1 = addressLine1;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for ShipmentInternationalToAddress and cannot be null");
            }
            this.CountryCode = countryCode;
            // to ensure "postalCode" is required (not null)
            if (postalCode == null)
            {
                throw new ArgumentNullException("postalCode is a required property for ShipmentInternationalToAddress and cannot be null");
            }
            this.PostalCode = postalCode;
            // to ensure "stateProvince" is required (not null)
            if (stateProvince == null)
            {
                throw new ArgumentNullException("stateProvince is a required property for ShipmentInternationalToAddress and cannot be null");
            }
            this.StateProvince = stateProvince;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.CityTown = cityTown;
            this.Name = name;
            this.Phone = phone;
        }

        /// <summary>
        /// Gets or Sets AddressLine1
        /// </summary>
        /// <example>70 Hanlan RD</example>
        [DataMember(Name = "addressLine1", IsRequired = true, EmitDefaultValue = true)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine2
        /// </summary>
        /// <example>near abc street</example>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// Gets or Sets AddressLine3
        /// </summary>
        /// <example>near xyz street</example>
        [DataMember(Name = "addressLine3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// Gets or Sets CityTown
        /// </summary>
        /// <example>Woodbridge</example>
        [DataMember(Name = "cityTown", EmitDefaultValue = false)]
        public string CityTown { get; set; }

        /// <summary>
        /// Gets or Sets CountryCode
        /// </summary>
        /// <example>CA</example>
        [DataMember(Name = "countryCode", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        /// <example>Paul Wright</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Phone
        /// </summary>
        /// <example>203-555-1213</example>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        /// <example>L4L3P6</example>
        [DataMember(Name = "postalCode", IsRequired = true, EmitDefaultValue = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets StateProvince
        /// </summary>
        /// <example>ON</example>
        [DataMember(Name = "stateProvince", IsRequired = true, EmitDefaultValue = true)]
        public string StateProvince { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentInternationalToAddress {\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  CityTown: ").Append(CityTown).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
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
