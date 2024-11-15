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
    /// Address
    /// </summary>
    [DataContract(Name = "Address")]
    public partial class Address : IValidatableObject
    {
        /// <summary>
        /// &gt;- This field applies to the Validate Address and Suggest Addresses APIs. The field indicates whether the submitted address is valid and whether the API made changes to the address. Possible values are: &#x60;VALIDATED_CHANGED&#x60;: The address is valid, but the API made changes to improve the address. For example, if an address has a valid street number and street name (e.g. “100 Elm”) but is missing the street suffix (e.g. “St”), the API would add the suffix. &#x60;VALIDATED_AND_NOT_CHANGED&#x60;: The address is valid. The API made no changes.
        /// </summary>
        /// <value>&gt;- This field applies to the Validate Address and Suggest Addresses APIs. The field indicates whether the submitted address is valid and whether the API made changes to the address. Possible values are: &#x60;VALIDATED_CHANGED&#x60;: The address is valid, but the API made changes to improve the address. For example, if an address has a valid street number and street name (e.g. “100 Elm”) but is missing the street suffix (e.g. “St”), the API would add the suffix. &#x60;VALIDATED_AND_NOT_CHANGED&#x60;: The address is valid. The API made no changes.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum CHANGED for value: VALIDATED_CHANGED
            /// </summary>
            [EnumMember(Value = "VALIDATED_CHANGED")]
            CHANGED = 1,

            /// <summary>
            /// Enum ANDNOTCHANGED for value: VALIDATED_AND_NOT_CHANGED
            /// </summary>
            [EnumMember(Value = "VALIDATED_AND_NOT_CHANGED")]
            ANDNOTCHANGED = 2
        }


        /// <summary>
        /// &gt;- This field applies to the Validate Address and Suggest Addresses APIs. The field indicates whether the submitted address is valid and whether the API made changes to the address. Possible values are: &#x60;VALIDATED_CHANGED&#x60;: The address is valid, but the API made changes to improve the address. For example, if an address has a valid street number and street name (e.g. “100 Elm”) but is missing the street suffix (e.g. “St”), the API would add the suffix. &#x60;VALIDATED_AND_NOT_CHANGED&#x60;: The address is valid. The API made no changes.
        /// </summary>
        /// <value>&gt;- This field applies to the Validate Address and Suggest Addresses APIs. The field indicates whether the submitted address is valid and whether the API made changes to the address. Possible values are: &#x60;VALIDATED_CHANGED&#x60;: The address is valid, but the API made changes to improve the address. For example, if an address has a valid street number and street name (e.g. “100 Elm”) but is missing the street suffix (e.g. “St”), the API would add the suffix. &#x60;VALIDATED_AND_NOT_CHANGED&#x60;: The address is valid. The API made no changes.</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// &gt;-Tax identification Type, valid values are EIN or GST or VAT or RFC or EORI.
        /// </summary>
        /// <value>&gt;-Tax identification Type, valid values are EIN or GST or VAT or RFC or EORI.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TaxIdTypeEnum
        {
            /// <summary>
            /// Enum EIN for value: EIN
            /// </summary>
            [EnumMember(Value = "EIN")]
            EIN = 1,

            /// <summary>
            /// Enum GST for value: GST
            /// </summary>
            [EnumMember(Value = "GST")]
            GST = 2,

            /// <summary>
            /// Enum VAT for value: VAT
            /// </summary>
            [EnumMember(Value = "VAT")]
            VAT = 3,

            /// <summary>
            /// Enum EORI for value: EORI
            /// </summary>
            [EnumMember(Value = "EORI")]
            EORI = 4
        }


        /// <summary>
        /// &gt;-Tax identification Type, valid values are EIN or GST or VAT or RFC or EORI.
        /// </summary>
        /// <value>&gt;-Tax identification Type, valid values are EIN or GST or VAT or RFC or EORI.</value>
        [DataMember(Name = "taxIdType", EmitDefaultValue = false)]
        public TaxIdTypeEnum? TaxIdType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Address() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Address" /> class.
        /// </summary>
        /// <param name="addressLine1">The addressLine1 can contain the Flat number, Building or Apartment Name/number (if any) or company name (if not residential). (required).</param>
        /// <param name="addressLine2">The addressLine2 contains Street address or Landmark (if any)..</param>
        /// <param name="addressLine3">The addressLine3 contains P.O.Box (if any) near the address..</param>
        /// <param name="cityTown"> This indicates the city or town in the Address..</param>
        /// <param name="company"> This indicates the name of the company..</param>
        /// <param name="countryCode">This indicates the two-character ISO code of the country. (required).</param>
        /// <param name="email">The email address of the Recipient or Department where the delivery address is pointed to..</param>
        /// <param name="name">The first and last name of the Recipient or Department..</param>
        /// <param name="phone">&gt;-The phone number. Enter the digits with or without spaces or hyphens. When used for Pickups, the maximum is 10 digits..</param>
        /// <param name="postalCode">The postal code or ZIP code of the Address. (required).</param>
        /// <param name="residential">&gt;-Indicates whether this is a residential address. Pitney Bowes recommends including this parameter to improve address verification..</param>
        /// <param name="stateProvince">&gt;-The state or province. For a US or Canadian address, use the 2-letter state or province code. (required).</param>
        /// <param name="status">&gt;- This field applies to the Validate Address and Suggest Addresses APIs. The field indicates whether the submitted address is valid and whether the API made changes to the address. Possible values are: &#x60;VALIDATED_CHANGED&#x60;: The address is valid, but the API made changes to improve the address. For example, if an address has a valid street number and street name (e.g. “100 Elm”) but is missing the street suffix (e.g. “St”), the API would add the suffix. &#x60;VALIDATED_AND_NOT_CHANGED&#x60;: The address is valid. The API made no changes..</param>
        /// <param name="taxId">&gt;-Tax identification number (TIN) or Employer Identification number (EIN) or GST or VAT number or RFC or EORI..</param>
        /// <param name="taxIdType">&gt;-Tax identification Type, valid values are EIN or GST or VAT or RFC or EORI..</param>
        public Address(string addressLine1 = default(string), string addressLine2 = default(string), string addressLine3 = default(string), string cityTown = default(string), string company = default(string), string countryCode = default(string), string email = default(string), string name = default(string), string phone = default(string), string postalCode = default(string), bool residential = default(bool), string stateProvince = default(string), StatusEnum? status = default(StatusEnum?), string taxId = default(string), TaxIdTypeEnum? taxIdType = default(TaxIdTypeEnum?))
        {
            // to ensure "addressLine1" is required (not null)
            if (addressLine1 == null)
            {
                throw new ArgumentNullException("addressLine1 is a required property for Address and cannot be null");
            }
            this.AddressLine1 = addressLine1;
            // to ensure "countryCode" is required (not null)
            if (countryCode == null)
            {
                throw new ArgumentNullException("countryCode is a required property for Address and cannot be null");
            }
            this.CountryCode = countryCode;
            // to ensure "postalCode" is required (not null)
            if (postalCode == null)
            {
                throw new ArgumentNullException("postalCode is a required property for Address and cannot be null");
            }
            this.PostalCode = postalCode;
            // to ensure "stateProvince" is required (not null)
            if (stateProvince == null)
            {
                throw new ArgumentNullException("stateProvince is a required property for Address and cannot be null");
            }
            this.StateProvince = stateProvince;
            this.AddressLine2 = addressLine2;
            this.AddressLine3 = addressLine3;
            this.CityTown = cityTown;
            this.Company = company;
            this.Email = email;
            this.Name = name;
            this.Phone = phone;
            this.Residential = residential;
            this.Status = status;
            this.TaxId = taxId;
            this.TaxIdType = taxIdType;
        }

        /// <summary>
        /// The addressLine1 can contain the Flat number, Building or Apartment Name/number (if any) or company name (if not residential).
        /// </summary>
        /// <value>The addressLine1 can contain the Flat number, Building or Apartment Name/number (if any) or company name (if not residential).</value>
        /// <example>27 Watervw Dr</example>
        [DataMember(Name = "addressLine1", IsRequired = true, EmitDefaultValue = true)]
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
        ///  This indicates the city or town in the Address.
        /// </summary>
        /// <value> This indicates the city or town in the Address.</value>
        [DataMember(Name = "cityTown", EmitDefaultValue = false)]
        public string CityTown { get; set; }

        /// <summary>
        ///  This indicates the name of the company.
        /// </summary>
        /// <value> This indicates the name of the company.</value>
        [DataMember(Name = "company", EmitDefaultValue = false)]
        public string Company { get; set; }

        /// <summary>
        /// This indicates the two-character ISO code of the country.
        /// </summary>
        /// <value>This indicates the two-character ISO code of the country.</value>
        [DataMember(Name = "countryCode", IsRequired = true, EmitDefaultValue = true)]
        public string CountryCode { get; set; }

        /// <summary>
        /// The email address of the Recipient or Department where the delivery address is pointed to.
        /// </summary>
        /// <value>The email address of the Recipient or Department where the delivery address is pointed to.</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// The first and last name of the Recipient or Department.
        /// </summary>
        /// <value>The first and last name of the Recipient or Department.</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// &gt;-The phone number. Enter the digits with or without spaces or hyphens. When used for Pickups, the maximum is 10 digits.
        /// </summary>
        /// <value>&gt;-The phone number. Enter the digits with or without spaces or hyphens. When used for Pickups, the maximum is 10 digits.</value>
        [DataMember(Name = "phone", EmitDefaultValue = false)]
        public string Phone { get; set; }

        /// <summary>
        /// The postal code or ZIP code of the Address.
        /// </summary>
        /// <value>The postal code or ZIP code of the Address.</value>
        [DataMember(Name = "postalCode", IsRequired = true, EmitDefaultValue = true)]
        public string PostalCode { get; set; }

        /// <summary>
        /// &gt;-Indicates whether this is a residential address. Pitney Bowes recommends including this parameter to improve address verification.
        /// </summary>
        /// <value>&gt;-Indicates whether this is a residential address. Pitney Bowes recommends including this parameter to improve address verification.</value>
        [DataMember(Name = "residential", EmitDefaultValue = true)]
        public bool Residential { get; set; }

        /// <summary>
        /// &gt;-The state or province. For a US or Canadian address, use the 2-letter state or province code.
        /// </summary>
        /// <value>&gt;-The state or province. For a US or Canadian address, use the 2-letter state or province code.</value>
        [DataMember(Name = "stateProvince", IsRequired = true, EmitDefaultValue = true)]
        public string StateProvince { get; set; }

        /// <summary>
        /// &gt;-Tax identification number (TIN) or Employer Identification number (EIN) or GST or VAT number or RFC or EORI.
        /// </summary>
        /// <value>&gt;-Tax identification number (TIN) or Employer Identification number (EIN) or GST or VAT number or RFC or EORI.</value>
        [DataMember(Name = "taxId", EmitDefaultValue = false)]
        public string TaxId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Address {\n");
            sb.Append("  AddressLine1: ").Append(AddressLine1).Append("\n");
            sb.Append("  AddressLine2: ").Append(AddressLine2).Append("\n");
            sb.Append("  AddressLine3: ").Append(AddressLine3).Append("\n");
            sb.Append("  CityTown: ").Append(CityTown).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  CountryCode: ").Append(CountryCode).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  Residential: ").Append(Residential).Append("\n");
            sb.Append("  StateProvince: ").Append(StateProvince).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TaxId: ").Append(TaxId).Append("\n");
            sb.Append("  TaxIdType: ").Append(TaxIdType).Append("\n");
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
