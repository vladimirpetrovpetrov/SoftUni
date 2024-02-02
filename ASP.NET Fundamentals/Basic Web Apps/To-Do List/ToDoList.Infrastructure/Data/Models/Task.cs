using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Infrastructure.Data.Models;

[Comment("Pending Task")]
public class Task
{
    [Key]
    [Comment("Id of the task")]
    public int Id { get; set; }
    [Comment("Task title")]
    [Required]
    [MaxLength(30)]
    public string Title { get; set; } = string.Empty;
    [Comment("Task description")]
    [MaxLength(250)]
    public string Description { get; set; } = string.Empty;
    [Comment("Task deadline")]
    [Required]
    public DateTime Deadline { get; set; }
    [Comment("Is the task completed")]
    public bool IsCompleted {  get; set; } = false;
}
