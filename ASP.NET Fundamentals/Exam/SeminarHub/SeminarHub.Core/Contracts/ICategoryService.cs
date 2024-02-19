using SeminarHub.Core.Models;

namespace SeminarHub.Core.Contracts;

public interface ICategoryService
{
    public Task<ICollection<CategoryViewModel>> GetCategoriesAsync();
}
