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
    /// PrintDocumentRequest
    /// </summary>
    [DataContract(Name = "PrintDocumentRequest")]
    public partial class PrintDocumentRequest : IValidatableObject
    {
        /// <summary>
        /// Content/Identifier of document e.g. DOCUMENT_REFERECE_ID. Actual document name e.g. abc.pdf. [IN] i.e base64 string, URL, file path
        /// </summary>
        /// <value>Content/Identifier of document e.g. DOCUMENT_REFERECE_ID. Actual document name e.g. abc.pdf. [IN] i.e base64 string, URL, file path</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataEnum
        {
            /// <summary>
            /// Enum PDF for value: PDF
            /// </summary>
            [EnumMember(Value = "PDF")]
            PDF = 1,

            /// <summary>
            /// Enum URL for value: URL
            /// </summary>
            [EnumMember(Value = "URL")]
            URL = 2
        }


        /// <summary>
        /// Content/Identifier of document e.g. DOCUMENT_REFERECE_ID. Actual document name e.g. abc.pdf. [IN] i.e base64 string, URL, file path
        /// </summary>
        /// <value>Content/Identifier of document e.g. DOCUMENT_REFERECE_ID. Actual document name e.g. abc.pdf. [IN] i.e base64 string, URL, file path</value>
        /// <example>&lt;&lt;base64string&gt;&gt;</example>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public DataEnum Data { get; set; }
        /// <summary>
        /// Data Type of the document e.g. DOCUMENT_REFERENCE. [IN/OUT]
        /// </summary>
        /// <value>Data Type of the document e.g. DOCUMENT_REFERENCE. [IN/OUT]</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DataTypeEnum
        {
            /// <summary>
            /// Enum BASE64 for value: BASE64
            /// </summary>
            [EnumMember(Value = "BASE64")]
            BASE64 = 1,

            /// <summary>
            /// Enum URL for value: URL
            /// </summary>
            [EnumMember(Value = "URL")]
            URL = 2
        }


        /// <summary>
        /// Data Type of the document e.g. DOCUMENT_REFERENCE. [IN/OUT]
        /// </summary>
        /// <value>Data Type of the document e.g. DOCUMENT_REFERENCE. [IN/OUT]</value>
        /// <example>BASE64</example>
        [DataMember(Name = "dataType", IsRequired = true, EmitDefaultValue = true)]
        public DataTypeEnum DataType { get; set; }
        /// <summary>
        /// The format of the document file the print takes.
        /// </summary>
        /// <value>The format of the document file the print takes.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DocumentTypeEnum
        {
            /// <summary>
            /// Enum ZPL2 for value: ZPL2
            /// </summary>
            [EnumMember(Value = "ZPL2")]
            ZPL2 = 1,

            /// <summary>
            /// Enum PDF for value: PDF
            /// </summary>
            [EnumMember(Value = "PDF")]
            PDF = 2
        }


        /// <summary>
        /// The format of the document file the print takes.
        /// </summary>
        /// <value>The format of the document file the print takes.</value>
        /// <example>ZPL2</example>
        [DataMember(Name = "documentType", IsRequired = true, EmitDefaultValue = true)]
        public DocumentTypeEnum DocumentType { get; set; }
        /// <summary>
        /// The name of the Document Form.
        /// </summary>
        /// <value>The name of the Document Form.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FormNameEnum
        {
            /// <summary>
            /// Enum _8x11 for value: 8x11
            /// </summary>
            [EnumMember(Value = "8x11")]
            _8x11 = 1,

            /// <summary>
            /// Enum _4x6 for value: 4x6
            /// </summary>
            [EnumMember(Value = "4x6")]
            _4x6 = 2,

            /// <summary>
            /// Enum _2x1 for value: 2x1
            /// </summary>
            [EnumMember(Value = "2x1")]
            _2x1 = 3,

            /// <summary>
            /// Enum ENV10 for value: ENV10
            /// </summary>
            [EnumMember(Value = "ENV10")]
            ENV10 = 4,

            /// <summary>
            /// Enum ENV9 for value: ENV9
            /// </summary>
            [EnumMember(Value = "ENV9")]
            ENV9 = 5,

            /// <summary>
            /// Enum A1 for value: A1
            /// </summary>
            [EnumMember(Value = "A1")]
            A1 = 6
        }


        /// <summary>
        /// The name of the Document Form.
        /// </summary>
        /// <value>The name of the Document Form.</value>
        /// <example>ENV10</example>
        [DataMember(Name = "formName", IsRequired = true, EmitDefaultValue = true)]
        public FormNameEnum FormName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintDocumentRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PrintDocumentRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PrintDocumentRequest" /> class.
        /// </summary>
        /// <param name="printerAliasName">Name of the Printer connected (directly or via network) to a Computer. &#x60;Max length &#x3D; 30&#x60; (required).</param>
        /// <param name="data">Content/Identifier of document e.g. DOCUMENT_REFERECE_ID. Actual document name e.g. abc.pdf. [IN] i.e base64 string, URL, file path (required).</param>
        /// <param name="dataType">Data Type of the document e.g. DOCUMENT_REFERENCE. [IN/OUT] (required).</param>
        /// <param name="documentType">The format of the document file the print takes. (required).</param>
        /// <param name="formName">The name of the Document Form. (required).</param>
        /// <param name="orientation">The orientation of the document layout: Portrait or Landscape..</param>
        /// <param name="reference">reference.</param>
        public PrintDocumentRequest(string printerAliasName = default(string), DataEnum data = default(DataEnum), DataTypeEnum dataType = default(DataTypeEnum), DocumentTypeEnum documentType = default(DocumentTypeEnum), FormNameEnum formName = default(FormNameEnum), string orientation = default(string), PrintDocumentRequestReference reference = default(PrintDocumentRequestReference))
        {
            // to ensure "printerAliasName" is required (not null)
            if (printerAliasName == null)
            {
                throw new ArgumentNullException("printerAliasName is a required property for PrintDocumentRequest and cannot be null");
            }
            this.PrinterAliasName = printerAliasName;
            this.Data = data;
            this.DataType = dataType;
            this.DocumentType = documentType;
            this.FormName = formName;
            this.Orientation = orientation;
            this.Reference = reference;
        }

        /// <summary>
        /// Name of the Printer connected (directly or via network) to a Computer. &#x60;Max length &#x3D; 30&#x60;
        /// </summary>
        /// <value>Name of the Printer connected (directly or via network) to a Computer. &#x60;Max length &#x3D; 30&#x60;</value>
        /// <example>Pitney Bowes Printer</example>
        [DataMember(Name = "printerAliasName", IsRequired = true, EmitDefaultValue = true)]
        public string PrinterAliasName { get; set; }

        /// <summary>
        /// The orientation of the document layout: Portrait or Landscape.
        /// </summary>
        /// <value>The orientation of the document layout: Portrait or Landscape.</value>
        /// <example>PORTRAIT</example>
        [DataMember(Name = "orientation", EmitDefaultValue = false)]
        public string Orientation { get; set; }

        /// <summary>
        /// Gets or Sets Reference
        /// </summary>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public PrintDocumentRequestReference Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PrintDocumentRequest {\n");
            sb.Append("  PrinterAliasName: ").Append(PrinterAliasName).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  DocumentType: ").Append(DocumentType).Append("\n");
            sb.Append("  FormName: ").Append(FormName).Append("\n");
            sb.Append("  Orientation: ").Append(Orientation).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
