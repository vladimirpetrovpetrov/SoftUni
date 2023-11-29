using Boardgames.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Boardgames.Data.Models;

public class Boardgame
{
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(20)]
    public string Name { get; set; }

    [Required]
    public double Rating { get; set; }

    [Required]
    public int YearPublished { get; set; }

    [Required]
    public CategoryType CategoryType { get; set; }

    [Required]
    public string Mechanics { get; set; }

    [Required]
    public int CreatorId { get; set; }
    [ForeignKey(nameof(CreatorId))]
    public Creator Creator { get; set; }
    public ICollection<BoardgameSeller> BoardgamesSellers { get; set; } = new HashSet<BoardgameSeller>();


}
