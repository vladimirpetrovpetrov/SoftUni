using Microsoft.EntityFrameworkCore;
using SeminarHub.Core.Contracts;
using SeminarHub.Core.Models;
using SeminarHub.Infrastructure;

namespace SeminarHub.Core.Services;

public class CategoryService : ICategoryService
{
    private readonly SeminarHubDbContext context;

    public CategoryService(SeminarHubDbContext context)
    {
        this.context = context;
    }
    public async Task<ICollection<CategoryViewModel>> GetCategoriesAsync()
    {
        return await context
            .Categories
            .Select(c => new CategoryViewModel
            {
                Name = c.Name,
                Id = c.Id
            })
            .ToListAsync();
    }
}
