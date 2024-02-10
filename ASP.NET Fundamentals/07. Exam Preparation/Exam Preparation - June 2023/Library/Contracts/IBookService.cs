using Library.Models;

namespace Library.Contracts;

public interface IBookService
{
    public Task<IEnumerable<AllBookViewModel>> GetBooksAsync();
}
