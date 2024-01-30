using System.ComponentModel.DataAnnotations;

namespace ShoppingListApp.Models;

public class ProductViewModel
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Field {0} is required")]
    [Display(Name = "Product Name")] //this change the errorMessage in {0}. 
    [StringLength(100, MinimumLength = 3, ErrorMessage = " Field {0} must be between {2} and {1} symbols")]
    //{0} is always the property , and becouse StringLength has 2 attr. , then {1} is max length(100) and {2} is min length(3).
    public string Name { get; set; } = string.Empty;
}
