using TaskFlowApi.Entities;

namespace TaskFlowApi.Interfaces
{
    public interface ITaskRepository
    {
        Task<List<TaskItem>> GetAllAsync();
        Task<List<TaskItem>> GetByUserIdAsync(Guid userId);
        Task AddAsync(TaskItem task);
    }
}
