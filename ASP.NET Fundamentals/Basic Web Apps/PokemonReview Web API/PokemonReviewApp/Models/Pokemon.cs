namespace PokemonReviewApp.Models;

public class Pokemon
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
    public ICollection<PokemonOwner> PokemonsOwners { get; set; } = new List<PokemonOwner>();
    public ICollection<PokemonCategory> PokemonsCategories { get; set; } = new List<PokemonCategory>();

}
