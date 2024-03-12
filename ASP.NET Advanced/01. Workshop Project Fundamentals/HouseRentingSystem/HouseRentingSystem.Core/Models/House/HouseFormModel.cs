using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Core.Constants.MessageConstants;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants.House;


namespace HouseRentingSystem.Core.Models.House;

public class HouseFormModel
{
    [Required(ErrorMessage = RequiredMessage)]
    [StringLength(MaxTitleLength,
        MinimumLength = MinTitleLength,
        ErrorMessage = LengthMessage)]
    public string Title { get; set; } = null!;

    [Required(ErrorMessage = RequiredMessage)]
    [StringLength(MaxAddressLength,
        MinimumLength = MinAddressLength,
        ErrorMessage = LengthMessage)]
    public string Address { get; set; } = null!;

    [Required(ErrorMessage = RequiredMessage)]
    [StringLength(MaxDescLength,
        MinimumLength = MinDescLength,
        ErrorMessage = LengthMessage)]
    public string Description { get; set; } = null!;

    [Required(ErrorMessage = RequiredMessage)]
    [Display(Name = "Image URL")]
    public string ImageUrl { get; set; } = null!;

    [Required(ErrorMessage = RequiredMessage)]
    [Range(typeof(decimal),MinPricePerMonth, MaxPricePerMonth)]
    [Display(Name = "Price Per Month")]
    public decimal PricePerMonth { get; set; }

    [Display(Name = "Category")]
    public int CategoryId { get; set; }

    public IEnumerable<HouseCategoryServiceModel> Categories { get; set; } = new List<HouseCategoryServiceModel>();
}
