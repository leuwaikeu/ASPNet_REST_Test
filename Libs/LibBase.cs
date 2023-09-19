using RestSharp;
using System.Text.Json;

namespace Rest.Libs
{
    public abstract class LibBase
    {
        protected static readonly ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder
            .AddConsole()
            .AddDebug()
            .SetMinimumLevel(LogLevel.Debug)
        );

        private static ILogger<LibBase> logger = loggerFactory.CreateLogger<LibBase>();

        protected static readonly RestClient client = new("https://test-backend-6cf33-default-rtdb.firebaseio.com/");

        public static RestResponse Get(string resource)
        {
            try
            {
                RestRequest restRequest = new(resource);
                RestResponse restResponse = client.Get(restRequest);
                return restResponse;
            }
            catch (Exception e)
            {
                logger.LogError($"\tGetType: {e.GetType()}");
                logger.LogError($"\tMessage: {e.Message}");
                throw;
            }
        }

        public static RestResponse Put<T>(string resource, T obj)
        {
            try
            {
                var restRequest = new RestRequest(resource);
                restRequest.AddJsonBody(JsonSerializer.Serialize(obj));
                RestResponse restResponse = client.ExecutePut(restRequest);
                return restResponse;
            }
            catch (Exception e)
            {
                logger.LogError($"\tGetType: {e.GetType()}");
                logger.LogError($"\tMessage: {e.Message}");
                throw;
            }
        }
    }
}