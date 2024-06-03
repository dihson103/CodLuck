using Carter;
using Microsoft.AspNetCore.Mvc;
using Microsoft.OpenApi.Models;
using Part5.Abstractions.Services;
using Part5.Dtos.Class;

namespace Part5.Endpoints;

public class ClassEndpoints : CarterModule
{
    public ClassEndpoints() : base("api/classes")
    {
        
    }
    public override void AddRoutes(IEndpointRouteBuilder app)
    {
        app.MapPost(string.Empty, async (IClassService service, [FromBody] CreateClassRequest request) =>
        {
            await service.CreateNewClass(request);

            return Results.Ok("Create class success");
        }).WithOpenApi(x => new OpenApiOperation(x)
        {
            Tags = new List<OpenApiTag> { new() { Name = "Class api" } }
        });

        app.MapGet(string.Empty, async (IClassService service) =>
        {
            var result = await service.GetAllClass();

            if(result is null || result.Count == 0)
            {
                return Results.NotFound("Class not found");
            }

            return Results.Ok(result);
        }).WithOpenApi(x => new OpenApiOperation(x)
        {
            Tags = new List<OpenApiTag> { new() { Name = "Class api" } }
        });
    }
}
