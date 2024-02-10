using System.ComponentModel.DataAnnotations;
using static Library.Data.DataConstants.BookConstants;

namespace Library.Models;

public class AddBookViewModel
{
    [Required]
    [StringLength(MaxTitleLength, MinimumLength = MinTitleLength)]
    public string Title { get; set; } = string.Empty;

    [Required]
    [StringLength(MaxAuthorLength, MinimumLength = MinAuthorLength)]
    public string Author { get; set; } = string.Empty;

    [Required]
    [StringLength(MaxDescLength, MinimumLength = MinDescLength)]
    public string Description { get; set; } = string.Empty;

    [Required(AllowEmptyStrings = false)]
    public string Url { get; set; } = string.Empty;

    [Required]
    public string Rating { get; set; } = string.Empty;

    [Range(1,int.MaxValue)]
    public int CategoryId { get; set; }

    [Required]
    public IEnumerable<CategoryViewModel> Categories { get; set; } = new List<CategoryViewModel>();
}
