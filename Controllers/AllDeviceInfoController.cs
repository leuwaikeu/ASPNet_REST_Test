using Microsoft.AspNetCore.Mvc;

namespace Rest.Controllers
{
    [Route("api/[controller]")]
    public class AllDeviceInfoController : BaseController
    {
        private readonly string resource = "DeviceInfo.json";

        [HttpGet]
        public IActionResult Get()
        {
            return Get<Dictionary<string, Models.DeviceInfo>>(resource);
        }
    }
}
