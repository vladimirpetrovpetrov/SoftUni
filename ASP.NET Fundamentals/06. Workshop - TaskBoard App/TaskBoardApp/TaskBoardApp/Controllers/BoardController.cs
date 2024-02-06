using Microsoft.AspNetCore.Mvc;
using TaskBoardApp.Contracts;
using TaskBoardApp.Data;

namespace TaskBoardApp.Controllers;

public class BoardController : Controller
{
    private readonly IBoardService boardService;

    public BoardController(IBoardService _boardService)
    {
        boardService = _boardService;
    }
    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> All()
    {
        var model = await boardService.GetAllAsync();
        return View(model);
    }
}
