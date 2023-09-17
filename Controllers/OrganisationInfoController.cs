using Microsoft.AspNetCore.Mvc;

namespace Rest.Controllers
{
    [Route("api/[controller]")]
    public class OrganisationInfoController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var objOrganisationInfo = Libs.LibBase.Get<Models.OrganisationInfo>("OrganisationInfo.json");
            return Ok(objOrganisationInfo);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Models.AppConfigs objOrganisationInfo)
        {
            if (ModelState.IsValid)
            {
                return Ok(objOrganisationInfo);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
