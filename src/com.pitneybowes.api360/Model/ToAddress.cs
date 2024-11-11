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
    /// The complete address of the Recipient or Department (in case if the address is not pointed to any individual recipient).
    /// </summary>
    [DataContract(Name = "toAddress")]
    public partial class ToAddress : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ToAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ToAddress" /> class.
        /// </summary>
        /// <param name="name">The name of the Recipient. &lt;br /&gt; &#x60;Max length &#x3D; 40&#x60; (required).</param>
        /// <param name="addressLine1">The addressLine1 contains the Flat number, Building or Apartment Name/number (if any) or company name (if not residential) of the Recipient. &lt;br /&gt; &#x60;Max length &#x3D; 40&#x60; (required).</param>
        /// <param name="addressLine2">The addressLine2 contains the Area or Street Name. This is an optional field. &lt;br /&gt; &#x60;Max length &#x3D; 40&#x60;.</param>
        /// <param name="addressLine3">The addressLine3 contains other details for easy reach, e.g. Landmark. This is an optional field. &lt;br /&gt; &#x60;Max length &#x3D; 40&#x60;.</param>
        /// <param name="cityTown">The name of the city or town the Recipient belongs to. (required).</param>
        /// <param name="stateProvince">The name of the State or Province the Sender belongs to. It is the &#x60;2-letter&#x60; State or Province Code for US or Canadian address(es). &lt;br /&gt; Below is the hyperlink for CA country that will navigate to its Province/State Codes page. Similarly, respective country users can check for their country- State/Province codes. &lt;br /&gt; Please switch to the &#x60;Search&#x60; tab, select &#x60;Country codes&#x60; radio button, enter the required country name or country code, and then click &#x60;SEARCH&#x60; button . &lt;br /&gt; &#x60;Max length &#x3D; 2&#x60; (required).</param>
        /// <param name="postalCode">The Postal Code or ZIP Code of the address.&lt;br /&gt; For US addresses, use either the &#x60;5-digit&#x60; or &#x60;9-digit&#x60; ZIP Code in one of the following formats: &#39;12345&#39; or &#39;12345-6789&#39;. &lt;br /&gt; While for CA addresses, use a &#x60;six-character&#x60; alphanumeric string Postal Code in this format: &#39;A1A 1A1&#39;. ERR supports only US addresses.&lt;br /&gt; *NOTE: USPS supports only US location.* (required).</param>
        /// <param name="countryCode">The country in which the recipient&#39;s address is located. The value will be the two-character ISO Code of the country from the ISO country list. &lt;br /&gt; Use ISO 3166-1 Alpha-2 standard values. For best results this should be included, especially if the country name does not appear in any of the unparsedAddressLines. &lt;br /&gt; Below is the hyperlink, please select &#x60;Country codes&#x60; and then click &#x60;SEARCH&#x60; button.  &lt;br /&gt; *NOTE: USPS supports only US location.* (required).</param>
        /// <param name="company">The name of the company, in case if the Recipient address is not residential..</param>
        /// <param name="phone">This is recipient&#39;s phone number. Enter the digits with or without spaces or hyphens. &lt;br /&gt; &#x60;Max length &#x3D; 15&#x60;..</param>
        /// <param name="email">This must be recipients&#39;s valid email. &lt;br /&gt; &#x60;Max length &#x3D; 50&#x60; .</param>
        /// <param name="residential">The specified address can be Residential or Official. In case if the address is Residential, the boolean value will be &#39;true&#39;, else it will take &#39;false&#39;..</param>
        public ToAddress(string name = default(string), string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string cityTown = default(string), string stateProvince = default(string), string postalCode = default(string), string countryCode = default(string), string company = default(string), string phone = default(string), string email = default(string), bool residential = default(bool))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ToAddress and cannot be null");
            }
            this.Name = name;
            // to ensure "addressLine1" is required (not null)
            if (addressLine1 == null)
            {
                throw new ArgumentNullException("addressLine1 is a required property for ToAddress and cannot be null");
            }
            this.AddressLine1 = addressLine1;
            // to ensure "cityTown" is required (not null)
            if (cityTown == null)
            {
                throw new ArgumentNullException("cityTown is a required property for ToAddress and cannot be null");
            }
            this.CityTown = cityTown;
            // to ensure "stateProvince" is required (not null)
            if (stateProvince == null)
            {
                throw new ArgumentNullException("stateProvince is a required property for ToAddress and cannot be null");
            }
            this.StateProvince = stateProvince;
            // to ensure "postalCode" is required (not null)
            if (postalCode == null)
            {
                throw new ArgumentNullException("postalCode is a required property for ToAddress and cannot be null");
            }
            this.PostalCode = postalCode;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for ToAddress and cannot be null");
            }
            this.CountryCode = countryCode;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.Company = company;
            this.Phone = phone;
            this.Email = email;
            this.Residential = residential;
        }

        /// <summary>
        /// The name of the Recipient. &lt;br /&gt; &#x60;Max length &#x3D; 40&#x60;
        /// </summary>
        /// <value>The name of the Recipient. &lt;br /&gt; &#x60;Max length &#x3D; 40&#x60;</value>
        /// <example>John Smith</example>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The addressLine1 contains the Flat number, Building or Apartment Name/number (if any) or company name (if not residential) of the Recipient. &lt;br /&gt; &#x60;Max length &#x3D; 40&#x60;
        /// </summary>
        /// <value>The addressLine1 contains the Flat number, Building or Apartment Name/number (if any) or company name (if not residential) of the Recipient. &lt;br /&gt; &#x60;Max length &#x3D; 40&#x60;</value>
        /// <example>98 Watervw Dr</example>
        [DataMember(Name = "addressLine1", IsRequired = true, EmitDefaultValue = true)]
        public string AddressLine1 { get; set; }

        /// <summary>
        /// The addressLine2 contains the Area or Street Name. This is an optional field. &lt;br /&gt; &#x60;Max length &#x3D; 40&#x60;
        /// </summary>
        /// <value>The addressLine2 contains the Area or Street Name. This is an optional field. &lt;br /&gt; &#x60;Max length &#x3D; 40&#x60;</value>
        /// <example>Street-975</example>
        [DataMember(Name = "addressLine2", EmitDefaultValue = false)]
        public string AddressLine2 { get; set; }

        /// <summary>
        /// The addressLine3 contains other details for easy reach, e.g. Landmark. This is an optional field. &lt;br /&gt; &#x60;Max length &#x3D; 40&#x60;
        /// </summary>
        /// <value>The addressLine3 contains other details for easy reach, e.g. Landmark. This is an optional field. &lt;br /&gt; &#x60;Max length &#x3D; 40&#x60;</value>
        /// <example>Near ABC Tower</example>
        [DataMember(Name = "addressLine3", EmitDefaultValue = false)]
        public string AddressLine3 { get; set; }

        /// <summary>
        /// The name of the city or town the Recipient belongs to.
        /// </summary>
        /// <value>The name of the city or town the Recipient belongs to.</value>
        /// <example>Shelton</example>
        [DataMember(Name = "cityTown", IsRequired = true, EmitDefaultValue = true)]
        public string CityTown { get; set; }

        /// <summary>
        /// The name of the State or Province the Sender belongs to. It is the &#x60;2-letter&#x60; State or Province Code for US or Canadian address(es). &lt;br /&gt; Below is the hyperlink for CA country that will navigate to its Province/State Codes page. Similarly, respective country users can check for their country- State/Province codes. &lt;br /&gt; Please switch to the &#x60;Search&#x60; tab, select &#x60;Country codes&#x60; radio button, enter the required country name or country code, and then click &#x60;SEARCH&#x60; button . &lt;br /&gt; &#x60;Max length &#x3D; 2&#x60;
        /// </summary>
        /// <value>The name of the State or Province the Sender belongs to. It is the &#x60;2-letter&#x60; State or Province Code for US or Canadian address(es). &lt;br /&gt; Below is the hyperlink for CA country that will navigate to its Province/State Codes page. Similarly, respective country users can check for their country- State/Province codes. &lt;br /&gt; Please switch to the &#x60;Search&#x60; tab, select &#x60;Country codes&#x60; radio button, enter the required country name or country code, and then click &#x60;SEARCH&#x60; button . &lt;br /&gt; &#x60;Max length &#x3D; 2&#x60;</value>
        /// <example>CT</example>
        [DataMember(Name = "stateProvince", IsRequired = true, EmitDefaultValue = true)]
        public string StateProvince { get; set; }

        /// <summary>
        /// The Postal Code or ZIP Code of the address.&lt;br /&gt; For US addresses, use either the &#x60;5-digit&#x60; or &#x60;9-digit&#x60; ZIP Code in one of the following formats: &#39;12345&#39; or &#39;12345-6789&#39;. &lt;br /&gt; While for CA addresses, use a &#x60;six-character&#x60; alphanumeric string Postal Code in this format: &#39;A1A 1A1&#39;. ERR supports only US addresses.&lt;br /&gt; *NOTE: USPS supports only US location.*
        /// </summary>
        /// <value>The Postal Code or ZIP Code of the address.&lt;br /&gt; For US addresses, use either the &#x60;5-digit&#x60; or &#x60;9-digit&#x60; ZIP Code in one of the following formats: &#39;12345&#39; or &#39;12345-6789&#39;. &lt;br /&gt; While for CA addresses, use a &#x60;six-character&#x60; alphanumeric string Postal Code in this format: &#39;A1A 1A1&#39;. ERR supports only US addresses.&lt;br /&gt; *NOTE: USPS supports only US location.*</value>
        /// <example>06905</example>
        [DataMember(Name = "postalCode", IsRequired = true, EmitDefaultValue = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// The country in which the recipient&#39;s address is located. The value will be the two-character ISO Code of the country from the ISO country list. &lt;br /&gt; Use ISO 3166-1 Alpha-2 standard values. For best results this should be included, especially if the country name does not appear in any of the unparsedAddressLines. &lt;br /&gt; Below is the hyperlink, please select &#x60;Country codes&#x60; and then click &#x60;SEARCH&#x60; button.  &lt;br /&gt; *NOTE: USPS supports only US location.*
        /// </summary>
        /// <value>The country in which the recipient&#39;s address is located. The value will be the two-character ISO Code of the country from the ISO country list. &lt;br /&gt; Use ISO 3166-1 Alpha-2 standard values. For best results this should be included, especially if the country name does not appear in any of the unparsedAddressLines. &lt;br /&gt; Below is the hyperlink, please select &#x60;Country codes&#x60; and then click &#x60;SEARCH&#x60; button.  &lt;br /&gt; *NOTE: USPS supports only US location.*</value>
        /// <example>US</example>
        [DataMember(Name = "countryCode", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The name of the company, in case if the Recipient address is not residential.
        /// </summary>
        /// <value>The name of the company, in case if the Recipient address is not residential.</value>
        /// <example>PB</example>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public string Company { get; set; }

        /// <summary>
        /// This is recipient&#39;s phone number. Enter the digits with or without spaces or hyphens. &lt;br /&gt; &#x60;Max length &#x3D; 15&#x60;.
        /// </summary>
        /// <value>This is recipient&#39;s phone number. Enter the digits with or without spaces or hyphens. &lt;br /&gt; &#x60;Max length &#x3D; 15&#x60;.</value>
        /// <example>203-555-1213</example>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// This must be recipients&#39;s valid email. &lt;br /&gt; &#x60;Max length &#x3D; 50&#x60; 
        /// </summary>
        /// <value>This must be recipients&#39;s valid email. &lt;br /&gt; &#x60;Max length &#x3D; 50&#x60; </value>
        /// <example>anupama.kr@gmail.com</example>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The specified address can be Residential or Official. In case if the address is Residential, the boolean value will be &#39;true&#39;, else it will take &#39;false&#39;.
        /// </summary>
        /// <value>The specified address can be Residential or Official. In case if the address is Residential, the boolean value will be &#39;true&#39;, else it will take &#39;false&#39;.</value>
        /// <example>true</example>
        [DataMember(Name = "residential", EmitDefaultValue = true)]
        public bool Residential { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ToAddress {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  CityTown: ").Append(CityTown).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
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
