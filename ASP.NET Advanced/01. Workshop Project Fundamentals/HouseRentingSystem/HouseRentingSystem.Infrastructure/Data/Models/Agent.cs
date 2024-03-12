using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants.Agent;

namespace HouseRentingSystem.Infrastructure.Data.Models;

[Index(nameof(PhoneNumber), IsUnique = true)]
/// <summary>
/// Represents an agent responsible for managing houses.
/// </summary>
[Comment("Agent of the house")]
public class Agent
{
    /// <summary>
    /// Gets or sets the unique identifier for the agent.
    /// </summary>
    [Key]
    [Comment("Agent identifier")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the phone number of the agent.
    /// </summary>
    [Required]
    [StringLength(MaxPhoneNumberLength)]
    [Comment("Agent phone number")]
    public string PhoneNumber { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the identifier of the user associated with the agent.
    /// </summary>
    [Required]
    [Comment("User identifier")]
    public string UserId { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the user associated with the agent.
    /// </summary>
    [ForeignKey(nameof(UserId))]
    public IdentityUser User { get; set; } = null!;
    /// <summary>
    /// Gets or sets the collection of houses managed by this agent.
    /// </summary>
    public ICollection<House> Houses { get; set; } = new HashSet<House>();
}
