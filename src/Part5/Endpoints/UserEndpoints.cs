using Carter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Part5.Abstractions.Services;
using Part5.Dtos.User;

namespace Part5.Endpoints;

public class UserEndpoints : CarterModule
{
    public UserEndpoints() : base("api/users")
    {
    }
    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapGet("test",  () =>
        {
            return Results.Ok("Test success");
        }).WithOpenApi(x => new OpenApiOperation(x)
        {
            Tags = new List<OpenApiTag> { new() { Name = "User api" } }
        });

        app.MapPost(string.Empty, async (IUserService service, [FromBody] CreateUserRequest request) =>
        {
            await service.CreateNewUser(request);

            return Results.Ok("Create success");
        }).WithOpenApi(x => new OpenApiOperation(x)
        {
            Tags = new List<OpenApiTag> { new() { Name = "User api" } }
        });

        app.MapGet(string.Empty, async (IUserService service) =>
        {
            var result = await service.GetAllUsers();

            if(result is null || result.Count == 0)
            {
                return Results.NotFound("User not found");
            }

            return Results.Ok(result);
        }).WithOpenApi(x => new OpenApiOperation(x)
        {
            Tags = new List<OpenApiTag> { new() { Name = "User api" } }
        });

        app.MapGet("{id}", async (IUserService service, [FromRoute] int id) =>
        {
            var result = await service.GetUserById(id);

            if (result is null)
            {
                return Results.NotFound("User not found");
            }

            return Results.Ok(result);
        }).WithOpenApi(x => new OpenApiOperation(x)
        {
            Tags = new List<OpenApiTag> { new() { Name = "User api" } }
        });
    }
}
