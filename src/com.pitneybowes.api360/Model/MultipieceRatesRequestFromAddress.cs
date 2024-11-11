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
    /// description
    /// </summary>
    [DataContract(Name = "MultipieceRatesRequest_fromAddress")]
    public partial class MultipieceRatesRequestFromAddress : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipieceRatesRequestFromAddress" /> class.
        /// </summary>
        /// <param name="addressLine1">description.</param>
        /// <param name="cityTown">description.</param>
        /// <param name="stateProvince">description.</param>
        /// <param name="postalCode">description.</param>
        /// <param name="countryCode">description.</param>
        /// <param name="company">description.</param>
        /// <param name="name">description.</param>
        /// <param name="phone">description.</param>
        /// <param name="email">description.</param>
        /// <param name="residential">description.</param>
        public MultipieceRatesRequestFromAddress(string addressLine1 = default(string), string cityTown = default(string), string stateProvince = default(string), string postalCode = default(string), string countryCode = default(string), string company = default(string), string name = default(string), string phone = default(string), string email = default(string), bool residential = default(bool))
        {
            this.AddressLine1 = addressLine1;
            this.CityTown = cityTown;
            this.StateProvince = stateProvince;
            this.PostalCode = postalCode;
            this.CountryCode = countryCode;
            this.Company = company;
            this.Name = name;
            this.Phone = phone;
            this.Email = email;
            this.Residential = residential;
        }

        /// <summary>
        /// description
        /// </summary>
        /// <value>description</value>
        /// <example>27 Waterview Dr</example>
        [DataMember(Name = "addressLine1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// description
        /// </summary>
        /// <value>description</value>
        /// <example>Shelton</example>
        [DataMember(Name = "cityTown", EmitDefaultValue = false)]
        public string CityTown { get; set; }

        /// <summary>
        /// description
        /// </summary>
        /// <value>description</value>
        /// <example>CT</example>
        [DataMember(Name = "stateProvince", EmitDefaultValue = false)]
        public string StateProvince { get; set; }

        /// <summary>
        /// description
        /// </summary>
        /// <value>description</value>
        /// <example>06484-4301</example>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// description
        /// </summary>
        /// <value>description</value>
        /// <example>US</example>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// description
        /// </summary>
        /// <value>description</value>
        /// <example>ABC Company</example>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public string Company { get; set; }

        /// <summary>
        /// description
        /// </summary>
        /// <value>description</value>
        /// <example>Sasha Sekrotov</example>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// description
        /// </summary>
        /// <value>description</value>
        /// <example>323 555-1212</example>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// description
        /// </summary>
        /// <value>description</value>
        /// <example>rs.canid@gmail.com</example>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// description
        /// </summary>
        /// <value>description</value>
        [DataMember(Name = "residential", EmitDefaultValue = true)]
        public bool Residential { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MultipieceRatesRequestFromAddress {\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  CityTown: ").Append(CityTown).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Residential: ").Append(Residential).Append("\n");
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
