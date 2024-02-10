using Library.Contracts;
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
}
