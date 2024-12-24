using Microsoft.AspNetCore.Mvc;

namespace MyPetMarket.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CreditCardController(CreditCard.CreditCardService.CreditCardServiceClient client) : ControllerBase
    {
        private readonly CreditCard.CreditCardService.CreditCardServiceClient _client = client;

        [HttpPost]
        public CreditCard.CreditCardResponse CreateCreditCard(CreditCard.CreateCreditCardRequest request)
        {
            return _client.CreateCreditCard(request);
        }
    }
}
