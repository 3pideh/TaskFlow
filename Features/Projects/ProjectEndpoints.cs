using TaskFlowApi.Data;

namespace TaskFlowApi.Features.Projects
{
    public static class ProjectEndpoints
    {
        public static void MapProjectEndpoints(this IEndpointRouteBuilder app)
        {
            app.MapGet("/projects", async (ProjectService service) =>
             {
                 var projects = await service.GetProjects();
                 return Results.Ok(projects);
             }
            );
        }
    }
}
