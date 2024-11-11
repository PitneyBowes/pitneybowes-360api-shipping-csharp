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
    /// ManifestDetailedResponseFromAddress
    /// </summary>
    [DataContract(Name = "ManifestDetailedResponse_fromAddress")]
    public partial class ManifestDetailedResponseFromAddress : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ManifestDetailedResponseFromAddress" /> class.
        /// </summary>
        /// <param name="addressLine1">The addressLine1 can contain the Flat number, Building or Apartment Name/number (if any) or company name (if not residential)..</param>
        /// <param name="addressLine2">The addressLine2 contains Street address or Landmark (if any)..</param>
        /// <param name="addressLine3">The addressLine3 contains P.O.Box (if any) near the address..</param>
        /// <param name="cityTown">The name of the city or town to where the address belongs..</param>
        /// <param name="countryCode">This indicates the two-character ISO code of the source country from the ISO country list..</param>
        /// <param name="postalCode">The postal code or ZIP code of the address. For US addresses, use either the 5-digit or 9-digit ZIP code in one of the following formats: &#39;12345&#39; or &#39;12345-6789&#39;. If you use a different format, such as 12345- or 123451234, will receive an error..</param>
        /// <param name="residential">The specified adress can be Residential or Official. In case if the adress is Residential, the boolean value will be &#39;true&#39;, else it will take &#39;false&#39;..</param>
        /// <param name="stateProvince">The State or Province of the address. For a US or Canadian address, it is the 2-letter state or province code. .</param>
        public ManifestDetailedResponseFromAddress(string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string cityTown = default(string), string countryCode = default(string), string postalCode = default(string), bool residential = default(bool), string stateProvince = default(string))
        {
            this.AddressLine1 = addressLine1;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.CityTown = cityTown;
            this.CountryCode = countryCode;
            this.PostalCode = postalCode;
            this.Residential = residential;
            this.StateProvince = stateProvince;
        }

        /// <summary>
        /// The addressLine1 can contain the Flat number, Building or Apartment Name/number (if any) or company name (if not residential).
        /// </summary>
        /// <value>The addressLine1 can contain the Flat number, Building or Apartment Name/number (if any) or company name (if not residential).</value>
        /// <example>27 Watervw Dr</example>
        [DataMember(Name = "addressLine1", EmitDefaultValue = false)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The addressLine2 contains Street address or Landmark (if any).
        /// </summary>
        /// <value>The addressLine2 contains Street address or Landmark (if any).</value>
        /// <example>near abc street</example>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The addressLine3 contains P.O.Box (if any) near the address.
        /// </summary>
        /// <value>The addressLine3 contains P.O.Box (if any) near the address.</value>
        /// <example>near xyz street</example>
        [DataMember(Name = "addressLine3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// The name of the city or town to where the address belongs.
        /// </summary>
        /// <value>The name of the city or town to where the address belongs.</value>
        /// <example>Stamford</example>
        [DataMember(Name = "cityTown", EmitDefaultValue = false)]
        public string CityTown { get; set; }

        /// <summary>
        /// This indicates the two-character ISO code of the source country from the ISO country list.
        /// </summary>
        /// <value>This indicates the two-character ISO code of the source country from the ISO country list.</value>
        /// <example>US</example>
        [DataMember(Name = "countryCode", EmitDefaultValue = false)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The postal code or ZIP code of the address. For US addresses, use either the 5-digit or 9-digit ZIP code in one of the following formats: &#39;12345&#39; or &#39;12345-6789&#39;. If you use a different format, such as 12345- or 123451234, will receive an error.
        /// </summary>
        /// <value>The postal code or ZIP code of the address. For US addresses, use either the 5-digit or 9-digit ZIP code in one of the following formats: &#39;12345&#39; or &#39;12345-6789&#39;. If you use a different format, such as 12345- or 123451234, will receive an error.</value>
        /// <example>06905</example>
        [DataMember(Name = "postalCode", EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The specified adress can be Residential or Official. In case if the adress is Residential, the boolean value will be &#39;true&#39;, else it will take &#39;false&#39;.
        /// </summary>
        /// <value>The specified adress can be Residential or Official. In case if the adress is Residential, the boolean value will be &#39;true&#39;, else it will take &#39;false&#39;.</value>
        /// <example>false</example>
        [DataMember(Name = "residential", EmitDefaultValue = true)]
        public bool Residential { get; set; }

        /// <summary>
        /// The State or Province of the address. For a US or Canadian address, it is the 2-letter state or province code. 
        /// </summary>
        /// <value>The State or Province of the address. For a US or Canadian address, it is the 2-letter state or province code. </value>
        /// <example>CT</example>
        [DataMember(Name = "stateProvince", EmitDefaultValue = false)]
        public string StateProvince { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ManifestDetailedResponseFromAddress {\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  CityTown: ").Append(CityTown).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Residential: ").Append(Residential).Append("\n");
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
