using Microsoft.AspNetCore.Mvc;
using RestSharp;

namespace Rest.Controllers
{
    [Route("api/[controller]")]
    public class OrganisationInfoController : BaseController
    {
        private readonly string resource = "OrganisationInfo.json";

        [HttpGet]
        public IActionResult Get()
        {
            return Get<Models.OrganisationInfo>(resource);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Models.OrganisationInfo objOrganisationInfo)
        {
            return Put(resource, objOrganisationInfo);
        }
    }
}
