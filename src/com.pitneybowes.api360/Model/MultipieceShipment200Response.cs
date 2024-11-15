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
using System.Reflection;

namespace com.pitneybowes.api360.Model
{
    /// <summary>
    /// MultipieceShipment200Response
    /// </summary>
    [JsonConverter(typeof(MultipieceShipment200ResponseJsonConverter))]
    [DataContract(Name = "multipieceShipment_200_response")]
    public partial class MultipieceShipment200Response : AbstractOpenAPISchema, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipieceShipment200Response" /> class
        /// with the <see cref="MultipieceDomesticShipmentResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of MultipieceDomesticShipmentResponse.</param>
        public MultipieceShipment200Response(MultipieceDomesticShipmentResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultipieceShipment200Response" /> class
        /// with the <see cref="MultipieceInternationalShipmentResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of MultipieceInternationalShipmentResponse.</param>
        public MultipieceShipment200Response(MultipieceInternationalShipmentResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(MultipieceDomesticShipmentResponse) || value is MultipieceDomesticShipmentResponse)
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(MultipieceInternationalShipmentResponse) || value is MultipieceInternationalShipmentResponse)
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: MultipieceDomesticShipmentResponse, MultipieceInternationalShipmentResponse");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `MultipieceDomesticShipmentResponse`. If the actual instance is not `MultipieceDomesticShipmentResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of MultipieceDomesticShipmentResponse</returns>
        public MultipieceDomesticShipmentResponse GetMultipieceDomesticShipmentResponse()
        {
            return (MultipieceDomesticShipmentResponse)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `MultipieceInternationalShipmentResponse`. If the actual instance is not `MultipieceInternationalShipmentResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of MultipieceInternationalShipmentResponse</returns>
        public MultipieceInternationalShipmentResponse GetMultipieceInternationalShipmentResponse()
        {
            return (MultipieceInternationalShipmentResponse)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultipieceShipment200Response {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, MultipieceShipment200Response.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of MultipieceShipment200Response
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of MultipieceShipment200Response</returns>
        public static MultipieceShipment200Response FromJson(string jsonString)
        {
            MultipieceShipment200Response newMultipieceShipment200Response = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newMultipieceShipment200Response;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(MultipieceDomesticShipmentResponse).GetProperty("AdditionalProperties") == null)
                {
                    newMultipieceShipment200Response = new MultipieceShipment200Response(JsonConvert.DeserializeObject<MultipieceDomesticShipmentResponse>(jsonString, MultipieceShipment200Response.SerializerSettings));
                }
                else
                {
                    newMultipieceShipment200Response = new MultipieceShipment200Response(JsonConvert.DeserializeObject<MultipieceDomesticShipmentResponse>(jsonString, MultipieceShipment200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("MultipieceDomesticShipmentResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into MultipieceDomesticShipmentResponse: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(MultipieceInternationalShipmentResponse).GetProperty("AdditionalProperties") == null)
                {
                    newMultipieceShipment200Response = new MultipieceShipment200Response(JsonConvert.DeserializeObject<MultipieceInternationalShipmentResponse>(jsonString, MultipieceShipment200Response.SerializerSettings));
                }
                else
                {
                    newMultipieceShipment200Response = new MultipieceShipment200Response(JsonConvert.DeserializeObject<MultipieceInternationalShipmentResponse>(jsonString, MultipieceShipment200Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("MultipieceInternationalShipmentResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into MultipieceInternationalShipmentResponse: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + String.Join(",", matchedTypes));
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newMultipieceShipment200Response;
        }


        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for MultipieceShipment200Response
    /// </summary>
    public class MultipieceShipment200ResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(MultipieceShipment200Response).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            switch(reader.TokenType) 
            {
                case JsonToken.StartObject:
                    return MultipieceShipment200Response.FromJson(JObject.Load(reader).ToString(Formatting.None));
                case JsonToken.StartArray:
                    return MultipieceShipment200Response.FromJson(JArray.Load(reader).ToString(Formatting.None));
                default:
                    return null;
            }
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
