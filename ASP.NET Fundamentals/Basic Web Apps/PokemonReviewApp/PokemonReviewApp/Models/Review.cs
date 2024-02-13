using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonReviewApp.Models;

public class Review
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Text { get; set; } = string.Empty;
    public int Rating { get; set; }
    public int ReviewerId { get; set; }
    [ForeignKey(nameof(ReviewerId))]
    public Reviewer Reviewer { get; set; } = null!;
    public int PokemonId { get; set; }
    [ForeignKey(nameof(PokemonId))]
    public Pokemon Pokemon { get; set; } = null!;

}
