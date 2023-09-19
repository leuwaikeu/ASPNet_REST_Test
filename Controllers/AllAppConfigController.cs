using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace Rest.Controllers
{
    [Route("api/[controller]")]
    public class AllAppConfigController : BaseController
    {
        private readonly string resource = "AppConfigs.json";

        [HttpGet]
        public IActionResult Get()
        {
            return Get<Dictionary<string, Models.AppConfig>>(resource);
        }
    }
}
