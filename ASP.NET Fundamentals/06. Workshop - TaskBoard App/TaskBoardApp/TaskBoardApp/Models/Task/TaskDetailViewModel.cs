namespace TaskBoardApp.Models.Task;

public class TaskDetailViewModel :TaskViewModel
{
    public string CreatedOn { get; init; } = string.Empty;
    public string Board { get; init; } = string.Empty;
}
