using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants.Category;

namespace HouseRentingSystem.Infrastructure.Data.Models;

/// <summary>
/// Represents a category for houses.
/// </summary>
[Comment("House category")]
public class Category
{
    /// <summary>
    /// Gets or sets the unique identifier for the category.
    /// </summary>
    [Key]
    [Comment("Category identifier")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the name of the category.
    /// </summary>
    [Required]
    [StringLength(MaxNameLength)]
    [Comment("Category name")]
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the collection of houses belonging to this category.
    /// </summary>
    public ICollection<House> Houses { get; set; } = new HashSet<House>();
}
