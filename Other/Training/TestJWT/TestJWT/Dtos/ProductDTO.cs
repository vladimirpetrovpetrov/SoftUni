using System.ComponentModel.DataAnnotations;

namespace TestJWT.ViewModels;

public class ProductDTO
{
    [Required]
    [StringLength(100,ErrorMessage = "The name of the product cannot be more than 100 characters long.")]
    public string Name { get; set; } = string.Empty;

    [Required]
    [Range(1,100,ErrorMessage = "The value must be between 1 and 100.")]
    public int Quantity { get; set; }
}
