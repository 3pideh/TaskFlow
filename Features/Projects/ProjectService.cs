using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using TaskFlowApi.Data;
using TaskFlowApi.Repositories;

namespace TaskFlowApi.Features.Projects
{
    public class ProjectService
    {
        private readonly ProjectRepository _projectRepository;

        public ProjectService(ProjectRepository projectRepository)
        {
           _projectRepository = projectRepository;
        }

        public async Task<List<Entities.Projects>> GetProjects()
        {
            return await _projectRepository.GetProjects();
        }
    }
}
