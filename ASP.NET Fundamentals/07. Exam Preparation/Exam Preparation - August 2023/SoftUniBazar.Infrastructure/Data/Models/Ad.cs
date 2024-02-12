using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static SoftUniBazar.Infrastructure.Constants.AdDataConstants;

namespace SoftUniBazar.Infrastructure.Data.Models;

[Comment("Model for advertisement")]
public class Ad
{
    [Key]
    [Comment("Advertisement identifier")]
    public int Id { get; set; }
    [Required]
    [StringLength(NameMaxLength)]
    [Comment("Advertisement name")]
    public string Name { get; set; } = string.Empty;
    [Required]
    [StringLength(DescMaxLength)]
    [Comment("Advertisement description")]
    public string Description { get; set; } = string.Empty;
    [Required]
    [Comment("Advertisement price")]
    public decimal Price { get; set; }
    [Required]
    [Comment("Advertisement owner identifier")]
    public string OwnerId { get; set; } = string.Empty;
    [Required]
    [ForeignKey(nameof(OwnerId))]
    [Comment("Advertisement owner")]
    public IdentityUser Owner { get; set; } = null!;
    [Required]
    [Comment("Advertisement URL of the image")]
    public string ImageUrl { get; set; } = string.Empty;
    [Required]
    [Comment("Advertisement date and time of creation")]
    public DateTime CreatedOn { get; set; }
    [Required]
    [Comment("Advertisement category identifier")]
    public int CategoryId { get; set; }
    [Required]
    [ForeignKey(nameof(CategoryId))]
    [Comment("Advertisement category")]
    public Category Category { get; set; } = null!;
}