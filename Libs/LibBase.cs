using RestSharp;
using System.Text.Json;

namespace Rest.Libs
{
    public abstract class LibBase
    {
        protected static ILoggerFactory loggerFactory = LoggerFactory.Create(builder => builder
            .AddConsole()
            .AddDebug()
            .SetMinimumLevel(LogLevel.Debug)
        );

        protected static RestClient client = new RestClient("https://test-backend-6cf33-default-rtdb.firebaseio.com/");

        public static T Get<T>(string resource)
        {
            var restRequest = new RestRequest(resource); ;
            var restResponse = client.Get(restRequest);
            T data = JsonSerializer.Deserialize<T>(restResponse.Content);
            return data;
        }
    }
}