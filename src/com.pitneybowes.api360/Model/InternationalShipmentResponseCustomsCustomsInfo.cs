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
    /// InternationalShipmentResponseCustomsCustomsInfo
    /// </summary>
    [DataContract(Name = "internationalShipmentResponse_customs_customsInfo")]
    public partial class InternationalShipmentResponseCustomsCustomsInfo : IValidatableObject
    {
        /// <summary>
        /// Three-digit codes describing Terms of sale required for DHL Express shipments. Terms of sale is some sort of agreement between a buyer and seller which serves the purpose of creating uniform expectations between them. Possible values are- CFR (description- Cost and Freight), CIF (description- Cost, Insurance and Freight), CIP (description- Carriage and Insurance Paid To), DAF (description- Delivered at Frontier), DAP (description- Delivered At Place), DAT (description- Delivered At Terminal), DDP (description- Delivered Duty Paid), DDU (description- Delivered Duty Unpaid), DEQ (description- Delivery ex Quay), DES (description- Delivered ex Ship), DPU (description- Delivered At Place Unloaded), EXW (description- Ex Works), FAS (description- FAS Free Alongside Ship), FCA (description- Free Carrier), FOB (description- FOB Free On Board)
        /// </summary>
        /// <value>Three-digit codes describing Terms of sale required for DHL Express shipments. Terms of sale is some sort of agreement between a buyer and seller which serves the purpose of creating uniform expectations between them. Possible values are- CFR (description- Cost and Freight), CIF (description- Cost, Insurance and Freight), CIP (description- Carriage and Insurance Paid To), DAF (description- Delivered at Frontier), DAP (description- Delivered At Place), DAT (description- Delivered At Terminal), DDP (description- Delivered Duty Paid), DDU (description- Delivered Duty Unpaid), DEQ (description- Delivery ex Quay), DES (description- Delivered ex Ship), DPU (description- Delivered At Place Unloaded), EXW (description- Ex Works), FAS (description- FAS Free Alongside Ship), FCA (description- Free Carrier), FOB (description- FOB Free On Board)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TermsOfSaleEnum
        {
            /// <summary>
            /// Enum CFR for value: CFR
            /// </summary>
            [EnumMember(Value = "CFR")]
            CFR = 1,

            /// <summary>
            /// Enum CIF for value: CIF
            /// </summary>
            [EnumMember(Value = "CIF")]
            CIF = 2,

            /// <summary>
            /// Enum CIP for value: CIP
            /// </summary>
            [EnumMember(Value = "CIP")]
            CIP = 3,

            /// <summary>
            /// Enum CPT for value: CPT
            /// </summary>
            [EnumMember(Value = "CPT")]
            CPT = 4,

            /// <summary>
            /// Enum DAF for value: DAF
            /// </summary>
            [EnumMember(Value = "DAF")]
            DAF = 5,

            /// <summary>
            /// Enum DAP for value: DAP
            /// </summary>
            [EnumMember(Value = "DAP")]
            DAP = 6,

            /// <summary>
            /// Enum DAT for value: DAT
            /// </summary>
            [EnumMember(Value = "DAT")]
            DAT = 7,

            /// <summary>
            /// Enum DDP for value: DDP
            /// </summary>
            [EnumMember(Value = "DDP")]
            DDP = 8,

            /// <summary>
            /// Enum DDU for value: DDU
            /// </summary>
            [EnumMember(Value = "DDU")]
            DDU = 9,

            /// <summary>
            /// Enum DEQ for value: DEQ
            /// </summary>
            [EnumMember(Value = "DEQ")]
            DEQ = 10,

            /// <summary>
            /// Enum DES for value: DES
            /// </summary>
            [EnumMember(Value = "DES")]
            DES = 11,

            /// <summary>
            /// Enum DPU for value: DPU
            /// </summary>
            [EnumMember(Value = "DPU")]
            DPU = 12,

            /// <summary>
            /// Enum EXW for value: EXW
            /// </summary>
            [EnumMember(Value = "EXW")]
            EXW = 13,

            /// <summary>
            /// Enum FAS for value: FAS
            /// </summary>
            [EnumMember(Value = "FAS")]
            FAS = 14,

            /// <summary>
            /// Enum FCA for value: FCA
            /// </summary>
            [EnumMember(Value = "FCA")]
            FCA = 15,

            /// <summary>
            /// Enum FOB for value: FOB
            /// </summary>
            [EnumMember(Value = "FOB")]
            FOB = 16
        }


        /// <summary>
        /// Three-digit codes describing Terms of sale required for DHL Express shipments. Terms of sale is some sort of agreement between a buyer and seller which serves the purpose of creating uniform expectations between them. Possible values are- CFR (description- Cost and Freight), CIF (description- Cost, Insurance and Freight), CIP (description- Carriage and Insurance Paid To), DAF (description- Delivered at Frontier), DAP (description- Delivered At Place), DAT (description- Delivered At Terminal), DDP (description- Delivered Duty Paid), DDU (description- Delivered Duty Unpaid), DEQ (description- Delivery ex Quay), DES (description- Delivered ex Ship), DPU (description- Delivered At Place Unloaded), EXW (description- Ex Works), FAS (description- FAS Free Alongside Ship), FCA (description- Free Carrier), FOB (description- FOB Free On Board)
        /// </summary>
        /// <value>Three-digit codes describing Terms of sale required for DHL Express shipments. Terms of sale is some sort of agreement between a buyer and seller which serves the purpose of creating uniform expectations between them. Possible values are- CFR (description- Cost and Freight), CIF (description- Cost, Insurance and Freight), CIP (description- Carriage and Insurance Paid To), DAF (description- Delivered at Frontier), DAP (description- Delivered At Place), DAT (description- Delivered At Terminal), DDP (description- Delivered Duty Paid), DDU (description- Delivered Duty Unpaid), DEQ (description- Delivery ex Quay), DES (description- Delivered ex Ship), DPU (description- Delivered At Place Unloaded), EXW (description- Ex Works), FAS (description- FAS Free Alongside Ship), FCA (description- Free Carrier), FOB (description- FOB Free On Board)</value>
        [DataMember(Name = "termsOfSale", EmitDefaultValue = false)]
        public TermsOfSaleEnum? TermsOfSale { get; set; }
        /// <summary>
        /// The tax type to choose for recipient.
        /// </summary>
        /// <value>The tax type to choose for recipient.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecipientTaxTypeEnum
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
            /// Enum RFC for value: RFC
            /// </summary>
            [EnumMember(Value = "RFC")]
            RFC = 3,

            /// <summary>
            /// Enum VAT for value: VAT
            /// </summary>
            [EnumMember(Value = "VAT")]
            VAT = 4
        }


        /// <summary>
        /// The tax type to choose for recipient.
        /// </summary>
        /// <value>The tax type to choose for recipient.</value>
        [DataMember(Name = "recipientTaxType", EmitDefaultValue = false)]
        public RecipientTaxTypeEnum? RecipientTaxType { get; set; }
        /// <summary>
        /// The tax type to choose for recipient.
        /// </summary>
        /// <value>The tax type to choose for recipient.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SenderTaxTypeEnum
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
            /// Enum RFC for value: RFC
            /// </summary>
            [EnumMember(Value = "RFC")]
            RFC = 3,

            /// <summary>
            /// Enum VAT for value: VAT
            /// </summary>
            [EnumMember(Value = "VAT")]
            VAT = 4
        }


        /// <summary>
        /// The tax type to choose for recipient.
        /// </summary>
        /// <value>The tax type to choose for recipient.</value>
        [DataMember(Name = "senderTaxType", EmitDefaultValue = false)]
        public SenderTaxTypeEnum? SenderTaxType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InternationalShipmentResponseCustomsCustomsInfo" /> class.
        /// </summary>
        /// <param name="eELPFC">A number provided by the Automated Export System (AES). This is required if the item is valued at more than $2,500 USD per Schedule B export codes..</param>
        /// <param name="certificateNumber">The certificate number associated with the commodity..</param>
        /// <param name="comments">Free-form comments regarding the exported shipment..</param>
        /// <param name="currencyCode">The currency used for declared value. Use three uppercase letters, per ISO 4217..</param>
        /// <param name="fromCustomsReference">Free-form reference information provided by the requestor of the shipment. Depending on the carrier this information may or may not be rendered on the customs documents..</param>
        /// <param name="importerCustomsReference">A reference number used by the importer, such as a VAT number, PO number, or insured number..</param>
        /// <param name="invoiceNumber">The commercial invoice number assigned by the exporter. It is rquired for DHL Express..</param>
        /// <param name="licenseNumber">The export license number associated with the commodity..</param>
        /// <param name="reasonForExport">The reason the commodity is being exported..</param>
        /// <param name="sdrValue">When an international parcel is insured, the insured value must be expressed in Special Drawing Rights values..</param>
        /// <param name="termsOfSale">Three-digit codes describing Terms of sale required for DHL Express shipments. Terms of sale is some sort of agreement between a buyer and seller which serves the purpose of creating uniform expectations between them. Possible values are- CFR (description- Cost and Freight), CIF (description- Cost, Insurance and Freight), CIP (description- Carriage and Insurance Paid To), DAF (description- Delivered at Frontier), DAP (description- Delivered At Place), DAT (description- Delivered At Terminal), DDP (description- Delivered Duty Paid), DDU (description- Delivered Duty Unpaid), DEQ (description- Delivery ex Quay), DES (description- Delivered ex Ship), DPU (description- Delivered At Place Unloaded), EXW (description- Ex Works), FAS (description- FAS Free Alongside Ship), FCA (description- Free Carrier), FOB (description- FOB Free On Board).</param>
        /// <param name="recipientTaxType">The tax type to choose for recipient..</param>
        /// <param name="recipientTaxID">The respective taxID for the taxType chosen.</param>
        /// <param name="senderTaxType">The tax type to choose for recipient..</param>
        /// <param name="senderTaxID">The respective taxID for the taxType chosen.</param>
        public InternationalShipmentResponseCustomsCustomsInfo(string eELPFC = default(string), string certificateNumber = default(string), string comments = default(string), string currencyCode = default(string), string fromCustomsReference = default(string), string importerCustomsReference = default(string), string invoiceNumber = default(string), string licenseNumber = default(string), string reasonForExport = default(string), decimal sdrValue = default(decimal), TermsOfSaleEnum? termsOfSale = default(TermsOfSaleEnum?), RecipientTaxTypeEnum? recipientTaxType = default(RecipientTaxTypeEnum?), string recipientTaxID = default(string), SenderTaxTypeEnum? senderTaxType = default(SenderTaxTypeEnum?), string senderTaxID = default(string))
        {
            this.EELPFC = eELPFC;
            this.CertificateNumber = certificateNumber;
            this.Comments = comments;
            this.CurrencyCode = currencyCode;
            this.FromCustomsReference = fromCustomsReference;
            this.ImporterCustomsReference = importerCustomsReference;
            this.InvoiceNumber = invoiceNumber;
            this.LicenseNumber = licenseNumber;
            this.ReasonForExport = reasonForExport;
            this.SdrValue = sdrValue;
            this.TermsOfSale = termsOfSale;
            this.RecipientTaxType = recipientTaxType;
            this.RecipientTaxID = recipientTaxID;
            this.SenderTaxType = senderTaxType;
            this.SenderTaxID = senderTaxID;
        }

        /// <summary>
        /// A number provided by the Automated Export System (AES). This is required if the item is valued at more than $2,500 USD per Schedule B export codes.
        /// </summary>
        /// <value>A number provided by the Automated Export System (AES). This is required if the item is valued at more than $2,500 USD per Schedule B export codes.</value>
        /// <example>NOEEI 30.2D2</example>
        [DataMember(Name = "EELPFC", EmitDefaultValue = false)]
        public string EELPFC { get; set; }

        /// <summary>
        /// The certificate number associated with the commodity.
        /// </summary>
        /// <value>The certificate number associated with the commodity.</value>
        /// <example>98788877</example>
        [DataMember(Name = "certificateNumber", EmitDefaultValue = false)]
        public string CertificateNumber { get; set; }

        /// <summary>
        /// Free-form comments regarding the exported shipment.
        /// </summary>
        /// <value>Free-form comments regarding the exported shipment.</value>
        /// <example>test comment</example>
        [DataMember(Name = "comments", EmitDefaultValue = false)]
        public string Comments { get; set; }

        /// <summary>
        /// The currency used for declared value. Use three uppercase letters, per ISO 4217.
        /// </summary>
        /// <value>The currency used for declared value. Use three uppercase letters, per ISO 4217.</value>
        /// <example>CAD</example>
        [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// Free-form reference information provided by the requestor of the shipment. Depending on the carrier this information may or may not be rendered on the customs documents.
        /// </summary>
        /// <value>Free-form reference information provided by the requestor of the shipment. Depending on the carrier this information may or may not be rendered on the customs documents.</value>
        /// <example>11111</example>
        [DataMember(Name = "fromCustomsReference", EmitDefaultValue = false)]
        public string FromCustomsReference { get; set; }

        /// <summary>
        /// A reference number used by the importer, such as a VAT number, PO number, or insured number.
        /// </summary>
        /// <value>A reference number used by the importer, such as a VAT number, PO number, or insured number.</value>
        /// <example>987654</example>
        [DataMember(Name = "importerCustomsReference", EmitDefaultValue = false)]
        public string ImporterCustomsReference { get; set; }

        /// <summary>
        /// The commercial invoice number assigned by the exporter. It is rquired for DHL Express.
        /// </summary>
        /// <value>The commercial invoice number assigned by the exporter. It is rquired for DHL Express.</value>
        /// <example>001189223</example>
        [DataMember(Name = "invoiceNumber", EmitDefaultValue = false)]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// The export license number associated with the commodity.
        /// </summary>
        /// <value>The export license number associated with the commodity.</value>
        /// <example>456ABC123</example>
        [DataMember(Name = "licenseNumber", EmitDefaultValue = false)]
        public string LicenseNumber { get; set; }

        /// <summary>
        /// The reason the commodity is being exported.
        /// </summary>
        /// <value>The reason the commodity is being exported.</value>
        /// <example>DOCUMENTS</example>
        [DataMember(Name = "reasonForExport", EmitDefaultValue = false)]
        public string ReasonForExport { get; set; }

        /// <summary>
        /// When an international parcel is insured, the insured value must be expressed in Special Drawing Rights values.
        /// </summary>
        /// <value>When an international parcel is insured, the insured value must be expressed in Special Drawing Rights values.</value>
        /// <example>23.32</example>
        [DataMember(Name = "sdrValue", EmitDefaultValue = false)]
        public decimal SdrValue { get; set; }

        /// <summary>
        /// The respective taxID for the taxType chosen
        /// </summary>
        /// <value>The respective taxID for the taxType chosen</value>
        /// <example>1828800</example>
        [DataMember(Name = "recipientTaxID", EmitDefaultValue = false)]
        public string RecipientTaxID { get; set; }

        /// <summary>
        /// The respective taxID for the taxType chosen
        /// </summary>
        /// <value>The respective taxID for the taxType chosen</value>
        /// <example>1828800</example>
        [DataMember(Name = "senderTaxID", EmitDefaultValue = false)]
        public string SenderTaxID { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InternationalShipmentResponseCustomsCustomsInfo {\n");
            sb.Append("  EELPFC: ").Append(EELPFC).Append("\n");
            sb.Append("  CertificateNumber: ").Append(CertificateNumber).Append("\n");
            sb.Append("  Comments: ").Append(Comments).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  FromCustomsReference: ").Append(FromCustomsReference).Append("\n");
            sb.Append("  ImporterCustomsReference: ").Append(ImporterCustomsReference).Append("\n");
            sb.Append("  InvoiceNumber: ").Append(InvoiceNumber).Append("\n");
            sb.Append("  LicenseNumber: ").Append(LicenseNumber).Append("\n");
            sb.Append("  ReasonForExport: ").Append(ReasonForExport).Append("\n");
            sb.Append("  SdrValue: ").Append(SdrValue).Append("\n");
            sb.Append("  TermsOfSale: ").Append(TermsOfSale).Append("\n");
            sb.Append("  RecipientTaxType: ").Append(RecipientTaxType).Append("\n");
            sb.Append("  RecipientTaxID: ").Append(RecipientTaxID).Append("\n");
            sb.Append("  SenderTaxType: ").Append(SenderTaxType).Append("\n");
            sb.Append("  SenderTaxID: ").Append(SenderTaxID).Append("\n");
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
