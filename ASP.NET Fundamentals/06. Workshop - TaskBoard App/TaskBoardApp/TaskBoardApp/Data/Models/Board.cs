using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.DataConstants;

namespace TaskBoardApp.Data.Models;

[Comment("App board")]
public class Board
{
    [Key]
    [Comment("Board identifier")]
    public int Id { get; set; }
    [Required]
    [StringLength(BoardNameMaxLength)]
    [Comment("Board name")]
    public string Name { get; set; } = string.Empty;
    public ICollection<Task> Tasks { get; set; } = new List<Task>();
}