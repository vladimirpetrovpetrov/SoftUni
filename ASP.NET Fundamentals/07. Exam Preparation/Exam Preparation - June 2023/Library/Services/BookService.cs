using Library.Contracts;
using Library.Data;
using Library.Data.Models;
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

    public async Task AddBookToMyCollection(string userId, BookViewModel book)
    {
        var isAlreadyAdded = await context.UsersBooks.AnyAsync(ub => ub.CollectorId == userId && ub.BookId == book.Id);
        if(!isAlreadyAdded)
        {
            var userBook = new IdentityUserBook
            {
                CollectorId = userId,
                BookId = book.Id
            };
            await context.UsersBooks.AddAsync(userBook);
            await context.SaveChangesAsync();
        }
        
    }

    public async Task<BookViewModel?> GetBookByIdAsync(int id)
    {
        return await context.Books
            .Where(b => b.Id == id)
            .Select(b => new BookViewModel
            {
                Id = b.Id,
                Title = b.Title,
                Author = b.Author,
                Description = b.Description,
                ImageUrl = b.ImageUrl,
                CategoryId = b.CategoryId
            })
            .FirstOrDefaultAsync();

    }

    public async Task RemoveBookFromMyCollection(string userId, int bookId)
    {
        var modelToDelete = await context.UsersBooks.FirstOrDefaultAsync(ub=> ub.CollectorId == userId && ub.BookId == bookId);

        if(modelToDelete != null)
        {
            context.UsersBooks.Remove(modelToDelete);
            await context.SaveChangesAsync();
        }
    }
    public async Task<IEnumerable<CategoryViewModel>> GetCategoriesAsync()
    {
        return await context.Categories
            .Select(c => new CategoryViewModel
            {
                Id = c.Id,
                Name = c.Name
            })
            .ToListAsync();
    }

    public async Task AddBookAsync(AddBookViewModel book)
    {
        Book bookToAdd = new Book
        {
            Title = book.Title,
            Author = book.Author,
            Description = book.Description,
            ImageUrl = book.Url,
            CategoryId = book.CategoryId,
            Rating = decimal.Parse(book.Rating)
        };
        await context.Books.AddAsync(bookToAdd);
        await context.SaveChangesAsync();
    }
}
