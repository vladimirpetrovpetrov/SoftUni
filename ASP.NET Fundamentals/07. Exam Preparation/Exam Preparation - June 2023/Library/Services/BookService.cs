using Library.Contracts;
using Library.Data;
using Library.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.Services;

public class BookService : IBookService
{
    private readonly LibraryDbContext context;
    public BookService(LibraryDbContext _context)
    {
        context = _context;
    }

    public async Task<IEnumerable<AllBookViewModel>> GetBooksAsync()
    {
        return await context.Books
            .Select(b => new AllBookViewModel
            {
                Id = b.Id,
                Title = b.Title,
                Author = b.Author,
                Rating = b.Rating,
                CategoryName = b.Category.Name,
                ImageUrl = b.ImageUrl
            })
            .ToListAsync();
    }

    public async Task<IEnumerable<AllBookViewModel>> GetMyBooksAsync(string userId)
    {
        return await context.UsersBooks
             .Where(u => u.CollectorId == userId)
             .Select(b => new AllBookViewModel
             {
                 Id = b.Book.Id,
                 Title = b.Book.Title,
                 Author = b.Book.Author,
                 Description = b.Book.Description,
                 ImageUrl = b.Book.ImageUrl,
                 CategoryName = b.Book.Category.Name
             })
             .ToListAsync();
    }
}
