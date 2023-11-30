using System.ComponentModel.DataAnnotations;

namespace Footballers.Data.Models;

public class Team
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(40)]
    public string Name { get; set; }
    [Required]
    [MaxLength(40)]
    public string Nationality { get; set; }
    [Required]
    public int Trophies { get; set; }
    public ICollection<TeamFootballer> TeamsFootballers { get; set; } = new HashSet<TeamFootballer>();




}
