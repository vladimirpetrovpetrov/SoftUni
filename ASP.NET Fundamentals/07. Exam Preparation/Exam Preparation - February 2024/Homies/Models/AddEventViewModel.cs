using System.ComponentModel.DataAnnotations;
using static Homies.Data.DataConstants.EventConstants;
using Type = Homies.Data.Models.Type;
using static Homies.Data.ErrorConstants;
using Microsoft.AspNetCore.Identity;

namespace Homies.Models;

public class AddEventViewModel
{
    public int? Id { get; set; }
    [Required(ErrorMessage = RequiredErrorMessage)]
    [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = RequiredLengthMessage)]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = RequiredErrorMessage)]
    [StringLength(DescMaxLength, MinimumLength = DescMinLength, ErrorMessage = RequiredLengthMessage)]
    public string Description { get; set; } = string.Empty;

    [Required(ErrorMessage = RequiredErrorMessage)]
    public string Start { get; set; } = string.Empty;

    [Required(ErrorMessage = RequiredErrorMessage)]
    public string End { get; set; } = string.Empty;

    [Required(ErrorMessage = RequiredErrorMessage)]
    public int TypeId { get; set; }
    public string? Organiser { get; set; }
    [Required]
    public List<TypeViewModel> Types { get; set; } = new List<TypeViewModel>();
}
