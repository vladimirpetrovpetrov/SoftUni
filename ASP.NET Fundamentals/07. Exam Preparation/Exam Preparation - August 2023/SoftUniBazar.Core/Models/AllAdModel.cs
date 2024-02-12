using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using SoftUniBazar.Infrastructure.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SoftUniBazar.Core.Models;

public class AllAdModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Price { get; set; } = string.Empty;
    public string OwnerId { get; set; } = string.Empty;
    public string ImageUrl { get; set; } = string.Empty;
    public string CreatedOn { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public string Owner {  get; set; } = string.Empty;
}
