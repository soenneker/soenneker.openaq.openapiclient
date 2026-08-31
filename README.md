[![](https://img.shields.io/nuget/v/soenneker.openaq.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.openaq.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.openaq.openapiclient/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.openaq.openapiclient/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.openaq.openapiclient.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.openaq.openapiclient/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.openaq.openapiclient/codeql.yml?style=for-the-badge&label=codeql)](https://github.com/soenneker/soenneker.openaq.openapiclient/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.OpenAq.OpenApiClient

Typed request builders and models for querying OpenAQ air-quality data from .NET.

## Installation

```bash
dotnet add package Soenneker.OpenAq.OpenApiClient
```

## Usage

```csharp
using Microsoft.Kiota.Abstractions.Authentication;
using Microsoft.Kiota.Http.HttpClientLibrary;
using Soenneker.OpenAq.OpenApiClient;

var httpClient = new HttpClient();
httpClient.DefaultRequestHeaders.Add("X-API-Key", apiKey);

var adapter = new HttpClientRequestAdapter(
    new AnonymousAuthenticationProvider(),
    httpClient: httpClient);

var client = new OpenAqOpenApiClient(adapter);
var locations = await client.V3.Locations.GetAsync(request =>
{
    request.QueryParameters.Iso = "US";
    request.QueryParameters.Limit = 10;
}, cancellationToken);
```

The client defaults to `https://api.openaq.org`. It exposes locations, measurements, sensors, countries, parameters, providers, and other OpenAQ v3 resources through Kiota request builders.

For configuration-based credentials and managed client reuse, use [`Soenneker.OpenAq.OpenApiClientUtil`](https://github.com/soenneker/soenneker.openaq.openapiclientutil).
