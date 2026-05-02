using System.ComponentModel.DataAnnotations;
using System.Net;

namespace WebApplication2.Models
{
    public class ResponseDataModel<T> where T : class
    {
        public HttpStatusCode Statuscode { get; set; }
        public T? Responsedata { get; set; }
    }
}