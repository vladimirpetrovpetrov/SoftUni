using ToDoList.Core.Models;
using ToDoList.Infrastructure.Data;

namespace ToDoList.Core.Contracts;

public interface ITaskService
{
    public Task<IEnumerable<TaskViewModel>> GetAllPendingTasksAsync();
    public Task<IEnumerable<TaskViewModel>> GetAllCompletedTasksAsync();
    public Task AddAsync(TaskViewModel model);
    public Task<TaskViewModel> GetByIdAsync(int id);
    public Task UpdateTaskAsync(TaskViewModel model);
    public Task DeleteAsync(int id);
    public Task DoneAsync(int id);
    public Task<IEnumerable<TaskViewModel>> FilterTasksAsync(string keyWord, string searchOption);
    public Task<IEnumerable<TaskViewModel>> SortAsync(string sorter);
}
