using ShoppingListApp.Models;

namespace ShoppingListApp.Contracts;

public interface IProductService
{
    //Will use for all products
    Task<IEnumerable<ProductViewModel>> GetAllAsync();
    //Will use for edit product
    Task<ProductViewModel> GetByIdAsync(int id);
    //Will use when adding product
    Task AddProductAsync(ProductViewModel model);
    //Will use when updating product
    Task UpdateProductAsync(ProductViewModel model);
    //Will use when deleting product
    Task DeleteProductAsync(int id);
}
