using ToDoList.Core.Contracts;
using ToDoList.Core.Models;
using ToDoList.Infrastructure.Data;

namespace ToDoList.Core.Services;

public class TaskService : ITaskService
{
    private readonly ToDoListDbContext context;

    public TaskService(ToDoListDbContext _context)
    {
        context = _context;
    }

    public async Task<IEnumerable<TaskViewModel>> GetAllTasksAsync()
    {
         var model = context.Tasks
            .Where(t=>t.IsCompleted == false)
            .Select(t => new TaskViewModel()
        {
            Id = t.Id,
            Title = t.Title,
            Description = t.Description,
            HoursLeft = (t.Deadline - DateTime.Now).Hours,
            IsCompleted = t.IsCompleted,
        })
            .ToList();

        return model;
    }
}
