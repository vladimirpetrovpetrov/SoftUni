using TaskBoardApp.Models.Task;

namespace TaskBoardApp.Contracts;

public interface ITaskService
{
    public Task<IEnumerable<TaskBoardModel>> GetBoardsAsync();
    public Task CreateAsync(TaskFormModel task, string ownerId);
    public Task<TaskDetailViewModel> DetailsAsync(int id);
    public Task<TaskFormModel> GetByIdAsync(int id);
    public Task UpdateAsync(TaskFormModel model);
    public Task<string> GetOwnerId(int id);
}
