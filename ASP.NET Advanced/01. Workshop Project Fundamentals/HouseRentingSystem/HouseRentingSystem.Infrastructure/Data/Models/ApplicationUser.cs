using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants.ApplicationUser;

namespace HouseRentingSystem.Infrastructure.Data.Models;

public class ApplicationUser : IdentityUser
{
    [Required]
    [MaxLength(MaxFirstNameLength)]
    public string FirstName { get; set; } = null!;

    [Required]
    [MaxLength(MaxLastNameLength)]
    public string LastName { get; set; } = null!;
}
