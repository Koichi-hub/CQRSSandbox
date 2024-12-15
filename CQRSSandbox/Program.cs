using CQRSSandbox.Features.UserFeature.Commands;
using CQRSSandbox.Features.UserFeature.Queries;
using CQRSSandbox.Features.UserFeature.Repositories;
using MediatR;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton<UserRepository>();

builder.Services.AddMediatR(cfg => {
    cfg.RegisterServicesFromAssembly(typeof(Program).Assembly);
});

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.MapPost("/users/register", ([FromServices] IMediator mediator, [FromBody] RegisterCommand command) =>
{
    return mediator.Send(command);
})
.WithOpenApi();

app.MapGet("/users/{userUid}", ([FromServices] IMediator mediator, [FromRoute] Guid userUid) =>
{
    return mediator.Send(new GetUserQuery
    {
        UserUid = userUid
    });
})
.WithOpenApi();

app.Run();
