using FluentAssertions;
using GenerateTestCasesPrototype2;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace ApiXUnitTests
{
    public class UnitTest1
    {
        public static IEnumerable<object[]> Data
        {
            get
            {
                TestSuite testSuite = new TestSuite("C:/Users/caleb.martin/source/repos/GenerateTestCasesPrototype/GenerateTestCasesPrototype/APIMTesting.openapijson.json");
                List<object[]> list = new List<object[]>();
                var url = testSuite.Url;
                foreach (object testCase in testSuite.TestCases)
                {
                    Object[] singleTestData = new Object[2];
                    singleTestData[0] = url;
                    singleTestData[1] = testCase;
                    list.Add(singleTestData);
                }

                return list;
            }
        }

        [Theory]
        [MemberData(nameof(Data))]
        public async Task GetTests(string url, TestCase testCase)
        {
            RestClient client = new RestClient(url);
            RestRequest request = new RestRequest(testCase.EndPoint, testCase.Method);

            CancellationToken cancellationToken = new CancellationToken();
            var response = await client.GetAsync(request, cancellationToken);

            response.StatusCode.Should().Be(testCase.ExpectedStatusCode);
        }
    }
}
