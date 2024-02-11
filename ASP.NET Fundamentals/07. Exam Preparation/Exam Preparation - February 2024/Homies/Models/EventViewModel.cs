using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Homies.Models;

public class EventViewModel
{
    [Key]
    public int Id { get; set; }

    [Required]
    public string Name { get; set; } = string.Empty;

    [Required]
    public string Description { get; set; } = string.Empty;

    [Required]
    public string Organiser { get; set; } = null!;

    [Required]
    public DateTime CreatedOn { get; set; }

    [Required]
    public DateTime Start { get; set; }

    [Required]
    public DateTime End { get; set; }

    [Required]
    public string Type { get; set; } = string.Empty;
}
