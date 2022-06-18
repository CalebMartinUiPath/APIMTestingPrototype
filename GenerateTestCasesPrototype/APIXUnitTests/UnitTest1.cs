using FluentAssertions;
using RestSharp;
using System;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace APIXUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public async Task OrchestratorTest()
        {
            RestClient client = new RestClient("http://cloud.uipath.com");
            RestRequest request = new RestRequest("/calebmartinsorg/DefaultTenant/orchestrator_", Method.Get);

            CancellationToken cancellationToken = new CancellationToken();
            var response = await client.GetAsync(request, cancellationToken);

            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}
