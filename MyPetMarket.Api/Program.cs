using Microsoft.AspNetCore.Server.Kestrel.Core;
using Prototype.Payment.Sdk.Grpc.Extensions;
using Prototype.Payment.Sdk.Rest.Configurations;
using Prototype.Payment.Sdk.Rest.Extensions;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.ConfigureKestrel(options =>
{
    options.ListenAnyIP(5128, o => o.Protocols = HttpProtocols.Http1);
    options.ListenAnyIP(5423, o => o.Protocols = HttpProtocols.Http2);
});

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddGrpcClient("https://localhost:5136");
builder.Services.AddRestClient(new PaymentApiSettings { ApiEndpoint = "https://localhost:5136" });

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
