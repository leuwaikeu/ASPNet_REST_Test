using RestSharp;

namespace Rest.Controllers
{
    public abstract class FirebaseController : BaseController
    {
        private static ILogger<FirebaseController> logger = loggerFactory.CreateLogger<FirebaseController>();

        protected static readonly RestClient restClient = new("https://test-backend-6cf33-default-rtdb.firebaseio.com/");

    }
}