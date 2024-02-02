using ToDoList.Infrastructure.Data.Models;

namespace ToDoList.Core.Contracts;

public interface ITaskService
{
    public Task<IEnumerable<>> GetAllTasksAsync();

}
