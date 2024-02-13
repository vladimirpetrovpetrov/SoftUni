using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository;

public class PokemonRepository : IPokemonRepository
{
    private readonly PokemonReviewAppDbContext context;

    public PokemonRepository(PokemonReviewAppDbContext context)
    {
        this.context = context;
    }
    public ICollection<Pokemon> GetPokemons()
    {
        return context
            .Pokemons
            .OrderBy(p => p.Id).ToList();
    }

    public Pokemon? GetPokemon(int id)
    {
        return context
            .Pokemons
            .Where(p => p.Id == id)
            .FirstOrDefault();
    }

    public Pokemon? GetPokemon(string name)
    {
        return context
            .Pokemons
            .Where(p => p.Name == name)
            .FirstOrDefault();
    }

    public decimal GetPokemonRating(int pokeId)
    {
        var review = context
            .Reviews
            .Where(p => p.Id == pokeId);

        if (review.Count() == 0)
        {
            return 0;
        }

        return (decimal)review
            .Sum(p => p.Rating) / review.Count();
    }


    public bool PokemonExists(int pokeId)
    {
        return context
            .Pokemons
            .Any(p => p.Id == pokeId);
    }
}
