using Library.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using static Library.Data.DataConstants.BookConstants;

namespace Library.Models;

public class BookViewModel
{
    public int Id { get; set; }

    [Required]
    [StringLength(MaxTitleLength, MinimumLength = MinTitleLength)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [StringLength(MaxAuthorLength, MinimumLength = MinAuthorLength)]
    public string Author { get; set; } = string.Empty;

    [Required]
    [StringLength(MaxDescLength, MinimumLength = MinDescLength)]
    public string Description { get; set; } = string.Empty;

    [Required]
    public string ImageUrl { get; set; } = string.Empty;

    [Required]
    [Range(MinRatingValue, MaxRatingValue)]
    public decimal Rating { get; set; }
    [Required]
    public int CategoryId { get; set; }
}
