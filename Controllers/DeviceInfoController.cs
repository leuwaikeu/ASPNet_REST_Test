using Microsoft.AspNetCore.Mvc;

namespace Rest.Controllers
{
    [Route("api/[controller]")]
    public class DeviceInfoController : BaseController
    {
        private readonly string resource = "DeviceInfo";

        [HttpGet]
        public IActionResult Get(string Id)
        {
            return Get<Models.DeviceInfo>(GetResourceIdString(resource, Id));
        }
    }
}
