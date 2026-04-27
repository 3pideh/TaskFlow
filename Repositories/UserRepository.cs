using Microsoft.EntityFrameworkCore;
using TaskFlowApi.Data;
using TaskFlowApi.Entities;
using TaskFlowApi.Interfaces;

namespace TaskFlowApi.Repositories
{
    public class UserRepository : IUserRepositroy
    {
        private readonly AppDbContext _dbContext;
        public UserRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task CreateUserAsync(User user)
        {
            await _dbContext.users.AddAsync(user);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _dbContext.users.ToListAsync();
        }
    }
}
