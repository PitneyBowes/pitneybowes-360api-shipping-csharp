/*
 * Shipping APIs
 *
 * ### Introduction  The Shipping APIs include a variety of operations that allow users to manage and track their shipping requests.   Some of the key API operations available in the Shipping API includes: ### Shipment API  | Operation      | Description | | - -- -- -- -- -- | - -- -- -- -- -- |  | Get Carriers    | This operation fetches all onboarded carriers. Typically, user will use this service to get list of onboarded carriers and supported properties for those carriers.  |  | Get Countries | This operation fetches list of supported destination countries for a provided carrier and origin country.  |  | Get Services | This operation fetches a list of supported services for a carrier with respect to specific origin and destination country. |  | Get ParcelTypes| This operation fetches ParcelTypes based on carrier, origin and destination country. |  | Get Special Services| This operation fetches Special Services for a given carrier, service, origin and destination country. |  | Get Carrier Accounts| This operation retrieves onboarded Carriers with their Carrier Account Ids which uniquely identify multiple accounts of same carrier.  |  | Rate Shop and Get Single Rate| This API contains 2 operations, rate shop and single rate. Rate shop will fetch rates for all carrier services based on the given addresses (From and To), weight, and dimension for given parcelType. Single rate will get rate for specific service and special service (if requested) based on the given addresses (From and To), weight, and dimension, parcelType and serviceId with or without specialServices. Single rate will be used mainly to a rate a shipment before creating shipment.  |  | Create Shipment| This operation creates a new Shipment or Shipment Label. This is for both Domestic and International. | | Get All Shipments| This operation fetches all created Shipments. |  | Get Shipment by Id| Retrieves single shipment using Shipment Id. |  | Reprint Shipment| This operation reprints Shipment by the shipmentId. It retrieves an existing shipping label to reprint. The API sends the shipmentId returned by the original Created Shipment request. Use this only if the shipping label in the Create Shipment response was spoilt or lost. |  | Cancel Shipment| This operation cancels previously created shipment. |  
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using Xunit;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using com.pitneybowes.api360.Model;
using com.pitneybowes.api360.Client;
using System.Reflection;
using Newtonsoft.Json;

namespace com.pitneybowes.api360.Test.Model
{
    /// <summary>
    ///  Class for testing InternationalShipmentResponse
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class InternationalShipmentResponseTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for InternationalShipmentResponse
        //private InternationalShipmentResponse instance;

        public InternationalShipmentResponseTests()
        {
            // TODO uncomment below to create an instance of InternationalShipmentResponse
            //instance = new InternationalShipmentResponse();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InternationalShipmentResponse
        /// </summary>
        [Fact]
        public void InternationalShipmentResponseInstanceTest()
        {
            // TODO uncomment below to test "IsType" InternationalShipmentResponse
            //Assert.IsType<InternationalShipmentResponse>(instance);
        }

        /// <summary>
        /// Test the property 'CorrelationId'
        /// </summary>
        [Fact]
        public void CorrelationIdTest()
        {
            // TODO unit test for the property 'CorrelationId'
        }

        /// <summary>
        /// Test the property 'LabelLayout'
        /// </summary>
        [Fact]
        public void LabelLayoutTest()
        {
            // TODO unit test for the property 'LabelLayout'
        }

        /// <summary>
        /// Test the property 'FromAddress'
        /// </summary>
        [Fact]
        public void FromAddressTest()
        {
            // TODO unit test for the property 'FromAddress'
        }

        /// <summary>
        /// Test the property 'Parcel'
        /// </summary>
        [Fact]
        public void ParcelTest()
        {
            // TODO unit test for the property 'Parcel'
        }

        /// <summary>
        /// Test the property 'ParcelId'
        /// </summary>
        [Fact]
        public void ParcelIdTest()
        {
            // TODO unit test for the property 'ParcelId'
        }

        /// <summary>
        /// Test the property 'ParcelTrackingNumber'
        /// </summary>
        [Fact]
        public void ParcelTrackingNumberTest()
        {
            // TODO unit test for the property 'ParcelTrackingNumber'
        }

        /// <summary>
        /// Test the property 'Rate'
        /// </summary>
        [Fact]
        public void RateTest()
        {
            // TODO unit test for the property 'Rate'
        }

        /// <summary>
        /// Test the property 'ShipmentId'
        /// </summary>
        [Fact]
        public void ShipmentIdTest()
        {
            // TODO unit test for the property 'ShipmentId'
        }

        /// <summary>
        /// Test the property 'ShipmentOptions'
        /// </summary>
        [Fact]
        public void ShipmentOptionsTest()
        {
            // TODO unit test for the property 'ShipmentOptions'
        }

        /// <summary>
        /// Test the property 'ToAddress'
        /// </summary>
        [Fact]
        public void ToAddressTest()
        {
            // TODO unit test for the property 'ToAddress'
        }

        /// <summary>
        /// Test the property 'Customs'
        /// </summary>
        [Fact]
        public void CustomsTest()
        {
            // TODO unit test for the property 'Customs'
        }
    }
}
