using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.OpenAq.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class OpenAqOpenApiClientTests : FixturedUnitTest
{
    public OpenAqOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
