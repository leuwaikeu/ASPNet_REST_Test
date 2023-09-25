using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Text.Json;

namespace Rest.Controllers
{
    [Route("api/[controller]")]
    public class TransactionController : PaymentGatewayController
    {
        private const string resource = "OrganisationInfo.json";

        [HttpPut]
        public IActionResult Put([FromBody] Models.OrganisationInfo obj)
        {
            RestRequest restRequest = new(resource, Method.Put);
            restRequest.AddJsonBody(JsonSerializer.Serialize(obj));
            return ExecuteRequest<Models.OrganisationInfo>(restClient, restRequest);
        }
    }
}