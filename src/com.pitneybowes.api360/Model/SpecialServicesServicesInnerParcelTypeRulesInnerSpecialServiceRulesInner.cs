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
    /// SpecialServicesServicesInnerParcelTypeRulesInnerSpecialServiceRulesInner
    /// </summary>
    [DataContract(Name = "specialServices_services_inner_parcelTypeRules_inner_specialServiceRules_inner")]
    public partial class SpecialServicesServicesInnerParcelTypeRulesInnerSpecialServiceRulesInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SpecialServicesServicesInnerParcelTypeRulesInnerSpecialServiceRulesInner" /> class.
        /// </summary>
        /// <param name="specialserviceId">It display the unique id of the special service.</param>
        /// <param name="brandedName">The brand name of the special service..</param>
        /// <param name="categoryId">The unique identifier associated with the special service based on the category..</param>
        /// <param name="categoryName">The special service is categorized with some name and rules, It indicates the category name of the special service..</param>
        /// <param name="incompatibleSpecialServices">Indicates non-compatible special services with this special service.</param>
        /// <param name="inputParameterRules">The rules defined for input parameters for this special service.</param>
        /// <param name="prerequisiteRules">It displays other pre-requisite special services for this special service.</param>
        /// <param name="trackable">If this special service is trackable or not.</param>
        public SpecialServicesServicesInnerParcelTypeRulesInnerSpecialServiceRulesInner(string specialserviceId = default(string), string brandedName = default(string), string categoryId = default(string), string categoryName = default(string), List<string> incompatibleSpecialServices = default(List<string>), List<SpecialServicesServicesInnerParcelTypeRulesInnerSpecialServiceRulesInnerInputParameterRulesInner> inputParameterRules = default(List<SpecialServicesServicesInnerParcelTypeRulesInnerSpecialServiceRulesInnerInputParameterRulesInner>), List<SpecialServicesServicesInnerParcelTypeRulesInnerSpecialServiceRulesInnerPrerequisiteRulesInner> prerequisiteRules = default(List<SpecialServicesServicesInnerParcelTypeRulesInnerSpecialServiceRulesInnerPrerequisiteRulesInner>), bool trackable = default(bool))
        {
            this.SpecialserviceId = specialserviceId;
            this.BrandedName = brandedName;
            this.CategoryId = categoryId;
            this.CategoryName = categoryName;
            this.IncompatibleSpecialServices = incompatibleSpecialServices;
            this.InputParameterRules = inputParameterRules;
            this.PrerequisiteRules = prerequisiteRules;
            this.Trackable = trackable;
        }

        /// <summary>
        /// It display the unique id of the special service
        /// </summary>
        /// <value>It display the unique id of the special service</value>
        /// <example>COD</example>
        [DataMember(Name = "specialserviceId", EmitDefaultValue = false)]
        public string SpecialserviceId { get; set; }

        /// <summary>
        /// The brand name of the special service.
        /// </summary>
        /// <value>The brand name of the special service.</value>
        /// <example>Collect on Delivery</example>
        [DataMember(Name = "brandedName", EmitDefaultValue = false)]
        public string BrandedName { get; set; }

        /// <summary>
        /// The unique identifier associated with the special service based on the category.
        /// </summary>
        /// <value>The unique identifier associated with the special service based on the category.</value>
        /// <example>COD</example>
        [DataMember(Name = "categoryId", EmitDefaultValue = false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// The special service is categorized with some name and rules, It indicates the category name of the special service.
        /// </summary>
        /// <value>The special service is categorized with some name and rules, It indicates the category name of the special service.</value>
        /// <example>Collect on Delivery</example>
        [DataMember(Name = "categoryName", EmitDefaultValue = false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Indicates non-compatible special services with this special service
        /// </summary>
        /// <value>Indicates non-compatible special services with this special service</value>
        /// <example>[&quot;CODRD&quot;,&quot;Ins&quot;,&quot;InsRD&quot;,&quot;SigRD&quot;]</example>
        [DataMember(Name = "incompatibleSpecialServices", EmitDefaultValue = false)]
        public List<string> IncompatibleSpecialServices { get; set; }

        /// <summary>
        /// The rules defined for input parameters for this special service
        /// </summary>
        /// <value>The rules defined for input parameters for this special service</value>
        /// <example>[{&quot;brandedName&quot;:&quot;COD Amount&quot;,&quot;maxValue&quot;:1000,&quot;minValue&quot;:1,&quot;name&quot;:&quot;INPUT_VALUE&quot;,&quot;required&quot;:true}]</example>
        [DataMember(Name = "inputParameterRules", EmitDefaultValue = false)]
        public List<SpecialServicesServicesInnerParcelTypeRulesInnerSpecialServiceRulesInnerInputParameterRulesInner> InputParameterRules { get; set; }

        /// <summary>
        /// It displays other pre-requisite special services for this special service
        /// </summary>
        /// <value>It displays other pre-requisite special services for this special service</value>
        /// <example>[{&quot;specialserviceId&quot;:&quot;COD&quot;},{&quot;specialserviceId&quot;:&quot;CODRD&quot;}]</example>
        [DataMember(Name = "prerequisiteRules", EmitDefaultValue = false)]
        public List<SpecialServicesServicesInnerParcelTypeRulesInnerSpecialServiceRulesInnerPrerequisiteRulesInner> PrerequisiteRules { get; set; }

        /// <summary>
        /// If this special service is trackable or not
        /// </summary>
        /// <value>If this special service is trackable or not</value>
        /// <example>true</example>
        [DataMember(Name = "trackable", EmitDefaultValue = true)]
        public bool Trackable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SpecialServicesServicesInnerParcelTypeRulesInnerSpecialServiceRulesInner {\n");
            sb.Append("  SpecialserviceId: ").Append(SpecialserviceId).Append("\n");
            sb.Append("  BrandedName: ").Append(BrandedName).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  IncompatibleSpecialServices: ").Append(IncompatibleSpecialServices).Append("\n");
            sb.Append("  InputParameterRules: ").Append(InputParameterRules).Append("\n");
            sb.Append("  PrerequisiteRules: ").Append(PrerequisiteRules).Append("\n");
            sb.Append("  Trackable: ").Append(Trackable).Append("\n");
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
