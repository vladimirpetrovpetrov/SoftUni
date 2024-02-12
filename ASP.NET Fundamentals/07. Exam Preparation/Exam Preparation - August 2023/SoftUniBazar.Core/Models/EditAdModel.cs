using System.ComponentModel.DataAnnotations;
using static SoftUniBazar.Infrastructure.Constants.AdDataConstants;
using static SoftUniBazar.Infrastructure.ErrorMessages.ErrorMessages;

namespace SoftUniBazar.Core.Models;

public class EditAdModel
{
    [Required]
    public int Id { get; set; }
    [Required(ErrorMessage = RequiredErrorMessage)]
    [StringLength(NameMaxLength, MinimumLength = NameMinLength, ErrorMessage = RequiredLengthErrorMessage)]
    public string Name { get; set; } = string.Empty;
    [Required(ErrorMessage = RequiredErrorMessage)]
    [StringLength(DescMaxLength, MinimumLength = DescMinLength, ErrorMessage = RequiredLengthErrorMessage)]
    public string Description { get; set; } = string.Empty;
    [Required(ErrorMessage = RequiredErrorMessage)]
    [Range(MinPriceValue, int.MaxValue)]
    public decimal Price { get; set; }
    [Required(ErrorMessage = RequiredErrorMessage)]
    public string ImageUrl { get; set; } = string.Empty;
    [Required(ErrorMessage = RequiredErrorMessage)]
    public int CategoryId { get; set; }
    public IEnumerable<CategoryModel> Categories { get; set; } = new List<CategoryModel>();
    public string OwnerId { get; set; } = string.Empty;
}
