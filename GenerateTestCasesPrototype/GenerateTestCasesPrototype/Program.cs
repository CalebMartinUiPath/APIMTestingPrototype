using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Text.Json;

namespace GenerateTestCasesPrototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string text =
                File.ReadAllText(
                    "C:/Users/caleb.martin/source/repos/GenerateTestCasesPrototype/GenerateTestCasesPrototype/APIMTesting.openapijson.json");

            var api = JsonDocument.Parse(text);

            JToken data = JObject.Parse(text);

            Console.WriteLine(data.SelectToken("openapi"));


            string filepath = "C:/Users/caleb.martin/source/repos/GenerateTestCasesPrototype/APIXUnitTests/testfile.cs";

            File.WriteAllText(filepath, @"
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
    {");
            var root = (string)data["servers"][0]["url"];
            var pathdata = (JObject)data["paths"];
            int i = 0;
            foreach (var item in pathdata)
            {
                Console.WriteLine("{0}", item.Key);

                

                string extpath = item.Key;




                string test1 = (@"
            [Fact]
            public async Task Test"+i+@"()
            {
                RestClient client = new RestClient(""" + root + @""");
                RestRequest request = new RestRequest(""" + extpath + @""", Method.Get);

                CancellationToken cancellationToken = new CancellationToken();
                var response = await client.GetAsync(request, cancellationToken);

                response.StatusCode.Should().Be(HttpStatusCode.OK);
            }
            ");

                i++;
                File.AppendAllText(filepath, test1);
            }

            File.AppendAllText(filepath,
    @"}
}"
            );

            Console.ReadLine();
        }
    }
}
