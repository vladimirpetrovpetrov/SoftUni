using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static SoftUniBazar.Infrastructure.Constants.CategoryDataConstants;

namespace SoftUniBazar.Infrastructure.Data.Models;

[Comment("Category of an Advertisement")]
public class Category
{
    [Key]
    [Comment("Category identifier")]
    public int Id { get; set; }
    [Required]
    [Comment("Category name")]
    [StringLength(NameMaxLength)]
    public string Name { get; set; } = string.Empty;
    [Comment("Collection of Advertisements with this category.")]
    public ICollection<Ad> Ads { get; set; } = new List<Ad>();
}
