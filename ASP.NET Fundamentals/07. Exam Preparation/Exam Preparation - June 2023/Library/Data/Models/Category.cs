using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Library.Data.DataConstants.CategoryConstants;

namespace Library.Data.Models;

[Comment("Category of a book.")]
public class Category
{
    [Key]
    [Comment("Category identifier")]
    public int Id { get; set; }
    [Required]
    [StringLength(MaxNameLength)]
    [Comment("Category name")]
    public string Name { get; set; } = string.Empty;
    public ICollection<Book> Books { get; set; } = new List<Book>();
}
