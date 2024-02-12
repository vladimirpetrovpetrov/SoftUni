using SoftUniBazar.Core.Models;

namespace SoftUniBazar.Core.Contracts;

public interface ICategoryService
{
    public Task<IEnumerable<CategoryModel>> GetAllCategoriesAsync();
}
