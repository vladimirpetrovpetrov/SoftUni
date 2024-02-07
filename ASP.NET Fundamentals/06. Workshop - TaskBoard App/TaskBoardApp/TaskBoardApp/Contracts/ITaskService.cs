using TaskBoardApp.Models.Task;

namespace TaskBoardApp.Contracts;

public interface ITaskService
{
    public Task<IEnumerable<TaskBoardModel>> GetBoardsAsync();
    public Task CreateAsync(TaskFormModel task, string ownerId);
}
