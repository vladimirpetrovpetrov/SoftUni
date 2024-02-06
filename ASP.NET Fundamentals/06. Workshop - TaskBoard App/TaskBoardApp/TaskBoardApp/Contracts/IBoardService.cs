using TaskBoardApp.Models.Board;

namespace TaskBoardApp.Contracts;

public interface IBoardService
{
    public Task<IEnumerable<BoardViewModel>> GetAllAsync();
}
