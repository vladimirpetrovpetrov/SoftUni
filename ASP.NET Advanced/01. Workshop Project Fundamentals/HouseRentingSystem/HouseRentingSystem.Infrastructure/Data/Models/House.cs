using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static HouseRentingSystem.Infrastructure.Constants.DataConstants.House;

namespace HouseRentingSystem.Infrastructure.Data.Models;

/// <summary>
/// Represents a house available for rent.
/// </summary>
[Comment("House to rent")]
public class House
{
    /// <summary>
    /// Gets or sets the unique identifier for the house.
    /// </summary>
    [Key]
    [Comment("House identifier")]
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the title of the house.
    /// </summary>
    [Required]
    [StringLength(MaxTitleLength)]
    [Comment("House title")]
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the address of the house.
    /// </summary>
    [Required]
    [StringLength(MaxAddressLength)]
    [Comment("House address")]
    public string Address { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the description of the house.
    /// </summary>
    [Required]
    [StringLength(MaxDescLength)]
    [Comment("House description")]
    public string Description { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the URL of the image representing the house.
    /// </summary>
    [Required]
    [Comment("House image url")]
    public string ImageUrl { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the price per month for renting the house.
    /// </summary>
    [Required]
    [Range(typeof(decimal), MinPricePerMonth, MaxPricePerMonth, ConvertValueInInvariantCulture = true)]
    [Column(TypeName = "decimal(18,2)")]
    [Comment("House price per month")]
    public decimal PricePerMonth { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the category to which the house belongs.
    /// </summary>
    [Required]
    [Comment("Category identifier")]
    public int CategoryId { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the agent responsible for managing the house.
    /// </summary>
    [Required]
    [Comment("Agent identifier")]
    public int AgentId { get; set; }

    /// <summary>
    /// Gets or sets the identifier of the renter currently occupying the house, if any.
    /// </summary>
    [Comment("Renter identifier")]
    public string? RenterId { get; set; }

    /// <summary>
    /// Gets or sets the category to which the house belongs.
    /// </summary>
    [ForeignKey(nameof(CategoryId))]
    public Category Category { get; set; } = null!;

    /// <summary>
    /// Gets or sets the agent responsible for managing the house.
    /// </summary>
    [ForeignKey(nameof(AgentId))]
    public Agent Agent { get; set; } = null!;
}
