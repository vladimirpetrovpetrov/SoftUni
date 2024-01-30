using System.ComponentModel.DataAnnotations;

namespace ShoppingListApp.Models;

public class ProductViewModel
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Field {0} is required")]
    [Display(Name="Product Name")] //this change the errorMessage in {0}. 
    [StringLength(100, MinimumLength =3)]
    public string Name { get; set; } = string.Empty;
}
