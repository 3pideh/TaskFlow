using Microsoft.EntityFrameworkCore;
using TaskFlowApi.Data;
using TaskFlowApi.Entities;

namespace TaskFlowApi.Repositories
{
    public class TaskRepository
    {
        private readonly AppDbContext _appDbContext;

        public TaskRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public async Task<List<TaskItem>> GetAllAsync()
          => await _appDbContext.Tasks.Include(x => x.User).ToListAsync();


        public async Task<List<TaskItem>> GetByUserIdAsync(Guid userId) =>
        await _appDbContext.Tasks.Where(t => t.UserId == userId).ToListAsync();

        public async Task AddAsync(TaskItem task)
        {
            await _appDbContext.Tasks.AddAsync(task);
            await _appDbContext.SaveChangesAsync();
        }

    }
}
