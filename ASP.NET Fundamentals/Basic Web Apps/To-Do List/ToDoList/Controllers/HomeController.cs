using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDoList.Core.Contracts;
using ToDoList.Models;

namespace ToDoList.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> logger;
    private readonly ITaskService taskService;

    public HomeController(ILogger<HomeController> _logger, ITaskService _taskService)
    {
        logger = _logger;
        taskService = _taskService;
    }

    public async Task<IActionResult> Index()
    {
        var model = await taskService.GetAllTasksAsync();
        return View(model);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
