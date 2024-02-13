using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonReviewApp.Models;

public class Owner
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Gym { get; set; } = string.Empty;
    public int CountryId { get; set; }
    [ForeignKey(nameof(CountryId))]
    public Country Country { get; set; } = null!;
    public ICollection<PokemonOwner> PokemonsOwners { get; set; } = new List<PokemonOwner>();

}
