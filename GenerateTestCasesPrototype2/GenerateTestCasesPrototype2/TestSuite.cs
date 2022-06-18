using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.Json;
using RestSharp;

namespace GenerateTestCasesPrototype2
{
    public class TestSuite
    {

        public string Url { get; set; }

        public List<TestCase> TestCases { get; set; }

        public TestSuite(string url)
        {
            Url = url;

            TestCases = new List<TestCase>();

            string text =
                File.ReadAllText(
                    "C:/Users/caleb.martin/source/repos/GenerateTestCasesPrototype/GenerateTestCasesPrototype/APIMTesting.openapijson.json");

            var api = JsonDocument.Parse(text);

            JToken data = JObject.Parse(text);

            Url = (string)data["servers"][0]["url"];
            var pathdata = (JObject)data["paths"];
            int i = 0;
            foreach (var item in pathdata)
            {
                TestCases.Add(new TestCase(item.Key, Method.Get, "", HttpStatusCode.OK));
            }
        }
    }
}