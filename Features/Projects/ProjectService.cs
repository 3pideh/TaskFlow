using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using TaskFlowApi.Data;

namespace TaskFlowApi.Features.Projects
{
    public class ProjectService
    {
        private readonly AppDbContext _appDbContext;

        public ProjectService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<Entities.Projects>> GetProjects()
        {
            return await _appDbContext.projects.ToListAsync();
        }
    }
}
