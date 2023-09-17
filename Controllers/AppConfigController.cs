using Microsoft.AspNetCore.Mvc;

namespace Rest.Controllers
{
    [Route("api/[controller]")]
    public class AppConfigsController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            var objAppConfigs = Libs.LibBase.Get<Models.AppConfigs>("AppConfigs.json");
            return Ok(objAppConfigs);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Models.AppConfigs objAppConfigs)
        {
            if (ModelState.IsValid)
            {
                return Ok(objAppConfigs);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
