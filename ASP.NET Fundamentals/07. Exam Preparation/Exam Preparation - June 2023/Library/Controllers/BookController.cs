using Library.Contracts;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers;

public class BookController : BaseController
{
    private readonly IBookService bookService;
    public BookController(IBookService _bookService)
    {
        bookService = _bookService;
    }
    public async Task<IActionResult> All()
    {
        var model = await bookService.GetBooksAsync();

        return View(model);
    }

    public async Task<IActionResult> Mine()
    {
        var userId = GetUserId();
        var model = await bookService.GetMyBooksAsync(userId);

        return View(model);
    }

    public async Task<IActionResult> AddToCollection(int id)
    {
        var bookToAdd = await bookService.GetBookByIdAsync(id);

        if (bookToAdd == null)
        {
            return RedirectToAction("All");
        }

        var userId = GetUserId();

        await bookService.AddBookToMyCollection(userId, bookToAdd);

        return RedirectToAction("All");
    }

    public async Task<IActionResult> RemoveFromCollection(int id)
    {
        var bookToAdd = await bookService.GetBookByIdAsync(id);

        if (bookToAdd == null)
        {
            return RedirectToAction("Mine");
        }
        var userId = GetUserId();

        await bookService.RemoveBookFromMyCollection(userId, id);

        return RedirectToAction("Mine");
    }
    [HttpGet]
    public async Task<IActionResult> Add()
    {
        var categories = await bookService.GetCategoriesAsync();
        var model = new AddBookViewModel
        {
            Categories = categories
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Add(AddBookViewModel model)
    {
        decimal rating;

        if(!decimal.TryParse(model.Rating, out rating) || rating< 0 || rating > 10)
        {
            ModelState.AddModelError(model.Rating, "Rating must be a number between 0.00 and 10.00");

            return View(model); 
        }

        if(!ModelState.IsValid)
        {
            return View(model);
        }

        await bookService.AddBookAsync(model);

        return RedirectToAction("All");
    }
}
