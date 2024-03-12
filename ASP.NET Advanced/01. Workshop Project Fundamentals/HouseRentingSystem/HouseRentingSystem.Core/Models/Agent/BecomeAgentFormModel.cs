using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Core.Constants.MessageConstants;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants.Agent;

namespace HouseRentingSystem.Core.Models.Agent;

public class BecomeAgentFormModel
{
    [Required(ErrorMessage = RequiredMessage)]
    [StringLength(
        MaxPhoneNumberLength,
        MinimumLength = MinPhoneNumberLength,
        ErrorMessage = LengthMessage)]
    [Display(Name = "Phone number")]
    [Phone]
    public string PhoneNumber { get; set; } = null!;
}
