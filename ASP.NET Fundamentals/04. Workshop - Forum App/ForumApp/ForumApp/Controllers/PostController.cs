using ForumApp.Contracts;
using ForumApp.Data;
using ForumApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace ForumApp.Controllers;

public class PostController : Controller
{
    private readonly IPostService postService;

    public PostController(IPostService _postService)
    {
        postService = _postService;
    }
    [HttpGet]
    public async Task<IActionResult> Index()
    {
        var model = await postService.GetAllAsync();

        return View(model);
    }
    [HttpGet]
    public IActionResult Add()
    {
        var model = new PostViewModel();
        return View(model);     
    }

    [HttpPost]
    public async Task<IActionResult> Add(PostViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        await postService.AddAsync(model);

        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var model = await postService.GetByIdAsync(id);
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(PostViewModel model)
    {
        if (!ModelState.IsValid)
        {
            return View(model);
        }

        await postService.UpdateAsync(model);

        return RedirectToAction(nameof(Index));
    }

    [HttpPost]
    public async Task<IActionResult> Delete(int id)
    {
        await postService.DeleteAsync(id);


        return RedirectToAction(nameof(Index));
    }
}
