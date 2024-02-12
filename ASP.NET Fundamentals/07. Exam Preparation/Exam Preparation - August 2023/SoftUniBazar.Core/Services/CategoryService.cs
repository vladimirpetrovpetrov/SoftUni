using Microsoft.EntityFrameworkCore;
using SoftUniBazar.Core.Contracts;
using SoftUniBazar.Core.Models;
using SoftUniBazar.Data;

namespace SoftUniBazar.Core.Services;

public class CategoryService : ICategoryService
{
    private readonly BazarDbContext context;

    public CategoryService(BazarDbContext context)
    {
        this.context = context;
    }

    public async Task<IEnumerable<CategoryModel>> GetAllCategoriesAsync()
    {
        return await context.Categories
            .Select(c => new CategoryModel
            {
                Name = c.Name,
                Id = c.Id
            }).ToListAsync();
    }
}
