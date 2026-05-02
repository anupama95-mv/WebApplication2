using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Net;
using WebApplication2.Models;

namespace WebApplication2
{
    public class RestClientHelper : Controller
    {
        public RestClientOptions CreateRestClientOptions(string apiurl)
        {
            string baseurl = "https://localhost:7236/";
            Uri uriobj = new(new Uri(baseurl), apiurl);
            return new RestClientOptions(uriobj)
            {
                ThrowOnAnyError = true,
                Timeout = TimeSpan.FromSeconds(10)
            };
        }
        public RestRequest CreateRestRequest(object? requestBody)
        {
            var request = new RestRequest();
            if (requestBody != null)
            {
                request.AddJsonBody(requestBody);
            }
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Accept", "application/json");
            return request;
        }
        public static ResponseDataModel<string> CreateErrorResponse(Exception ex)
        {
            return new ResponseDataModel<string>()
            {
                Statuscode = ex is HttpRequestException httpEx && httpEx.StatusCode == HttpStatusCode.Unauthorized ? HttpStatusCode.Unauthorized : HttpStatusCode.InternalServerError,
                Responsedata = null,
            };
        }
    }
}
