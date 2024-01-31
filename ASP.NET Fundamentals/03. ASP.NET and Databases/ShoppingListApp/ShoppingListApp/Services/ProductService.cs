using Microsoft.EntityFrameworkCore;
using ShoppingListApp.Contracts;
using ShoppingListApp.Data;
using ShoppingListApp.Data.Models;
using ShoppingListApp.Models;

namespace ShoppingListApp.Services
{
    public class ProductService : IProductService
    {
        private readonly ShoppingListDbContext context;

        public ProductService(ShoppingListDbContext _context)
        {
                context = _context;
        }

        public async Task AddProductAsync(ProductViewModel model)
        {
            var entity = new Product()
            {
                Name = model.Name
            };

            await context.Products.AddAsync(entity);
            await context.SaveChangesAsync();
        }

        public async Task DeleteProductAsync(int id)
        {
            var entity = await context.Products.FindAsync(id);

            if (entity == null)
            {
                throw new ArgumentException("Invalid product");
            }

            context.Products.Remove(entity);
            await context.SaveChangesAsync();
        }

        public async Task<IEnumerable<ProductViewModel>> GetAllAsync()
        {
            return await context.Products
                .AsNoTracking() //without change tracker , cuz we will not be doing any changes
                .Select(p => new ProductViewModel //we are getting data model , and want to convert it to viewMdoel
                {
                    Id = p.Id,
                    Name = p.Name,
                })
                .ToListAsync(); // we are working async
        }

        public async Task<ProductViewModel> GetByIdAsync(int id)
        {

            var entity = await context.Products.FindAsync(id);

            if(entity == null)
            {
                throw new ArgumentException("Invalid product");
            }

            return new ProductViewModel()
            {
                Id = entity.Id,
                Name = entity.Name
            };

        }

        public async Task UpdateProductAsync(ProductViewModel model)
        {

            var entity = await context.Products.FindAsync(model.Id);

            if (entity == null)
            {
                throw new ArgumentException("Invalid product");
            }

            entity.Name = model.Name;

            await context.SaveChangesAsync();

        }
    }
}
