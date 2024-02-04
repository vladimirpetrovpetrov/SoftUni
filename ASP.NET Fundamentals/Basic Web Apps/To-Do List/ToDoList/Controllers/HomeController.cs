using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ToDoList.Core.Contracts;
using ToDoList.Core.Models;
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
        var model = await taskService.GetAllPendingTasksAsync();
        var completedModel = await taskService.GetAllCompletedTasksAsync();
        ViewBag.PendingTasksCount = model.Count();
        ViewBag.CompletedTasksCount = completedModel.Count();
        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> Completed()
    {
        var model = await taskService.GetAllCompletedTasksAsync();
        var pendingModel = await taskService.GetAllPendingTasksAsync();
        ViewBag.PendingTasksCount = pendingModel.Count();
        ViewBag.CompletedTasksCount = model.Count();
        return View(model);
    }

    [HttpGet]
    public IActionResult Add()
    {
        var model = new TaskViewModel();
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Add(TaskViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        await taskService.AddAsync(model);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var model = await taskService.GetByIdAsync(id);

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(TaskViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        await taskService.UpdateTaskAsync(model);

        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Delete(int id)
    {
        await taskService.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    public async Task<IActionResult> Done(int id)
    {
        await taskService.DoneAsync(id);
        return RedirectToAction(nameof(Index));
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

    public async Task<IActionResult> Filter(string keyWord, string searchOption)
    {
        var model = await taskService.FilterTasksAsync(keyWord, searchOption);


        return View(model);
    }
}
