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

        private static ILogger<ControllerBase> logger = loggerFactory.CreateLogger<ControllerBase>();

        protected static readonly RestClient client = new("https://test-backend-6cf33-default-rtdb.firebaseio.com/");

        protected IActionResult Get<T>(string resource)
        {
            try
            {
                RestRequest restRequest = new(resource);
                RestResponse restResponse = client.Get(restRequest);
                T json = JsonSerializer.Deserialize<T>(restResponse.Content);

                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return Ok(json);
                }
                return StatusCode(int.Parse(restResponse.StatusCode.ToString()), json);
            }
            catch (Exception e)
            {
                logger.LogError($"\tGetType: {e.GetType()}");
                logger.LogError($"\tMessage: {e.Message}");
                throw;
            }
        }

        protected IActionResult Put<T>(string resource, T obj)
        {
            try
            {
                var restRequest = new RestRequest(resource);
                restRequest.AddJsonBody(JsonSerializer.Serialize(obj));
                RestResponse restResponse = client.Put(restRequest);
                T json = JsonSerializer.Deserialize<T>(restResponse.Content);
                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return Ok(json);
                }
                return StatusCode(int.Parse(restResponse.StatusCode.ToString()), json);
            }
            catch (Exception e)
            {
                logger.LogError($"\tGetType: {e.GetType()}");
                logger.LogError($"\tMessage: {e.Message}");
                throw;
            }
        }

        protected IActionResult Post<T>(string resource, T obj)
        {
            try
            {
                var restRequest = new RestRequest(resource);
                restRequest.AddJsonBody(JsonSerializer.Serialize(obj));
                RestResponse restResponse = client.Post(restRequest);
                T json = JsonSerializer.Deserialize<T>(restResponse.Content);
                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return Ok(json);
                }
                return StatusCode(int.Parse(restResponse.StatusCode.ToString()), json);
            }
            catch (Exception e)
            {
                logger.LogError($"\tGetType: {e.GetType()}");
                logger.LogError($"\tMessage: {e.Message}");
                throw;
            }
        }

        protected IActionResult Delete<T>(string resource, T obj)
        {
            try
            {
                var restRequest = new RestRequest(resource);
                restRequest.AddJsonBody(JsonSerializer.Serialize(obj));
                RestResponse restResponse = client.Delete(restRequest);
                T json = JsonSerializer.Deserialize<T>(restResponse.Content);
                if (restResponse.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return Ok(json);
                }
                return StatusCode(int.Parse(restResponse.StatusCode.ToString()), json);
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