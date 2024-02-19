using System.ComponentModel.DataAnnotations;
using static SeminarHub.Infrastructure.Data.DataConstants.SeminarDataConstants;
using static SeminarHub.Infrastructure.Data.ErrorMessages.ErrorMessages;

namespace SeminarHub.Core.Models;

public class AddSeminarForm
{

    [Required(ErrorMessage = RequireErrorMessage)]
    [StringLength(MaxTopicLength, MinimumLength = MinTopicLength, ErrorMessage = LengthErrorMessage)]
    public string Topic { get; set; } = string.Empty;


    [Required(ErrorMessage = RequireErrorMessage)]
    [StringLength(MaxLecturerFieldLength, MinimumLength = MinLecturerFieldLength, ErrorMessage = LengthErrorMessage)]
    public string Lecturer { get; set; } = string.Empty;


    [Required(ErrorMessage = RequireErrorMessage)]
    [StringLength(MaxDetailsLength, MinimumLength = MinDetailsLength, ErrorMessage = LengthErrorMessage)]
    public string Details { get; set; } = string.Empty;

    [Required(ErrorMessage = RequireErrorMessage)]
    public string DateAndTime { get; set; } = string.Empty;

    [Range(DurationMinValue, DurationMaxValue)]
    public int? Duration { get; set; }

    [Required(ErrorMessage = RequireErrorMessage)]
    public int CategoryId { get; set; }

    public ICollection<CategoryViewModel> Categories { get; set; } = new HashSet<CategoryViewModel>();
}
