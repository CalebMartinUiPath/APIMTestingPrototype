using RestSharp;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace GenerateTestCasesPrototype2
{
    public class TestCase
    {
        public string EndPoint { get; set; }

        public Method Method { get; set; }

        public string Body { get; set; }

        public HttpStatusCode ExpectedStatusCode { get; set; }

        public TestCase(string endPoint, Method method, string body, HttpStatusCode expectedStatusCode)
        {
            EndPoint = endPoint;
            Method = method;
            Body = body;
            ExpectedStatusCode = expectedStatusCode;
        }
    }
}
