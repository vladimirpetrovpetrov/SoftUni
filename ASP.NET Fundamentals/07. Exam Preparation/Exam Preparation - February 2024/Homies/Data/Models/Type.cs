using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static Homies.Data.DataConstants.TypeConstants;

namespace Homies.Data.Models;

[Comment("Type of the event")]
public class Type
{
    [Key]
    [Comment("Type identifier")]
    public int Id { get; set; }

    [Required]
    [StringLength(NameMaxLength)]
    [Comment("Type name")]
    public string Name { get; set; } = string.Empty;

    public List<Event> Events { get; set; } = new List<Event>();
}
