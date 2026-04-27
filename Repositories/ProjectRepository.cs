using Microsoft.EntityFrameworkCore;
using TaskFlowApi.Data;
using TaskFlowApi.Entities;
using TaskFlowApi.Interfaces;

namespace TaskFlowApi.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private readonly AppDbContext _context;
        public ProjectRepository(AppDbContext context) { _context = context; }
        public async Task<List<Projects>> GetProjects()
        {
            return await _context.projects.ToListAsync();
        }
    }
}
