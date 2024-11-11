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
    ///  Class for testing MultipieceInternationalShipmentRequest
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the model.
    /// </remarks>
    public class MultipieceInternationalShipmentRequestTests : IDisposable
    {
        // TODO uncomment below to declare an instance variable for MultipieceInternationalShipmentRequest
        //private MultipieceInternationalShipmentRequest instance;

        public MultipieceInternationalShipmentRequestTests()
        {
            // TODO uncomment below to create an instance of MultipieceInternationalShipmentRequest
            //instance = new MultipieceInternationalShipmentRequest();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of MultipieceInternationalShipmentRequest
        /// </summary>
        [Fact]
        public void MultipieceInternationalShipmentRequestInstanceTest()
        {
            // TODO uncomment below to test "IsType" MultipieceInternationalShipmentRequest
            //Assert.IsType<MultipieceInternationalShipmentRequest>(instance);
        }

        /// <summary>
        /// Test the property 'Size'
        /// </summary>
        [Fact]
        public void SizeTest()
        {
            // TODO unit test for the property 'Size'
        }

        /// <summary>
        /// Test the property 'Type'
        /// </summary>
        [Fact]
        public void TypeTest()
        {
            // TODO unit test for the property 'Type'
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
        /// Test the property 'CarrierAccountId'
        /// </summary>
        [Fact]
        public void CarrierAccountIdTest()
        {
            // TODO unit test for the property 'CarrierAccountId'
        }

        /// <summary>
        /// Test the property 'ServiceId'
        /// </summary>
        [Fact]
        public void ServiceIdTest()
        {
            // TODO unit test for the property 'ServiceId'
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
        /// Test the property 'Metadata'
        /// </summary>
        [Fact]
        public void MetadataTest()
        {
            // TODO unit test for the property 'Metadata'
        }

        /// <summary>
        /// Test the property 'MultiPieceParcels'
        /// </summary>
        [Fact]
        public void MultiPieceParcelsTest()
        {
            // TODO unit test for the property 'MultiPieceParcels'
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
