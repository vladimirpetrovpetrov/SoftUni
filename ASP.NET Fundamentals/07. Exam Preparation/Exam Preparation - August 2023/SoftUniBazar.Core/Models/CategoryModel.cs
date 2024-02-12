using System.ComponentModel.DataAnnotations;
using static SoftUniBazar.Infrastructure.Constants.CategoryDataConstants;
using static SoftUniBazar.Infrastructure.ErrorMessages.ErrorMessages;

namespace SoftUniBazar.Core.Models;

public class CategoryModel
{
    [Required(ErrorMessage = RequiredErrorMessage)]
    public int Id { get; set; }
    [Required(ErrorMessage = RequiredErrorMessage)]
    [StringLength(NameMaxLength, MinimumLength = NameMinLength)]
    public string Name { get; set; } = string.Empty;
}
