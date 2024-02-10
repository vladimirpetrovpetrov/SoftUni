using System.ComponentModel.DataAnnotations;
using static Library.Data.DataConstants.CategoryConstants;


namespace Library.Models;

public class CategoryViewModel
{
    [Required]
    public int Id { get; set; }
    [Required]
    [StringLength(MaxNameLength, MinimumLength = MinNameLength)]
    public string Name { get; set; } = string.Empty;
}
