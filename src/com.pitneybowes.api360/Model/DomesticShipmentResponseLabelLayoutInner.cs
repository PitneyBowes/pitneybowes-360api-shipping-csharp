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
    /// DomesticShipmentResponseLabelLayoutInner
    /// </summary>
    [DataContract(Name = "domesticShipmentResponse_labelLayout_inner")]
    public partial class DomesticShipmentResponseLabelLayoutInner : IValidatableObject
    {
        /// <summary>
        /// This defines the label size of the Shipment, e.g., Shipping Label having Doc Size (4&#39; X 6&#39; or 8.5&#39; X 11&#39;).
        /// </summary>
        /// <value>This defines the label size of the Shipment, e.g., Shipping Label having Doc Size (4&#39; X 6&#39; or 8.5&#39; X 11&#39;).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SizeEnum
        {
            /// <summary>
            /// Enum _8X11 for value: DOC_8X11
            /// </summary>
            [EnumMember(Value = "DOC_8X11")]
            _8X11 = 1,

            /// <summary>
            /// Enum _4X6 for value: DOC_4X6
            /// </summary>
            [EnumMember(Value = "DOC_4X6")]
            _4X6 = 2
        }


        /// <summary>
        /// This defines the label size of the Shipment, e.g., Shipping Label having Doc Size (4&#39; X 6&#39; or 8.5&#39; X 11&#39;).
        /// </summary>
        /// <value>This defines the label size of the Shipment, e.g., Shipping Label having Doc Size (4&#39; X 6&#39; or 8.5&#39; X 11&#39;).</value>
        /// <example>DOC_8X11</example>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public SizeEnum? Size { get; set; }
        /// <summary>
        /// This defines the type of the Shipment, e.g., Shipping Label.
        /// </summary>
        /// <value>This defines the type of the Shipment, e.g., Shipping Label.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum SHIPPINGLABEL for value: SHIPPING_LABEL
            /// </summary>
            [EnumMember(Value = "SHIPPING_LABEL")]
            SHIPPINGLABEL = 1
        }


        /// <summary>
        /// This defines the type of the Shipment, e.g., Shipping Label.
        /// </summary>
        /// <value>This defines the type of the Shipment, e.g., Shipping Label.</value>
        /// <example>SHIPPING_LABEL</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// This defines the type of the shipment which is printed. For example Shipping label prints in PDF form.
        /// </summary>
        /// <value>This defines the type of the shipment which is printed. For example Shipping label prints in PDF form.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FileFormatEnum
        {
            /// <summary>
            /// Enum PDF for value: PDF
            /// </summary>
            [EnumMember(Value = "PDF")]
            PDF = 1,

            /// <summary>
            /// Enum ZPL2 for value: ZPL2
            /// </summary>
            [EnumMember(Value = "ZPL2")]
            ZPL2 = 2
        }


        /// <summary>
        /// This defines the type of the shipment which is printed. For example Shipping label prints in PDF form.
        /// </summary>
        /// <value>This defines the type of the shipment which is printed. For example Shipping label prints in PDF form.</value>
        /// <example>PDF</example>
        [DataMember(Name = "fileFormat", EmitDefaultValue = false)]
        public FileFormatEnum? FileFormat { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomesticShipmentResponseLabelLayoutInner" /> class.
        /// </summary>
        /// <param name="contentType">it shows the type of label generated.</param>
        /// <param name="contents">it shows the label URL of the shipment.</param>
        /// <param name="size">This defines the label size of the Shipment, e.g., Shipping Label having Doc Size (4&#39; X 6&#39; or 8.5&#39; X 11&#39;)..</param>
        /// <param name="type">This defines the type of the Shipment, e.g., Shipping Label..</param>
        /// <param name="fileFormat">This defines the type of the shipment which is printed. For example Shipping label prints in PDF form..</param>
        public DomesticShipmentResponseLabelLayoutInner(string contentType = default(string), string contents = default(string), SizeEnum? size = default(SizeEnum?), TypeEnum? type = default(TypeEnum?), FileFormatEnum? fileFormat = default(FileFormatEnum?))
        {
            this.ContentType = contentType;
            this.Contents = contents;
            this.Size = size;
            this.Type = type;
            this.FileFormat = fileFormat;
        }

        /// <summary>
        /// it shows the type of label generated
        /// </summary>
        /// <value>it shows the type of label generated</value>
        /// <example>URL</example>
        [DataMember(Name = "contentType", EmitDefaultValue = false)]
        public string ContentType { get; set; }

        /// <summary>
        /// it shows the label URL of the shipment
        /// </summary>
        /// <value>it shows the label URL of the shipment</value>
        /// <example>https://prv-labels-cls.gcs.pitneycloud.com/usps/456312111/outbound/label/e7d2254028f64b02b1d57d44c398d48b.pdf</example>
        [DataMember(Name = "contents", EmitDefaultValue = false)]
        public string Contents { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DomesticShipmentResponseLabelLayoutInner {\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  Contents: ").Append(Contents).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FileFormat: ").Append(FileFormat).Append("\n");
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
