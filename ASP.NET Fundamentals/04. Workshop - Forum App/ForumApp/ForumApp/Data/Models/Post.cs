using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ForumApp.Data.Models;

public class Post
{
    [Comment("Post identifier")]
    [Key]
    public int Id { get; init; }
    [Comment("Post title")]
    [MaxLength(DataConstants.Post.TitleMaxLength)]
    [Required]
    public string Title { get; set; } = null!;
    [Comment("Post content")]
    [MaxLength(DataConstants.Post.ContentMaxLength)]
    [Required]
    public string Content { get; set; } = null!;
}
