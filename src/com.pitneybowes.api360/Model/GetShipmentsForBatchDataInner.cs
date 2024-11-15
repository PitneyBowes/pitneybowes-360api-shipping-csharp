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
    /// GetShipmentsForBatchDataInner
    /// </summary>
    [DataContract(Name = "getShipmentsForBatch_data_inner")]
    public partial class GetShipmentsForBatchDataInner : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetShipmentsForBatchDataInner" /> class.
        /// </summary>
        /// <param name="batchId">This is a system-generated unique identifier assigned to the Batch while it is processed..</param>
        /// <param name="carrierAccountId">A unique identifier associated with the Carrier account used by client users during shipment process..</param>
        /// <param name="externalId">This is a user-defined value provided by users just for their reference. This is for mapping purpose against each shipment..</param>
        /// <param name="fromAddress">fromAddress.</param>
        /// <param name="labelLayout">labelLayout.</param>
        /// <param name="metadata">Additional metadata that needs to be stored for this shipment can be added here. For now, &#x60;costAccountName&#x60; is supported..</param>
        /// <param name="parcel">parcel.</param>
        /// <param name="parcelType">Parcel Type is required for creating a shipment while rating a parcel. And it varies as per carrier selection and corresponding services..</param>
        /// <param name="serviceId">A unique identifier given to the carrier-specific service. User can override this value by defining it at Shipment level..</param>
        /// <param name="shipmentId">Shipment ID is a unique identifier for an individual shipment.</param>
        /// <param name="shipmentIdentifier">Unique identifier generated for each shipment, it can be either success or failed..</param>
        /// <param name="shipmentOptions">shipmentOptions.</param>
        /// <param name="specialServices">Special services used to create shipment.</param>
        /// <param name="stepStatus">stepStatus.</param>
        /// <param name="toAddress">toAddress.</param>
        public GetShipmentsForBatchDataInner(string batchId = default(string), string carrierAccountId = default(string), string externalId = default(string), FromAddress fromAddress = default(FromAddress), GetShipmentsForBatchDataInnerLabelLayout labelLayout = default(GetShipmentsForBatchDataInnerLabelLayout), List<GetShipmentsForBatchDataInnerMetadataInner> metadata = default(List<GetShipmentsForBatchDataInnerMetadataInner>), Parcel parcel = default(Parcel), string parcelType = default(string), string serviceId = default(string), string shipmentId = default(string), string shipmentIdentifier = default(string), ShipmentOptions shipmentOptions = default(ShipmentOptions), List<GetShipmentsForBatchDataInnerSpecialServicesInner> specialServices = default(List<GetShipmentsForBatchDataInnerSpecialServicesInner>), GetShipmentsForBatchDataInnerStepStatus stepStatus = default(GetShipmentsForBatchDataInnerStepStatus), ToAddress toAddress = default(ToAddress))
        {
            this.BatchId = batchId;
            this.CarrierAccountId = carrierAccountId;
            this.ExternalId = externalId;
            this.FromAddress = fromAddress;
            this.LabelLayout = labelLayout;
            this.Metadata = metadata;
            this.Parcel = parcel;
            this.ParcelType = parcelType;
            this.ServiceId = serviceId;
            this.ShipmentId = shipmentId;
            this.ShipmentIdentifier = shipmentIdentifier;
            this.ShipmentOptions = shipmentOptions;
            this.SpecialServices = specialServices;
            this.StepStatus = stepStatus;
            this.ToAddress = toAddress;
        }

        /// <summary>
        /// This is a system-generated unique identifier assigned to the Batch while it is processed.
        /// </summary>
        /// <value>This is a system-generated unique identifier assigned to the Batch while it is processed.</value>
        /// <example>RgYgaV7mKax</example>
        [DataMember(Name = "batchId", EmitDefaultValue = false)]
        public string BatchId { get; set; }

        /// <summary>
        /// A unique identifier associated with the Carrier account used by client users during shipment process.
        /// </summary>
        /// <value>A unique identifier associated with the Carrier account used by client users during shipment process.</value>
        /// <example>GpoVzzeQ37l</example>
        [DataMember(Name = "carrierAccountId", EmitDefaultValue = false)]
        public string CarrierAccountId { get; set; }

        /// <summary>
        /// This is a user-defined value provided by users just for their reference. This is for mapping purpose against each shipment.
        /// </summary>
        /// <value>This is a user-defined value provided by users just for their reference. This is for mapping purpose against each shipment.</value>
        /// <example>1</example>
        [DataMember(Name = "externalId", EmitDefaultValue = false)]
        public string ExternalId { get; set; }

        /// <summary>
        /// Gets or Sets FromAddress
        /// </summary>
        [DataMember(Name = "fromAddress", EmitDefaultValue = false)]
        public FromAddress FromAddress { get; set; }

        /// <summary>
        /// Gets or Sets LabelLayout
        /// </summary>
        [DataMember(Name = "labelLayout", EmitDefaultValue = false)]
        public GetShipmentsForBatchDataInnerLabelLayout LabelLayout { get; set; }

        /// <summary>
        /// Additional metadata that needs to be stored for this shipment can be added here. For now, &#x60;costAccountName&#x60; is supported.
        /// </summary>
        /// <value>Additional metadata that needs to be stored for this shipment can be added here. For now, &#x60;costAccountName&#x60; is supported.</value>
        [DataMember(Name = "metadata", EmitDefaultValue = false)]
        public List<GetShipmentsForBatchDataInnerMetadataInner> Metadata { get; set; }

        /// <summary>
        /// Gets or Sets Parcel
        /// </summary>
        [DataMember(Name = "parcel", EmitDefaultValue = false)]
        public Parcel Parcel { get; set; }

        /// <summary>
        /// Parcel Type is required for creating a shipment while rating a parcel. And it varies as per carrier selection and corresponding services.
        /// </summary>
        /// <value>Parcel Type is required for creating a shipment while rating a parcel. And it varies as per carrier selection and corresponding services.</value>
        /// <example>LP</example>
        [DataMember(Name = "parcelType", EmitDefaultValue = false)]
        public string ParcelType { get; set; }

        /// <summary>
        /// A unique identifier given to the carrier-specific service. User can override this value by defining it at Shipment level.
        /// </summary>
        /// <value>A unique identifier given to the carrier-specific service. User can override this value by defining it at Shipment level.</value>
        /// <example>LIB</example>
        [DataMember(Name = "serviceId", EmitDefaultValue = false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// Shipment ID is a unique identifier for an individual shipment
        /// </summary>
        /// <value>Shipment ID is a unique identifier for an individual shipment</value>
        /// <example>USPS2200589023653912</example>
        [DataMember(Name = "shipmentId", EmitDefaultValue = false)]
        public string ShipmentId { get; set; }

        /// <summary>
        /// Unique identifier generated for each shipment, it can be either success or failed.
        /// </summary>
        /// <value>Unique identifier generated for each shipment, it can be either success or failed.</value>
        /// <example>USPS2200589023653912</example>
        [DataMember(Name = "shipmentIdentifier", EmitDefaultValue = false)]
        public string ShipmentIdentifier { get; set; }

        /// <summary>
        /// Gets or Sets ShipmentOptions
        /// </summary>
        [DataMember(Name = "shipmentOptions", EmitDefaultValue = false)]
        public ShipmentOptions ShipmentOptions { get; set; }

        /// <summary>
        /// Special services used to create shipment
        /// </summary>
        /// <value>Special services used to create shipment</value>
        /// <example>[{&quot;fee&quot;:0,&quot;specialServiceId&quot;:&quot;DelCon&quot;}]</example>
        [DataMember(Name = "specialServices", EmitDefaultValue = false)]
        public List<GetShipmentsForBatchDataInnerSpecialServicesInner> SpecialServices { get; set; }

        /// <summary>
        /// Gets or Sets StepStatus
        /// </summary>
        [DataMember(Name = "stepStatus", EmitDefaultValue = false)]
        public GetShipmentsForBatchDataInnerStepStatus StepStatus { get; set; }

        /// <summary>
        /// Gets or Sets ToAddress
        /// </summary>
        [DataMember(Name = "toAddress", EmitDefaultValue = false)]
        public ToAddress ToAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetShipmentsForBatchDataInner {\n");
            sb.Append("  BatchId: ").Append(BatchId).Append("\n");
            sb.Append("  CarrierAccountId: ").Append(CarrierAccountId).Append("\n");
            sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
            sb.Append("  FromAddress: ").Append(FromAddress).Append("\n");
            sb.Append("  LabelLayout: ").Append(LabelLayout).Append("\n");
            sb.Append("  Metadata: ").Append(Metadata).Append("\n");
            sb.Append("  Parcel: ").Append(Parcel).Append("\n");
            sb.Append("  ParcelType: ").Append(ParcelType).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  ShipmentId: ").Append(ShipmentId).Append("\n");
            sb.Append("  ShipmentIdentifier: ").Append(ShipmentIdentifier).Append("\n");
            sb.Append("  ShipmentOptions: ").Append(ShipmentOptions).Append("\n");
            sb.Append("  SpecialServices: ").Append(SpecialServices).Append("\n");
            sb.Append("  StepStatus: ").Append(StepStatus).Append("\n");
            sb.Append("  ToAddress: ").Append(ToAddress).Append("\n");
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
