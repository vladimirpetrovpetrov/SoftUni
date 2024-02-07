using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using TaskBoardApp.Contracts;
using TaskBoardApp.Data;
using TaskBoardApp.Models.Task;
using Task = TaskBoardApp.Data.Models.Task;

namespace TaskBoardApp.Services;

public class TaskService : ITaskService
{
    private readonly TaskBoardAppDbContext dbContext;
    private readonly IBoardService boardService;

    public TaskService(TaskBoardAppDbContext dbContext, IBoardService boardService)
    {
        this.dbContext = dbContext;
        this.boardService = boardService;
    }

    public async System.Threading.Tasks.Task CreateAsync(TaskFormModel task, string ownerId)
    {
        Task model = new Task()
        {
            Title = task.Title,
            Description = task.Description,
            CreatedOn = DateTime.Now,
            BoardId = task.BoardId,
            OwnerId = ownerId
        };

        await dbContext.AddAsync(model);
        await dbContext.SaveChangesAsync();
    }

    public async Task<TaskDetailViewModel> DetailsAsync(int id)
    {
        var entity = dbContext.Tasks
            .Include(t => t.Board)
            .Include(t=>t.Owner)
            .First(t => t.Id == id);

        //.First(t => t.Id == id);
        var model = new TaskDetailViewModel
        {
            Id = entity.Id,
            Title = entity.Title,
            Description = entity.Description,
            CreatedOn = entity.CreatedOn.ToString("dd/MM/yyyy HH:mm"),
            Board = entity.Board.Name,
            Owner = entity.Owner.UserName
        };

        return model;
    }

    public async Task<TaskFormModel> GetByIdAsync(int id)
    {
        var entity = dbContext.Tasks
            .First(t=>t.Id == id);
        TaskFormModel model = new TaskFormModel()
        {
            Id = entity.Id,
            Title = entity.Title,
            Description = entity.Description,
            BoardId= entity.BoardId,
            Boards = await GetBoardsAsync()
        };
        return model;
    }

    public async Task<IEnumerable<TaskBoardModel>> GetBoardsAsync()
    {
        var boards = await boardService.GetAllAsync();
        var taskBoards = boards
            .Select(tb => new TaskBoardModel
            {
                Id = tb.Id,
                Name = tb.Name,
            }).ToList();
        return taskBoards;
    }

    public async System.Threading.Tasks.Task UpdateAsync(TaskFormModel model)
    {
        var entity = await dbContext.Tasks.FirstAsync(t => t.Id == model.Id);
        if(entity !=  null)
        {
            entity.Title = model.Title;
            entity.Description = model.Description;
            entity.BoardId = model.BoardId;
        }
        await dbContext.SaveChangesAsync();
    }

    public async Task<string> GetOwnerIdAsync(int id)
    {
        var entity = await dbContext.Tasks
            .FindAsync(id);
        return entity.OwnerId;
    }

    public async System.Threading.Tasks.Task DeleteAsync(TaskFormModel model)
    {
        var entityToDelete = await dbContext.Tasks.FindAsync(model.Id);

        if( entityToDelete != null)
        {
            dbContext.Tasks.Remove(entityToDelete);
            await dbContext.SaveChangesAsync();
        }
    }
}
