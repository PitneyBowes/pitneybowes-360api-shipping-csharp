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
    /// Label layout details
    /// </summary>
    [DataContract(Name = "getShipmentsForBatch_data_inner_labelLayout")]
    public partial class GetShipmentsForBatchDataInnerLabelLayout : IValidatableObject
    {
        /// <summary>
        /// Defines the label size of the Shipment, that is, the Shipping Label is available in different Doc Size.
        /// </summary>
        /// <value>Defines the label size of the Shipment, that is, the Shipping Label is available in different Doc Size.</value>
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
        /// Defines the label size of the Shipment, that is, the Shipping Label is available in different Doc Size.
        /// </summary>
        /// <value>Defines the label size of the Shipment, that is, the Shipping Label is available in different Doc Size.</value>
        /// <example>DOC_4X6</example>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public SizeEnum? Size { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GetShipmentsForBatchDataInnerLabelLayout" /> class.
        /// </summary>
        /// <param name="fileFormat">Defines the format of the document file the print takes..</param>
        /// <param name="printReceipt">This option asks if the receipt is to be printed..</param>
        /// <param name="size">Defines the label size of the Shipment, that is, the Shipping Label is available in different Doc Size..</param>
        /// <param name="type">This indicates the type of the label.</param>
        public GetShipmentsForBatchDataInnerLabelLayout(string fileFormat = default(string), bool printReceipt = default(bool), SizeEnum? size = default(SizeEnum?), string type = default(string))
        {
            this.FileFormat = fileFormat;
            this.PrintReceipt = printReceipt;
            this.Size = size;
            this.Type = type;
        }

        /// <summary>
        /// Defines the format of the document file the print takes.
        /// </summary>
        /// <value>Defines the format of the document file the print takes.</value>
        /// <example>PDF</example>
        [DataMember(Name = "fileFormat", EmitDefaultValue = false)]
        public string FileFormat { get; set; }

        /// <summary>
        /// This option asks if the receipt is to be printed.
        /// </summary>
        /// <value>This option asks if the receipt is to be printed.</value>
        /// <example>true</example>
        [DataMember(Name = "printReceipt", EmitDefaultValue = true)]
        public bool PrintReceipt { get; set; }

        /// <summary>
        /// This indicates the type of the label
        /// </summary>
        /// <value>This indicates the type of the label</value>
        /// <example>SHIPPING_LABEL</example>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetShipmentsForBatchDataInnerLabelLayout {\n");
            sb.Append("  FileFormat: ").Append(FileFormat).Append("\n");
            sb.Append("  PrintReceipt: ").Append(PrintReceipt).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
