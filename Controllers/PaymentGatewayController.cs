using RestSharp;

namespace Rest.Controllers
{
    public abstract class PaymentGatewayController : BaseController
    {
        private static ILogger<PaymentGatewayController> logger = loggerFactory.CreateLogger<PaymentGatewayController>();

        protected static readonly RestClient restClient = new("https://api.sumup.com/");

    }
}