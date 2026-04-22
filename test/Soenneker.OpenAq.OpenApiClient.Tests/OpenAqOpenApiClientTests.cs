using Soenneker.Tests.HostedUnit;

namespace Soenneker.OpenAq.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class OpenAqOpenApiClientTests : HostedUnitTest
{
    public OpenAqOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
