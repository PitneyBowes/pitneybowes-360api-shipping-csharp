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
    /// GetSingleShipmentRate
    /// </summary>
    [DataContract(Name = "getSingleShipment_rate")]
    public partial class GetSingleShipmentRate : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetSingleShipmentRate" /> class.
        /// </summary>
        /// <param name="baseCharge">The base service charge is payable to the carrier, excluding special service charges..</param>
        /// <param name="carrier">Carrier is a service used to transport the parcels or couriers from one place to another..</param>
        /// <param name="currencyCode">A three-character (all uppercase letter) symbol of a currency according to the international ISO standard. As a rule, the first two letters denote the name of the country, and the third letter, the name of the currency thereof.For example, for US - the currency is Dollars and code is USD. Similarly for Canada, the currencycode is CAD, and for India, it is INR. .</param>
        /// <param name="inductionPostalCode">The postal code where a shipment or shipments are tendered to a carrier. This can be different from the Sender’s address..</param>
        /// <param name="parcelType">Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection. ParcelType have categories like Package, Envelopes, Paks, Boxes, Tube, etc. .</param>
        /// <param name="rateTypeId">Its value can be CONTRACT_RATES, COMMERCIAL or COMMERCIAL_BASE for USPS and COMMERCIAL for other carriers depending on the Pitney Bowes contract/subscription.</param>
        /// <param name="serviceId">The unique identifier given to the carrier specific service..</param>
        /// <param name="specialServices">This provides a carrier-service based special or extra sevice..</param>
        /// <param name="totalCarrierCharge">The total amount payable to the carrier, including special service fees, surcharges, and any international taxes and duties, except as noted below:.</param>
        public GetSingleShipmentRate(decimal baseCharge = default(decimal), string carrier = default(string), string currencyCode = default(string), string inductionPostalCode = default(string), string parcelType = default(string), string rateTypeId = default(string), string serviceId = default(string), List<GetSingleShipmentRateSpecialServicesInner> specialServices = default(List<GetSingleShipmentRateSpecialServicesInner>), decimal totalCarrierCharge = default(decimal))
        {
            this.BaseCharge = baseCharge;
            this.Carrier = carrier;
            this.CurrencyCode = currencyCode;
            this.InductionPostalCode = inductionPostalCode;
            this.ParcelType = parcelType;
            this.RateTypeId = rateTypeId;
            this.ServiceId = serviceId;
            this.SpecialServices = specialServices;
            this.TotalCarrierCharge = totalCarrierCharge;
        }

        /// <summary>
        /// The base service charge is payable to the carrier, excluding special service charges.
        /// </summary>
        /// <value>The base service charge is payable to the carrier, excluding special service charges.</value>
        /// <example>25.5</example>
        [DataMember(Name = "baseCharge", EmitDefaultValue = false)]
        public decimal BaseCharge { get; set; }

        /// <summary>
        /// Carrier is a service used to transport the parcels or couriers from one place to another.
        /// </summary>
        /// <value>Carrier is a service used to transport the parcels or couriers from one place to another.</value>
        /// <example>USPS</example>
        [DataMember(Name = "carrier", EmitDefaultValue = false)]
        public string Carrier { get; set; }

        /// <summary>
        /// A three-character (all uppercase letter) symbol of a currency according to the international ISO standard. As a rule, the first two letters denote the name of the country, and the third letter, the name of the currency thereof.For example, for US - the currency is Dollars and code is USD. Similarly for Canada, the currencycode is CAD, and for India, it is INR. 
        /// </summary>
        /// <value>A three-character (all uppercase letter) symbol of a currency according to the international ISO standard. As a rule, the first two letters denote the name of the country, and the third letter, the name of the currency thereof.For example, for US - the currency is Dollars and code is USD. Similarly for Canada, the currencycode is CAD, and for India, it is INR. </value>
        /// <example>USD</example>
        [DataMember(Name = "currencyCode", EmitDefaultValue = false)]
        public string CurrencyCode { get; set; }

        /// <summary>
        /// The postal code where a shipment or shipments are tendered to a carrier. This can be different from the Sender’s address.
        /// </summary>
        /// <value>The postal code where a shipment or shipments are tendered to a carrier. This can be different from the Sender’s address.</value>
        /// <example>06905</example>
        [DataMember(Name = "inductionPostalCode", EmitDefaultValue = false)]
        public string InductionPostalCode { get; set; }

        /// <summary>
        /// Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection. ParcelType have categories like Package, Envelopes, Paks, Boxes, Tube, etc. 
        /// </summary>
        /// <value>Parcel Type is required for creating a shipment while rating a parcel, which varies as per Carrier selection. ParcelType have categories like Package, Envelopes, Paks, Boxes, Tube, etc. </value>
        /// <example>PKG</example>
        [DataMember(Name = "parcelType", EmitDefaultValue = false)]
        public string ParcelType { get; set; }

        /// <summary>
        /// Its value can be CONTRACT_RATES, COMMERCIAL or COMMERCIAL_BASE for USPS and COMMERCIAL for other carriers depending on the Pitney Bowes contract/subscription
        /// </summary>
        /// <value>Its value can be CONTRACT_RATES, COMMERCIAL or COMMERCIAL_BASE for USPS and COMMERCIAL for other carriers depending on the Pitney Bowes contract/subscription</value>
        /// <example>CONTRACT_RATES</example>
        [DataMember(Name = "rateTypeId", EmitDefaultValue = false)]
        public string RateTypeId { get; set; }

        /// <summary>
        /// The unique identifier given to the carrier specific service.
        /// </summary>
        /// <value>The unique identifier given to the carrier specific service.</value>
        /// <example>EM</example>
        [DataMember(Name = "serviceId", EmitDefaultValue = false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// This provides a carrier-service based special or extra sevice.
        /// </summary>
        /// <value>This provides a carrier-service based special or extra sevice.</value>
        /// <example>[{&quot;fee&quot;:88.5,&quot;inputParameters&quot;:[{&quot;name&quot;:&quot;INPUT_VALUE&quot;,&quot;value&quot;:&quot;5000&quot;}],&quot;specialServiceId&quot;:&quot;Ins&quot;},{&quot;fee&quot;:3.35,&quot;inputParameters&quot;:[{&quot;name&quot;:&quot;INPUT_VALUE&quot;,&quot;value&quot;:&quot;12345&quot;}],&quot;specialServiceId&quot;:&quot;RR&quot;},{&quot;fee&quot;:0,&quot;specialServiceId&quot;:&quot;liveanimal&quot;},{&quot;fee&quot;:0,&quot;specialServiceId&quot;:&quot;Sig&quot;},{&quot;fee&quot;:0,&quot;specialServiceId&quot;:&quot;PO to Addressee&quot;}]</example>
        [DataMember(Name = "specialServices", EmitDefaultValue = false)]
        public List<GetSingleShipmentRateSpecialServicesInner> SpecialServices { get; set; }

        /// <summary>
        /// The total amount payable to the carrier, including special service fees, surcharges, and any international taxes and duties, except as noted below:
        /// </summary>
        /// <value>The total amount payable to the carrier, including special service fees, surcharges, and any international taxes and duties, except as noted below:</value>
        /// <example>117.35</example>
        [DataMember(Name = "totalCarrierCharge", EmitDefaultValue = false)]
        public decimal TotalCarrierCharge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GetSingleShipmentRate {\n");
            sb.Append("  BaseCharge: ").Append(BaseCharge).Append("\n");
            sb.Append("  Carrier: ").Append(Carrier).Append("\n");
            sb.Append("  CurrencyCode: ").Append(CurrencyCode).Append("\n");
            sb.Append("  InductionPostalCode: ").Append(InductionPostalCode).Append("\n");
            sb.Append("  ParcelType: ").Append(ParcelType).Append("\n");
            sb.Append("  RateTypeId: ").Append(RateTypeId).Append("\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  SpecialServices: ").Append(SpecialServices).Append("\n");
            sb.Append("  TotalCarrierCharge: ").Append(TotalCarrierCharge).Append("\n");
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
