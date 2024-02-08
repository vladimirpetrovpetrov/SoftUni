using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static TaskBoardApp.Data.DataConstants;

namespace TaskBoardApp.Data.Models;

[Comment("Board Tasks")]
public class Task
{
    [Key]
    [Comment("Task identifier")]
    public int Id { get; set; }
    [Required]
    [StringLength(TaskTitleMaxLength)]
    [Comment("Task title")]
    public string Title { get; set; } = string.Empty;
    [Required]
    [StringLength(TaskDescMaxLength)]
    [Comment("Task description")]
    public string Description { get; set; } = string.Empty;
    [Comment("Date of creation")]
    public DateTime? CreatedOn { get; set; }
    [Comment("Board identifier")]
    public int? BoardId { get; set; }
    [ForeignKey(nameof(BoardId))]
    public Board? Board { get; set; }
    [Required]
    [Comment("Application user identifier")]
    public string OwnerId { get; set; } = string.Empty;
    [ForeignKey(nameof(OwnerId))]
    public IdentityUser Owner { get; set; } = null!;
}
