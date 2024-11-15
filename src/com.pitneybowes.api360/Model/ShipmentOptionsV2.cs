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
    /// ShipmentOptionsV2
    /// </summary>
    [DataContract(Name = "shipmentOptionsV2")]
    public partial class ShipmentOptionsV2 : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipmentOptionsV2" /> class.
        /// </summary>
        /// <param name="addToManifest">This option asks if the shipment is to be added for Manifest, so that the shipment will reflect in the Manifest Form while compilation. The value can be &#39;true&#39; or &#39;false&#39;. Applicable for USPS.</param>
        /// <param name="printCustomMessage">This prints a custom message on shipping label.</param>
        /// <param name="receiptOption">It provides options to print receipt with shipping label. Only applicable for USPS, can take values- RECEIPT_ONLY or RECEIPT_WITH_INSTRUCTIONS or NO_OPTIONS.</param>
        /// <param name="printDepartment">This prints department on shipping label, applicable for FedEx.</param>
        /// <param name="printInvoiceNumber">This prints invoice number on shipping label, applicable for FedEx.</param>
        /// <param name="printPONumber">This prints po number on shipping label, applicable for FedEx.</param>
        /// <param name="minimalAddressValidation">If true, then only City, State, and PostalCode (zip) are validated. This option is specific for US domestic addresses only..</param>
        public ShipmentOptionsV2(bool addToManifest = default(bool), string printCustomMessage = default(string), string receiptOption = default(string), string printDepartment = default(string), string printInvoiceNumber = default(string), string printPONumber = default(string), bool minimalAddressValidation = default(bool))
        {
            this.AddToManifest = addToManifest;
            this.PrintCustomMessage = printCustomMessage;
            this.ReceiptOption = receiptOption;
            this.PrintDepartment = printDepartment;
            this.PrintInvoiceNumber = printInvoiceNumber;
            this.PrintPONumber = printPONumber;
            this.MinimalAddressValidation = minimalAddressValidation;
        }

        /// <summary>
        /// This option asks if the shipment is to be added for Manifest, so that the shipment will reflect in the Manifest Form while compilation. The value can be &#39;true&#39; or &#39;false&#39;. Applicable for USPS
        /// </summary>
        /// <value>This option asks if the shipment is to be added for Manifest, so that the shipment will reflect in the Manifest Form while compilation. The value can be &#39;true&#39; or &#39;false&#39;. Applicable for USPS</value>
        /// <example>true</example>
        [DataMember(Name = "addToManifest", EmitDefaultValue = true)]
        public bool AddToManifest { get; set; }

        /// <summary>
        /// This prints a custom message on shipping label
        /// </summary>
        /// <value>This prints a custom message on shipping label</value>
        /// <example>Print Message 1</example>
        [DataMember(Name = "printCustomMessage", EmitDefaultValue = false)]
        public string PrintCustomMessage { get; set; }

        /// <summary>
        /// It provides options to print receipt with shipping label. Only applicable for USPS, can take values- RECEIPT_ONLY or RECEIPT_WITH_INSTRUCTIONS or NO_OPTIONS
        /// </summary>
        /// <value>It provides options to print receipt with shipping label. Only applicable for USPS, can take values- RECEIPT_ONLY or RECEIPT_WITH_INSTRUCTIONS or NO_OPTIONS</value>
        /// <example>RECEIPT_WITH_INSTRUCTIONS</example>
        [DataMember(Name = "receiptOption", EmitDefaultValue = false)]
        public string ReceiptOption { get; set; }

        /// <summary>
        /// This prints department on shipping label, applicable for FedEx
        /// </summary>
        /// <value>This prints department on shipping label, applicable for FedEx</value>
        /// <example>department</example>
        [DataMember(Name = "printDepartment", EmitDefaultValue = false)]
        public string PrintDepartment { get; set; }

        /// <summary>
        /// This prints invoice number on shipping label, applicable for FedEx
        /// </summary>
        /// <value>This prints invoice number on shipping label, applicable for FedEx</value>
        /// <example>invoicenumber</example>
        [DataMember(Name = "printInvoiceNumber", EmitDefaultValue = false)]
        public string PrintInvoiceNumber { get; set; }

        /// <summary>
        /// This prints po number on shipping label, applicable for FedEx
        /// </summary>
        /// <value>This prints po number on shipping label, applicable for FedEx</value>
        /// <example>ponumber</example>
        [DataMember(Name = "printPONumber", EmitDefaultValue = false)]
        public string PrintPONumber { get; set; }

        /// <summary>
        /// If true, then only City, State, and PostalCode (zip) are validated. This option is specific for US domestic addresses only.
        /// </summary>
        /// <value>If true, then only City, State, and PostalCode (zip) are validated. This option is specific for US domestic addresses only.</value>
        /// <example>true</example>
        [DataMember(Name = "minimalAddressValidation", EmitDefaultValue = true)]
        public bool MinimalAddressValidation { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipmentOptionsV2 {\n");
            sb.Append("  AddToManifest: ").Append(AddToManifest).Append("\n");
            sb.Append("  PrintCustomMessage: ").Append(PrintCustomMessage).Append("\n");
            sb.Append("  ReceiptOption: ").Append(ReceiptOption).Append("\n");
            sb.Append("  PrintDepartment: ").Append(PrintDepartment).Append("\n");
            sb.Append("  PrintInvoiceNumber: ").Append(PrintInvoiceNumber).Append("\n");
            sb.Append("  PrintPONumber: ").Append(PrintPONumber).Append("\n");
            sb.Append("  MinimalAddressValidation: ").Append(MinimalAddressValidation).Append("\n");
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
