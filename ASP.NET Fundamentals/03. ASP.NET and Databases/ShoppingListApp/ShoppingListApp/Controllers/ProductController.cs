using Microsoft.AspNetCore.Mvc;
using ShoppingListApp.Contracts;

namespace ShoppingListApp.Controllers
{
    public class ProductController : Controller
    {
        public readonly IProductService productService;

        public ProductController(IProductService _productService)
        {
            productService = _productService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await productService.GetAllAsync();

            return View(model);
        }
    }
}
