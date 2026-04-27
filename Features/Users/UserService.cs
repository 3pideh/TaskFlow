using Microsoft.EntityFrameworkCore;
using TaskFlowApi.Data;
using TaskFlowApi.Entities;
using TaskFlowApi.Interfaces;

namespace TaskFlowApi.Features.Users
{
    public class UserService
    {
        private readonly IUserRepositroy _userRepositroy;

        public UserService(IUserRepositroy userRepositroy)
        {
            _userRepositroy = userRepositroy;
        }

        public async Task<List<User>> GetUsersAsync()
        {
            return await _userRepositroy.GetUsersAsync();
        }

        public async Task CreateUserAsync(User user)
        {
            user.Id = Guid.NewGuid();
            await _userRepositroy.CreateUserAsync(user);
        }
    }
}
