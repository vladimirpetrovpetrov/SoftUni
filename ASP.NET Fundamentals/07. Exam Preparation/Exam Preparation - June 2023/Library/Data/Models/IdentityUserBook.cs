using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Data.Models;

[Comment("User Books")]
public class IdentityUserBook
{
    [Comment("Book collector identifier")]
    [Required]
    public string CollectorId { get; set; }  = string.Empty;
    [Comment("Collector")]
    [ForeignKey(nameof(CollectorId))]
    public IdentityUser Collector { get; set; } = null!;
    [Required]
    [Comment("Book identifier")]
    public int BookId { get; set; }
    [Comment("Book")]
    [ForeignKey(nameof(BookId))]
    public Book Book { get; set; } = null!;
}
