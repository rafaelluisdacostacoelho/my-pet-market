using Microsoft.AspNetCore.Mvc;
using Prototype.Payment.Sdk.Rest;
using Prototype.Payment.Sdk.Rest.Serializations.Requests;
using Prototype.Payment.Sdk.Rest.Serializations.Responses;

namespace MyPetMarket.Controllers;

//[ApiController]
//[Route("api/[controller]")]
//public class CreditCardsRestController(ICreditCard creditCard) : ControllerBase
//{
//    private readonly ICreditCard _creditCard = creditCard;

//    [HttpPost]
//    public async Task<CreditCardResponse> CreateCreditCardAsync(CreateCreditCardRequest request)
//    {
//        return await _creditCard.CreateCreditCard(request);
//    }
//}
