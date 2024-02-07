using Microsoft.Build.Framework;
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
}
