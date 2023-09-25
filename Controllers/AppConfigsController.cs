using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Text.Json;

namespace Rest.Controllers
{
    [Route("api/[controller]")]
    public class AppConfigsController : FirebaseController
    {
        private readonly string resource = "AppConfigs.json";

        [HttpGet]
        public IActionResult Get()
        {
            RestRequest restRequest = new(resource, Method.Get);
            return ExecuteRequest<Dictionary<string, Models.AppConfig>>(restClient, restRequest);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Dictionary<string, Models.AppConfig> objs)
        {
            RestRequest restRequest = new(resource, Method.Put);
            restRequest.AddJsonBody(JsonSerializer.Serialize(objs));
            return ExecuteRequest<Dictionary<string, Models.AppConfig>>(restClient, restRequest);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Dictionary<string, Models.AppConfig> objs)
        {
            RestRequest restRequest = new(resource, Method.Delete);
            restRequest.AddJsonBody(JsonSerializer.Serialize(objs));
            return ExecuteRequest<Dictionary<string, Models.AppConfig>>(restClient, restRequest);
        }
    }
}
