using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Text.Json;

namespace Rest.Controllers
{
    [Route("api/[controller]")]
    public class OrganisationController : FirebaseController
    {
        private const string resource = "OrganisationInfo.json";

        [HttpGet]
        public IActionResult Get()
        {
            RestRequest restRequest = new(resource, Method.Get);
            return ExecuteRequest<Models.OrganisationInfo>(restClient, restRequest);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Models.OrganisationInfo obj)
        {
            RestRequest restRequest = new(resource, Method.Put);
            restRequest.AddJsonBody(JsonSerializer.Serialize(obj));
            return ExecuteRequest<Models.OrganisationInfo>(restClient, restRequest);
        }
    }
}
