namespace TaskBoardApp.Models.Home;

public class HomeViewModel
{
    public int AllTaksCount { get; set; }
    public List<HomeBoardModel> BoardsWithTasksCount { get; set; } = new List<HomeBoardModel>();
    public int UserTasksCount { get; set; }
}
