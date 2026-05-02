using TaskFlowApi.Entities;

namespace TaskFlowApi.Features.Tasks
{
    public static class TaskEndpoint
    {
        public static void MapTaskEndpoints(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("/tasks");

            group.MapGet("/", async (TaskService service) =>
            {
                var tasks = await service.GetTasksAsync();
                return Results.Ok(tasks);
            });

            group.MapGet("/user/{userId}", async (Guid userId, TaskService service) =>
            {
                var tasks = await service.GetByUserIdAsync(userId);
                return Results.Ok(tasks);
            });

            group.MapPost("/", async (TaskItem task, TaskService service) =>
            {
                task.Id = Guid.NewGuid();
                await service.CreateTaskAsync(task);
                return Results.Created($"/tasks/{task.Id}", task);
            });
        }
    }
}
