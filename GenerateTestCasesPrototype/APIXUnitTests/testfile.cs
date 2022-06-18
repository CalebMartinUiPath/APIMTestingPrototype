
using FluentAssertions;
using RestSharp;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace APIXUnitTests
{
    public class testfile
    {
            [Fact]
            public async Task Test0()
            {
                RestClient client = new RestClient("https://calebtestingapim.azure-api.net/apimtesting");
                RestRequest request = new RestRequest("/portal_/home", Method.Get);

                CancellationToken cancellationToken = new CancellationToken();
                var response = await client.GetAsync(request, cancellationToken);

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
            
            [Fact]
            public async Task Test1()
            {
                RestClient client = new RestClient("https://calebtestingapim.azure-api.net/apimtesting");
                RestRequest request = new RestRequest("/calebmartinsorg/DefaultTenant/orchestrator_", Method.Get);

                CancellationToken cancellationToken = new CancellationToken();
                var response = await client.GetAsync(request, cancellationToken);

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
            
            [Fact]
            public async Task Test2()
            {
                RestClient client = new RestClient("https://calebtestingapim.azure-api.net/apimtesting");
                RestRequest request = new RestRequest("/calebmartinsorg/studio_", Method.Get);

                CancellationToken cancellationToken = new CancellationToken();
                var response = await client.GetAsync(request, cancellationToken);

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
            
            [Fact]
            public async Task Test3()
            {
                RestClient client = new RestClient("https://calebtestingapim.azure-api.net/apimtesting");
                RestRequest request = new RestRequest("/calebmartinsorg/apps_", Method.Get);

                CancellationToken cancellationToken = new CancellationToken();
                var response = await client.GetAsync(request, cancellationToken);

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
            
            [Fact]
            public async Task Test4()
            {
                RestClient client = new RestClient("https://calebtestingapim.azure-api.net/apimtesting");
                RestRequest request = new RestRequest("/calebmartinsorg/DefaultTenant/actions_", Method.Get);

                CancellationToken cancellationToken = new CancellationToken();
                var response = await client.GetAsync(request, cancellationToken);

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
            
            [Fact]
            public async Task Test5()
            {
                RestClient client = new RestClient("https://calebtestingapim.azure-api.net/apimtesting");
                RestRequest request = new RestRequest("/calebmartinsorg/DefaultTenant/processes_", Method.Get);

                CancellationToken cancellationToken = new CancellationToken();
                var response = await client.GetAsync(request, cancellationToken);

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
            
            [Fact]
            public async Task Test6()
            {
                RestClient client = new RestClient("https://calebtestingapim.azure-api.net/apimtesting");
                RestRequest request = new RestRequest("/calebmartinsorg/DefaultTenant/du", Method.Get);

                CancellationToken cancellationToken = new CancellationToken();
                var response = await client.GetAsync(request, cancellationToken);

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
            
            [Fact]
            public async Task Test7()
            {
                RestClient client = new RestClient("https://calebtestingapim.azure-api.net/apimtesting");
                RestRequest request = new RestRequest("/calebmartinsorg/portal_/api/filtering/leftnav/tenantsAndOrganizationInfo", Method.Get);

                CancellationToken cancellationToken = new CancellationToken();
                var response = await client.GetAsync(request, cancellationToken);

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
            
            [Fact]
            public async Task Test8()
            {
                RestClient client = new RestClient("https://calebtestingapim.azure-api.net/apimtesting");
                RestRequest request = new RestRequest("/calebmartinsorg/DefaultTenant/orchestrator_/odata/Folders", Method.Get);

                CancellationToken cancellationToken = new CancellationToken();
                var response = await client.GetAsync(request, cancellationToken);

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
            
            [Fact]
            public async Task Test9()
            {
                RestClient client = new RestClient("https://calebtestingapim.azure-api.net/apimtesting");
                RestRequest request = new RestRequest("/caleartinsorg/DefaultTenant/orcchestrator", Method.Get);

                CancellationToken cancellationToken = new CancellationToken();
                var response = await client.GetAsync(request, cancellationToken);

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
            }
}