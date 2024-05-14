using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TestJWT.Contracts;
using TestJWT.ViewModels;

namespace TestJWT.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProductController : ControllerBase
{
    private readonly IProductService productService;

    public ProductController(IProductService productService)
    {
        this.productService = productService;
    }

    [HttpPost]
    [Route("create")]
    [Authorize]
    public async Task<IActionResult> Create([FromBody] ProductDTO product)
    {
        await productService.CreateProductAsync(product);

        return Ok($"You just added {product.Name}");
    }

    [HttpPut]
    [Route("complete/{id}")]
    [Authorize]
    public async Task<IActionResult> Complete(int id)
    {
        if (!await productService.ProductExistAsync(id))
        {
            return NotFound(new { message = "There is no product with this id.", status = StatusCodes.Status404NotFound });
        }

        await productService.ChangeStateToFinalAsync(id);

        return Ok("The state of the product is set to Final.");
    }
}
