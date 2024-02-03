using System.ComponentModel.DataAnnotations;
using static ToDoList.Infrastructure.Constants.ValidationConstants;

namespace ToDoList.Core.Models;

public class TaskViewModel
{

    public int Id { get; set; }

    [Required(ErrorMessage = RequiredErrorMessage)]
    [StringLength(30, MinimumLength = 3, ErrorMessage = TitleLengthErrorMessage)]
    public string Title { get; set; } = string.Empty;
    [Required(ErrorMessage = RequiredErrorMessage)]
    [StringLength(250, MinimumLength = 10, ErrorMessage = DescLengthErrorMessage)]
    public string Description { get; set; } = string.Empty;
    [Required(ErrorMessage = RequiredErrorMessage)]
    [DataType(DataType.Date)]
    public DateTime Deadline { get; set; }
    public bool IsCompleted { get; set; }
}
