using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.DataConstants;

namespace TaskBoardApp.Data.Models;

public class Board
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(BoardNameMaxLength)]
    public string Name { get; set; } = null!;
    public ICollection<Task> Tasks { get; set; } = new List<Task>();
}