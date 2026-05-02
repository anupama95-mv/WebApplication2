using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using RestSharp;
using WebApplication2.Models;


namespace WebApplication2.Controllers
{
    public class TestingController : Controller
    {
        private readonly RestClientHelper _restClientHelper;
        public TestingController(ILogger<TestingController> logger, RestClientHelper restClientHelper)
        {
            _restClientHelper = restClientHelper;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<JsonResult> GetProductPageFourData([FromBody] GetProductPageFourDataIP obj)
        {
            try
            
            {
                var options = _restClientHelper.CreateRestClientOptions("api/Product/GetProducts");
                var client = new RestClient(options);
                var request = _restClientHelper.CreateRestRequest(obj);
                var response = await client.PostAsync<ResponseDataModel<IEnumerable<GetProductPageFourDataOP>>>(request);
                return Json(response);
            }
            catch (Exception ex)
            {
                var response = RestClientHelper.CreateErrorResponse(ex);
                return Json(response);
            }
        }
        [HttpPost]
        public async Task<JsonResult> SaveProductPageFourData([FromBody] SaveProductPageFourDataIP obj)
        {
            try
            {
                var options = _restClientHelper.CreateRestClientOptions("api/Product/SaveProduct");
                var client = new RestClient(options);
                var request = _restClientHelper.CreateRestRequest(obj);
                var response = await client.PostAsync<ResponseDataModel<GetProductPageFourDataOP>>(request);
                return Json(response);
            }
            catch (Exception ex)
            {
                var response = RestClientHelper.CreateErrorResponse(ex);
                return Json(response);
            }
        }
    }
}
