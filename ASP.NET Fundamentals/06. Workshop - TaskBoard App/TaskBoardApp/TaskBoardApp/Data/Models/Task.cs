using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.DataConstants;

namespace TaskBoardApp.Data.Models;

public class Task
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(TaskTitleMaxLength)]
    public string Title { get; set; } = null!;
    [Required]
    [StringLength(TaskDescMaxLength)]
    public string Description { get; set; } = null!;
    public DateTime CreatedOn { get; set; }
    public int BoardId { get; set; }
    public Board? Board { get; set; }
    [Required]
    public string OwnerId { get; set; } = null!;
    public IdentityUser Owner { get; set; } = null!;
}
