using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Library.Data.DataConstants.BookConstants;

namespace Library.Data.Models;
[Comment("Book for the library.")]
public class Book
{
    [Key]
    [Comment("Book identifier")]
    public int Id { get; set; }

    [Required]
    [StringLength(MaxTitleLength)]
    [Comment("Book title")]
    public string Title { get; set; } = string.Empty;

    [Required]
    [StringLength(MaxAuthorLength)]
    [Comment("Book author")]
    public string Author { get; set; } = string.Empty;

    [Required]
    [StringLength(MaxDescLength)]
    [Comment("Book description")]
    public string Description { get; set; } = string.Empty;

    [Required]
    [Comment("Book image")]
    public string ImageUrl { get; set; } = string.Empty;

    [Required]
    [Range(MinRatingValue, MaxRatingValue)]
    [Comment("Book rating")]
    public decimal Rating { get; set; }
    [Required]
    [Comment("Category identifier of the book")]
    public int CategoryId { get; set; }
    [Required]
    [ForeignKey(nameof(CategoryId))]
    [Comment("Category of the book")]
    public Category Category { get; set; } = null!;
    public ICollection<IdentityUserBook> UsersBooks { get; set; } = new List<IdentityUserBook>();


}
