using PokemonReviewApp.Models;

namespace PokemonReviewApp.Dto;

public class ReviewerDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
}
