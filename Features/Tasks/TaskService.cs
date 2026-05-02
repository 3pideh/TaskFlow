using TaskFlowApi.Entities;
using TaskFlowApi.Interfaces;

namespace TaskFlowApi.Features.Tasks
{
    public class TaskService 
    {
        public TaskService() { }

        private readonly ITaskRepository _repository;

        public TaskService(ITaskRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<TaskItem>> GetTasksAsync() => await _repository.GetAllAsync();
        public async Task<List<TaskItem>> GetByUserIdAsync(Guid userId) => await _repository.GetByUserIdAsync(userId);
        public async Task CreateTaskAsync(TaskItem task) => await _repository.AddAsync(task);


    }
}
