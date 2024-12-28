using Microsoft.AspNetCore.Mvc;
using Prototype.Payment.Sdk.Grpc;
using static Prototype.Payment.Sdk.Grpc.CreditCardGrpcService;

namespace MyPetMarket.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CreditCardsGrpcController(CreditCardGrpcServiceClient client) : ControllerBase
{
    private readonly CreditCardGrpcServiceClient _client = client;

    [HttpPost]
    public CreatedCreditCardResponse CreateCreditCard(CreateCreditCardRequest request)
    {
        var creditCard = _client.CreateCreditCard(request);

        return creditCard;
    }
}
