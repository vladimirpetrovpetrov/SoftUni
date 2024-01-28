using Microsoft.AspNetCore.Mvc;
using MVCIntroDemo.Models.Product;

namespace MVCIntroDemo.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult All()
        {
            return View(_products);
        }

        public IActionResult ById(int id)
        {
            var product = _products.FirstOrDefault(x => x.Id == id);
            if(product == null)
            {
                return BadRequest();
            }

            return View(product);
        }

        private IEnumerable<ProductViewModel> _products = new List<ProductViewModel>()
        {
            new ProductViewModel()
            {
                Id= 1,
                Name = "Cheese",
                Price = 7.00
            },

            new ProductViewModel()
            {
                Id= 2,
                Name = "Ham",
                Price = 5.50
            },

            new ProductViewModel()
            {
                Id= 3,
                Name = "Bread",
                Price = 1.50
            }
        };
    }
}
