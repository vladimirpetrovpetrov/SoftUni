using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SoftUniBazar.Infrastructure.Data.Models;

[Comment("Model for advertisement")]
public class Ad
{
    [Key]
    [Comment("Ad identifier")]
    public int Id { get; set; }
}
