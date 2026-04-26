using Microsoft.EntityFrameworkCore;
using TaskFlowApi.Data;
using TaskFlowApi.Entities;

namespace TaskFlowApi.Features.Users
{
    public static class UserEndpoints
    {
        public static void MapUserEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/", () => "Tasks Running");

            //app.MapGet("/users", async (AppDbContext db) =>
            //{
            //    var users = await db.users.ToListAsync();
            //    return Results.Ok(users);
            //})
            //    .WithName("GetUsers")
            //    .WithSummary("Returns All Users");

            app.MapGet("/users", async (UserService service) =>
            {
                var users = await service.GetUsersAsync();
                return Results.Ok(users);
            });

            app.MapPost("/users", async (UserService service, User user) =>
            {
                user.Id = Guid.NewGuid();
                await service.CreateUsersAsync(user);

                return Results.Created($"/users/{user.Id}", user);
            });
                
        }
    }
}
