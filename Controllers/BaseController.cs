using Microsoft.AspNetCore.Mvc;
using RestSharp;
using System.Text.Json;

namespace Rest.Controllers
{
    public abstract class BaseController : Controller
    {
        protected static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder
            .AddConsole()
            .AddDebug()
            .SetMinimumLevel(LogLevel.Debug)
        );

        private static ILogger<BaseController> logger = loggerFactory.CreateLogger<BaseController>();

        protected IActionResult ExecuteRequest<T>(RestClient restClient, RestRequest restRequest)
        {
            try
            {
                RestResponse restResponse = restClient.Execute(restRequest);

                switch (restResponse.StatusCode)
                {
                    case System.Net.HttpStatusCode.OK:
                        T responseContent = JsonSerializer.Deserialize<T>(restResponse.Content);
                        return Ok(responseContent);

                    case System.Net.HttpStatusCode.NotFound:
                        return NotFound();

                    default:
                        return BadRequest();
                }
            }
            catch (Exception e)
            {
                logger.LogError($"\tGetType: {e.GetType()}");
                logger.LogError($"\tMessage: {e.Message}");
                throw;
            }
        }

        protected string GetResourceIdString(string resource, string id)
        {
            return $"{resource}/{id}.json";
        }
    }
}