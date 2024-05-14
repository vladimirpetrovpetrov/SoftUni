using TestJWT.ViewModels;

namespace TestJWT.Contracts;

public interface IProductService
{
    Task CreateProductAsync(ProductDTO model);
    Task<bool> ProductExistAsync(int id);
    Task ChangeStateToFinalAsync(int id);
}
