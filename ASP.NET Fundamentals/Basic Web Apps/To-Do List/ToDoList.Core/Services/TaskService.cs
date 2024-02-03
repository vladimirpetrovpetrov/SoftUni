using Microsoft.EntityFrameworkCore;
using ToDoList.Core.Contracts;
using ToDoList.Core.Models;
using ToDoList.Infrastructure.Data;
using ToDoList.Infrastructure.Data.Models;

namespace ToDoList.Core.Services;

public class TaskService : ITaskService
{
    private readonly ToDoListDbContext context;

    public TaskService(ToDoListDbContext _context)
    {
        context = _context;
    }


    public async Task<IEnumerable<TaskViewModel>> GetAllPendingTasksAsync()
    {
         var model = await context.Tasks
            .Where(t=>t.IsCompleted == false)
            .Select(t => new TaskViewModel()
        {
            Id = t.Id,
            Title = t.Title,
            Description = t.Description,
            Deadline = t.Deadline,
            IsCompleted = t.IsCompleted,
        })
            .ToListAsync();

        return model;
    }

    public async Task<IEnumerable<TaskViewModel>> GetAllCompletedTasksAsync()
    {
        var model = await context.Tasks
           .Where(t => t.IsCompleted == true)
           .Select(t => new TaskViewModel()
           {
               Id = t.Id,
               Title = t.Title,
               Description = t.Description,
               Deadline = t.Deadline,
               IsCompleted = t.IsCompleted,
           })
           .ToListAsync();

        return model;
    }

    public async System.Threading.Tasks.Task AddAsync(TaskViewModel model)
    {
        var task = new Infrastructure.Data.Models.Task()
        {
            Title = model.Title,
            Description = model.Description,
            Deadline = model.Deadline,
            IsCompleted = model.IsCompleted

        };

        await context.Tasks.AddAsync(task);
        await context.SaveChangesAsync();
    }

    public async Task<TaskViewModel> GetByIdAsync(int id)
    {
        var model = await context.Tasks.FindAsync(id);
        var viewModel = new TaskViewModel()
        {
            Id = model.Id,
            Title = model.Title,
            Description = model.Description,
            Deadline = model.Deadline,
            IsCompleted = model.IsCompleted,
        };
        return viewModel;

    }

    public async System.Threading.Tasks.Task UpdateTaskAsync(TaskViewModel model)
    {
        var entity = await context.Tasks.FindAsync(model.Id);
        if (entity != null)
        {
            entity.Title = model.Title;
            entity.Description = model.Description;
            entity.Deadline = model.Deadline;
        }

        await context.SaveChangesAsync();
    }

    public async System.Threading.Tasks.Task DeleteAsync(int id)
    {
        var modelToDelete = await context.Tasks.FindAsync(id);
        if(modelToDelete != null)
        {
            context.Remove(modelToDelete);
        }

        await context.SaveChangesAsync();
    }

    public async System.Threading.Tasks.Task DoneAsync(int id)
    {
        var model = await context.Tasks.FindAsync(id);
        if(model != null)
        {
            model.IsCompleted = true;
        }
        await context.SaveChangesAsync();
    }
}
