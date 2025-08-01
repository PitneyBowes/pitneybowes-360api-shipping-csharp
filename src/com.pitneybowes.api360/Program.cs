using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Extensions;
using com.pitneybowes.api360.Model;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.pitneybowes.api360
{
    public class Program
    {
        public static async Task Main(string[] args)
        {/*
            var host = CreateHostBuilder(args).Build();
            var api = host.GetRequiredService<IShipmentApi>();
            bool isReturn = false;
            Option<ByCarrierV2?> byCarrier = new ByCarrierV2("eRMnRx4mzPP", "USPS", "EM");
            ShipmentDomesticByCarrier shiReqByCarrier = new ShipmentDomesticByCarrier(
                new FromAddressV2("Name", "24182 Kathy Ave", "203-555-1213", "Lake Forest", "CA", "92630-1827", "US"),
                new ToAddressV2("Paul Wright", "55 Pharr Rd NW, Apt E104", "Atlanta", "GA", "30305-2151", "US", "203-555-1213"), "PKG",
                ShipmentDomesticByCarrier.RateShopByEnum.Carrier, ShipmentDomesticByCarrier.LabelSizeEnum.DOC4X6,
                ShipmentDomesticByCarrier.LabelTypeEnum.SHIPPINGLABEL, ShipmentDomesticByCarrier.LabelFormatEnum.PDF);
            shiReqByCarrier.ByCarrier = byCarrier;
            CreateShipmentV2Request createShipmentV2Request = new CreateShipmentV2Request(shiReqByCarrier);
            Client.Option<string> xPBDeveloperPartnerId = "";
            Client.Option<string> xPBLocationId = "";
            Client.Option<string> xPBTransactionId = "TEST_00001_0001_001";
            Client.Option<string> xPBDefaultID = "";
            Client.Option<string> includeDeliveryCommitment = "No";
            var response = await api.CreateShipmentV2Async(isReturn, createShipmentV2Request, xPBDeveloperPartnerId, xPBLocationId, xPBTransactionId, xPBDefaultID, includeDeliveryCommitment);
            var model = response.Ok();*/
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
            .ConfigureApi((context, services, options) =>
            {
                string bearerTokenValue1 = "eyJraWQiOiJIcEQ0UGY2dWFUQThIUEdDZk5wVkprYjczTTBZWFl0V2dVNjl1djJWYUpzIiwiYWxnIjoiUlMyNTYifQ.eyJ2ZXIiOjEsImp0aSI6IkFULlZka0JyU3NLamtPQjQ0ZTY0QzNDeUhOQTdEcWQyTlBIdjJnNTVYTVpqMnciLCJpc3MiOiJodHRwczovL3BpdG5leWJvd2VzLm9rdGFwcmV2aWV3LmNvbS9vYXV0aDIvYXVzMWtyYWcxazJuc2htWTgwaDgiLCJhdWQiOiJodHRwczovL2FwaS5waXRuZXlib3dlcy5jb20iLCJzdWIiOiJBUEktU1AzNjAtQndlRTdZTmVLb2EtREVWIiwiaWF0IjoxNzUzOTc1ODk0LCJleHAiOjE3NTM5OTAyOTQsImNpZCI6IjBvYTFteXZ4Y3RiUHo5Y1c3MGg4Iiwic2NwIjpbInBzYXBpIl0sInN2Y1ZlciI6IjMuMCIsImNsYWltX3BzYXBpIjp7ImVudElEIjoid1pyd1pWdlFCcEUiLCJ1aWQiOiIwb2ExbXl2eGN0YlB6OWNXNzBoOCIsInN1YklEIjoic2E4N2JmMCIsInBhcmVudFBsYW4iOiJQSVRORVlTSElQX1BSTyIsImN0eXAiOiJjb21tZXJjaWFsIiwiY250cnkiOiJVUyIsInBsYW5zIjpbIkFQSV9CQVNJQyIsIkFQSV9TRU5ESU5HX0JBU0lDIiwiREFUQVJFVEFJTl9QTEFOIiwiUElUTkVZU0hJUF9FTlRFUlBSSVNFIiwiU0VORElOR19FTlRFUlBSSVNFX1BMQU4iLCJDT05ORUNUT1JfRVBJQ19QTEFOIiwiQ09OTkVDVE9SX01DS19QTEFOIiwiQ09OTkVDVE9SX1NDUl9QTEFOIiwiRklSRUJBTExfMi4wIiwiNDM0MCIsIkFQSV9NQU5BR0UiLCJBVVRPTUFUSU9OX1JVTEVTIiwiQVVUT01BVElPTl9SVUxFU19BRFYiLCJBVVRPTUFUSU9OX1JVTEVTX09SREVSX0lNUE9SVCJdLCJkZXZJRCI6InNhODdiZjAiLCJwcmRJZCI6InBpdG5leXNoaXBfZW50In19.JvVDIVc9bT-Pfkr5hX6nzsa_eE7VF4p0kA2rr31SneK5cgsw9PYzvqCO9F5K3vjmUng0nrrKgbw_Gg6LtNj98seK9BFSJ3o_qGQ5OgrG6fDvMR3gAM7SFpI7CV_3RIQWz1-h-olSC7F-bbeTHRw6-3FLW-F61kSuitPXOfX8O_cv2TaaNDsHh2TcGzEXdxL-eHNcviMc89aXx0oDYJM6SVZrSEPnjBoUeu0cM2aSeO_NfhDKsQ8osL72iZ-CGKaDxyTu9W0sGqRIiuEQhfs6w6KW1YOtlqKyXZ5GE06YvBhd59qF4NOCTfCpCWUPv3PuNhovsYLOnFF4LSmN3u5Kzg";
                BearerToken bearerToken1 = new(bearerTokenValue1, timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(bearerToken1);

                string basicTokenUsername1 = "Test";
                string basicTokenPassword1 = "JaiShriRam";
                BasicToken basicToken1 = new(basicTokenUsername1, basicTokenPassword1, timeout: TimeSpan.FromSeconds(1));
                options.AddTokens(basicToken1);
            });
    }
}
