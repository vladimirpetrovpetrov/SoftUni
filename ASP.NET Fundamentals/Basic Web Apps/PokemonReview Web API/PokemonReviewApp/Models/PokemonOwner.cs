using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonReviewApp.Models;

public class PokemonOwner
{
    public int PokemonId { get; set; }
    [ForeignKey(nameof(PokemonId))]
    public Pokemon Pokemon { get; set; } = null!;
    public int OwnerId { get; set; }
    [ForeignKey(nameof(OwnerId))]
    public Owner Owner { get; set; } = null!;
}
