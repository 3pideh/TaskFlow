namespace TaskFlowApi.Interfaces
{
    public interface IProjectRepository
    {
        Task<List<Entities.Projects>> GetProjects();
    }
}
