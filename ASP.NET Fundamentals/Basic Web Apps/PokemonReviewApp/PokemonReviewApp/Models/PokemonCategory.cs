using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonReviewApp.Models;

public class PokemonCategory
{
    public int PokemonId { get; set; }
    [ForeignKey(nameof(PokemonId))]
    public Pokemon Pokemon { get; set; } = null!;
    public int CategoryId { get; set; }
    [ForeignKey(nameof(CategoryId))]
    public Category Category { get; set; } = null!;
}
