using System.ComponentModel.DataAnnotations;
using static TaskBoardApp.Data.DataConstants;

namespace TaskBoardApp.Models.Task;

public class TaskFormModel
{
    [Required]
    [Display(Name = "Title")]
    [StringLength(TaskTitleMaxLength, MinimumLength = TaskTitleMinLength,ErrorMessage = LengthError)]
    public string Title { get; set; } = null!;
    [Required]
    [Display(Name = "Description")]
    [StringLength(TaskDescMaxLength, MinimumLength = TaskDescMinLength, ErrorMessage = LengthError)]
    public string Description { get; set; } = null!;
    [Display(Name = "Board")]
    public int BoardId { get; set; }
    public IEnumerable<TaskBoardModel> Boards { get; set; } = new List<TaskBoardModel>();
}