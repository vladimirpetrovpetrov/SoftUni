using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static SeminarHub.Infrastructure.Data.DataConstants.CategoryDataConstants;

namespace SeminarHub.Infrastructure.Data.Models;

public class Category
{
    [Key]
    [Comment("Category identifier")]
    public int Id { get; set; }

    [Required]
    [StringLength(MaxNameLength)]
    [Comment("Name of the category")]
    public string Name { get; set; } = string.Empty;

    [Comment("Seminars of this category")]
    public ICollection<Seminar> Seminars { get; set; } = new List<Seminar>();
}