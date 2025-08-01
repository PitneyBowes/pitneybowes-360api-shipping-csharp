# Created with Openapi Generator

<a id="cli"></a>
## Creating the library
Create a config.yaml file similar to what is below, then run the following powershell command to generate the library `java -jar "<path>/openapi-generator/modules/openapi-generator-cli/target/openapi-generator-cli.jar" generate -c config.yaml`

```yaml
generatorName: csharp
inputSpec: ./shipping.yaml
outputDir: out

# https://openapi-generator.tech/docs/generators/csharp
additionalProperties:
  packageGuid: '{F46E0B5E-2057-49B9-9AD8-D522470E8210}'

# https://openapi-generator.tech/docs/integrations/#github-integration
# gitHost:
# gitUserId:
# gitRepoId:

# https://openapi-generator.tech/docs/globals
# globalProperties:

# https://openapi-generator.tech/docs/customization/#inline-schema-naming
# inlineSchemaOptions:

# https://openapi-generator.tech/docs/customization/#name-mapping
# modelNameMappings:
# nameMappings:

# https://openapi-generator.tech/docs/customization/#openapi-normalizer
# openapiNormalizer:

# templateDir: https://openapi-generator.tech/docs/templating/#modifying-templates

# releaseNote:
```

<a id="usage"></a>
## Using the library in your project

```cs
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using com.pitneybowes.api360.Api;
using com.pitneybowes.api360.Client;
using com.pitneybowes.api360.Model;
using Org.OpenAPITools.Extensions;

namespace YourProject
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            var api = host.Services.GetRequiredService<IDefaultsApi>();
            ICreateDefaultsApiResponse apiResponse = await api.CreateDefaultsAsync("todo");
            CreateDefaultsResponse? model = apiResponse.Ok();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) => Host.CreateDefaultBuilder(args)
          .ConfigureApi((context, services, options) =>
          {
              // The type of token here depends on the api security specifications
              // Available token types are ApiKeyToken, BasicToken, BearerToken, HttpSigningToken, and OAuthToken.
              BearerToken token = new("<your token>");
              options.AddTokens(token);

              // optionally choose the method the tokens will be provided with, default is RateLimitProvider
              options.UseProvider<RateLimitProvider<BearerToken>, BearerToken>();

              options.ConfigureJsonOptions((jsonOptions) =>
              {
                  // your custom converters if any
              });

              options.AddApiHttpClients(client =>
              {
                  // client configuration
              }, builder =>
              {
                  builder
                      .AddRetryPolicy(2)
                      .AddTimeoutPolicy(TimeSpan.FromSeconds(5))
                      .AddCircuitBreakerPolicy(10, TimeSpan.FromSeconds(30));
                      // add whatever middleware you prefer
                  }
              );
          });
    }
}
```
<a id="questions"></a>
## Questions

- What about HttpRequest failures and retries?
  Configure Polly in the IHttpClientBuilder
- How are tokens used?
  Tokens are provided by a TokenProvider class. The default is RateLimitProvider which will perform client side rate limiting.
  Other providers can be used with the UseProvider method.
- Does an HttpRequest throw an error when the server response is not Ok?
  It depends how you made the request. If the return type is ApiResponse<T> no error will be thrown, though the Content property will be null.
  StatusCode and ReasonPhrase will contain information about the error.
  If the return type is T, then it will throw. If the return type is TOrDefault, it will return null.
- How do I validate requests and process responses?
  Use the provided On and After partial methods in the api classes.

## Api Information
- appName: Shipping APIs
- appVersion: 1.0.0
- appDescription: ### Introduction  The Shipping APIs include a variety of operations that allow users to manage and track their shipping requests.   Some of the key API operations available in the Shipping API includes: ### Shipment API  | Operation      | Description | | - -- -- -- -- -- | - -- -- -- -- -- |  | Get Carriers    | The operation fetches all onboarded carriers. Typically, user will use this service to get list of onboarded carriers and supported properties for those carriers. |  | Get Countries | The operation fetches list of supported destination countries for a provided carrier and origin country. |  | Get Services | The operation fetches a list of supported services for a carrier with respect to specific origin and destination country. |  | Get ParcelTypes| The operation fetches ParcelTypes based on carrier, origin, and destination country. |  | Get Special Services| The operation fetches Special Services for a given carrier, service, origin, and destination country. |  | Get Carrier Accounts| The operation retrieves onboarded Carriers with their Carrier Account Ids which uniquely identify multiple accounts of same carrier. |  | Rate Shop and Get Single Rate| This API contains 2 operations, rate shop and single rate. Rate shop will fetch rates for all carrier services based on the given addresses (From and To), weight, and dimension for given parcelType. Single rate will get rate for specific service and special service (if requested) based on the given addresses (From and To), weight, and dimension, parcelType and serviceId with or without specialServices. Single rate will be used to rate a shipment before creating it. |  | Create Shipment| The operation creates a new Shipment or Shipment Label. This is for both Domestic and International. | | Get All Shipments| The operation fetches all created Shipments. |  | Get Shipment by Id| Retrieves single shipment using Shipment Id. |  | Reprint Shipment| The operation reprints Shipment by the shipmentId. It retrieves an existing shipping label to reprint. The API sends the shipmentId returned by the original Created Shipment request. Use this only if the shipping label in the ‘Create Shipment’ response is missing or lost. |  | Cancel Shipment| The operation cancels previously created shipment. |  

## Build
This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project.

- SDK version: 1.0.0
- Generator version: 7.14.0
- Build package: org.openapitools.codegen.languages.CSharpClientCodegen
