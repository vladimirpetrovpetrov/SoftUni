using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Core.Constants.MessageConstants;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants.House;

namespace HouseRentingSystem.Core.Models.House;

public class HouseServiceModel
{
    public int Id { get; set; }
    [Required(ErrorMessage = RequiredMessage)]
    [StringLength(MaxTitleLength,
        MinimumLength = MinTitleLength,
        ErrorMessage = LengthMessage)]
    public string Title { get; set; } = string.Empty;
    [Required(ErrorMessage = RequiredMessage)]
    [StringLength(MaxAddressLength,
        MinimumLength = MinAddressLength,
        ErrorMessage = LengthMessage)]
    public string Address { get; set; } = string.Empty;
    [Display(Name = "Image URL")]
    [Required(ErrorMessage = RequiredMessage)]
    public string ImageUrl { get; set; } = string.Empty;
    [Required(ErrorMessage = RequiredMessage)]
    [Range(typeof(decimal),
        MinPricePerMonth,
        MaxPricePerMonth)]
    [Display(Name = "Price Per Month")]
    public decimal PricePerMonth { get; set; }
    [Display(Name = "Is Rented")]
    public bool IsRented { get; set; }
}