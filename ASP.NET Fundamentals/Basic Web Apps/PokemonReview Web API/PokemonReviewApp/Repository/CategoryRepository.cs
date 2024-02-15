using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository;

public class CategoryRepository : ICategoryRepository
{
    private readonly PokemonReviewAppDbContext context;

    public CategoryRepository(PokemonReviewAppDbContext context)
    {
        this.context = context;
    }
    public bool CategoriesExists(int categoryId)
    {
        return context.Categories.Any(c=>c.Id == categoryId);
    }

    public bool CreateCategory(Category category)
    {
        context.Add(category);
        return Save();

    }

    public ICollection<Category> GetCategories()
    {
        return context.Categories.ToList();
    }

    public Category? GetCategory(int id)
    {
        return context
            .Categories
            .Where(c => c.Id == id)
            .FirstOrDefault();
    }

    public ICollection<Pokemon> GetPokemonByCategory(int categoryId)
    {
        return context
            .PokemonsCategories
            .Where(pc=>pc.CategoryId == categoryId)
            .Select(pc=> pc.Pokemon)
            .ToList();
    }

    public bool Save()
    {
        var save = context.SaveChanges();
        return save > 0 ? true : false;
    }
}
