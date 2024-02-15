using PokemonReviewApp.Data;
using PokemonReviewApp.Dto;
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

    public bool CreatePokemon(int ownerId, int categoryId, Pokemon pokemon)
    {
        var pokemonOwnerEntity = context
            .Owners
            .Where(o => o.Id == ownerId)
            .FirstOrDefault();

        var category = context
            .Categories
            .Where(c=>c.Id == categoryId)
            .FirstOrDefault ();

        var pokemonOwner = new PokemonOwner()
        {
            Owner = pokemonOwnerEntity,
            Pokemon = pokemon
        };

        context.Add(pokemonOwner);

        var pokemonCategory = new PokemonCategory()
        {
            Category = category,
            Pokemon = pokemon
        };

        context.Add(pokemonCategory);

        context.Add(pokemon);

        return Save();
    }

    public bool Save()
    {
        var saved = context.SaveChanges();
        return saved > 0 ? true : false;
    }
    public Pokemon? GetPokemonTrimToUpper(PokemonDto pokemonCreate)
    {
        return GetPokemons().Where(c => c.Name.Trim().ToUpper() == pokemonCreate.Name.TrimEnd().ToUpper())
            .FirstOrDefault();
    }
}
