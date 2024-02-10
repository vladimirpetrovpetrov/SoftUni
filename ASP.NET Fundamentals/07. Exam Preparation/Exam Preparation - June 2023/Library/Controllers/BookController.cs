using Library.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Policy;

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
}
