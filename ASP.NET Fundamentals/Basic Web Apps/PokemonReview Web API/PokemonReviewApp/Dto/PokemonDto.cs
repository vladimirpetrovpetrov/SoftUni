using PokemonReviewApp.Models;

namespace PokemonReviewApp.Dto;

public class PokemonDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
}
