using Library.Models;

namespace Library.Contracts;

public interface IBookService
{
    public Task<IEnumerable<AllBookViewModel>> GetBooksAsync();
    public Task<IEnumerable<AllBookViewModel>> GetMyBooksAsync(string userId);
    public Task AddBookToMyCollection(string userId, BookViewModel book);
    public Task RemoveBookFromMyCollection(string userId, int bookId);
    public Task<BookViewModel?> GetBookByIdAsync(int id);
    public Task<IEnumerable<CategoryViewModel>> GetCategoriesAsync();
    public Task AddBookAsync(AddBookViewModel book);
}
