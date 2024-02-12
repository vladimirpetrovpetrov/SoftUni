using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SoftUniBazar.Infrastructure.Data.Models;


public class AdBuyer
{
    [Required]
    [Comment("Identifier of the buyer of the advertisement.")]
    public string BuyerId { get; set; } = string.Empty;
    [Required]
    [ForeignKey(nameof(BuyerId))]
    [Comment("Navigation property representing the buyer of the advertisement")]
    public IdentityUser Buyer { get; set; } = null!;
    [Required]
    [Comment("Identifier of the advertisement being bought.")]
    public int AdId { get; set; }
    [Required]
    [ForeignKey(nameof(AdId))]
    [Comment("Navigation property representing the advertisement being bought")]
    public Ad Ad { get; set; } = null!;
}
