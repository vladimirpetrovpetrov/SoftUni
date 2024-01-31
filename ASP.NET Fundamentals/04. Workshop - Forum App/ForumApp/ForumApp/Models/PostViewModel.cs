using ForumApp.Data;
using System.ComponentModel.DataAnnotations;

namespace ForumApp.Models;

public class PostViewModel
{
    public int Id { get; set; }
    [StringLength(DataConstants.PostViewModel.TitleMaxLength,MinimumLength =DataConstants.PostViewModel.TitleMinLength, ErrorMessage = "Field {0} must be between {2} and {1} symbols.")]
    public string Title { get; set; } = string.Empty;
    [StringLength(DataConstants.PostViewModel.ContentMaxLength, MinimumLength = DataConstants.PostViewModel.ContentMinLength, ErrorMessage = "Field {0} must be between {2} and {1} symbols.")]
    public string Content { get; set; } = string.Empty;
}
