using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Text.Json;

namespace Rest.Controllers
{
    [Route("api/[controller]")]
    public class DeviceController : FirebaseController
    {
        private const string resource = "DeviceInfo";

        [HttpGet]
        public IActionResult Get(string Id)
        {
            RestRequest restRequest = new(GetResourceIdString(resource, Id), Method.Get);
            return ExecuteRequest<Models.DeviceInfo>(restClient, restRequest);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Models.DeviceInfo obj)
        {
            RestRequest restRequest = new(GetResourceIdString(resource, obj.Id), Method.Put);
            restRequest.AddJsonBody(JsonSerializer.Serialize(obj));
            return ExecuteRequest<Models.DeviceInfo>(restClient, restRequest);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody] Models.DeviceInfo obj)
        {
            RestRequest restRequest = new(GetResourceIdString(resource, obj.Id), Method.Delete);
            restRequest.AddJsonBody(JsonSerializer.Serialize(obj));
            return ExecuteRequest<Models.DeviceInfo>(restClient, restRequest);
        }
    }
}
