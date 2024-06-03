using Carter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Part5.Abstractions.Services;

namespace Part5.Endpoints;

public class UserClassEndpoints : CarterModule
{
    public UserClassEndpoints() : base("api/userclasses")
    {
    }
    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost("{userId}/{classId}", async (IUserClassService service, [FromRoute] int userId, [FromRoute] int classId) =>
        {
            await service.CreateNewUserClass(userId, classId);

            return Results.Ok("Create ok");
        }).WithOpenApi(x => new OpenApiOperation(x)
        {
            Tags = new List<OpenApiTag> { new() { Name = "User class api" } }
        });

        app.MapGet("{classId}", async (IUserClassService service, [FromRoute] int classId) =>
        {
            var result = await service.GetUsersByClassId(classId);

            if(result == null || result.Count == 0)
            {
                return Results.NotFound($"Not found user in class {classId}");
            }

            return Results.Ok(result);
        }).WithOpenApi(x => new OpenApiOperation(x)
        {
            Tags = new List<OpenApiTag> { new() { Name = "User class api" } }
        });
    }
}
