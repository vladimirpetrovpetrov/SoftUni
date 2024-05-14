using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestJWT.Contracts;
using TestJWT.Data;
using TestJWT.Data.Models;
using TestJWT.ViewModels;

namespace TestJWT.Services;

public class ProductService : IProductService
{
    private readonly ApplicationDbContext context;

    public ProductService(ApplicationDbContext context)
    {
        this.context = context;
    }

    public async Task ChangeStateToFinalAsync(int id)
    {
        var product = await context.Products.FirstAsync(x => x.Id == id);

        product.InProgress = false;
        product.IsFinished = true;

        await context.SaveChangesAsync();


    }

    public async Task CreateProductAsync(ProductDTO model)
    {
        var product = new Product
        {
            Name = model.Name,
            DateAdded = DateTime.UtcNow,
            InProgress = true,
            IsFinished = false,
            Quantity = model.Quantity,
        };
        await context.AddAsync<Product>(product);
        await context.SaveChangesAsync();
    }

    public async Task<bool> ProductExistAsync(int id)
    {
        return await context.Products.AnyAsync(p => p.Id == id);
    }
}
