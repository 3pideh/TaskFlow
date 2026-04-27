using TaskFlowApi.Entities;

namespace TaskFlowApi.Interfaces
{
    public interface IUserRepositroy
    {
        Task<List<User>> GetUsersAsync();

        Task CreateUserAsync(User user);
    }
}
