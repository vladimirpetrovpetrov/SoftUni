using ToDoList.Core.Models;
using ToDoList.Infrastructure.Data;

namespace ToDoList.Core.Contracts;

public interface ITaskService
{
    public Task<IEnumerable<TaskViewModel>> GetAllTasksAsync();
    public Task AddAsync(TaskViewModel model);
    public Task<TaskViewModel> GetByIdAsync(int id);
    public Task UpdateTaskAsync(TaskViewModel model);

}
