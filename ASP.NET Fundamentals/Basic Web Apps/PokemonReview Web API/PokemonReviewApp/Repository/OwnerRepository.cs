using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;
using System.Net.Mime;

namespace PokemonReviewApp.Repository;

public class OwnerRepository : IOwnerRepository
{
    private readonly PokemonReviewAppDbContext context;

    public OwnerRepository(PokemonReviewAppDbContext context)
    {
        this.context = context;
    }

    public bool CreateOwner(Owner owner)
    {
        context.Add(owner);
        return Save();
    }

    public Owner? GetOwner(int ownerId)
    {
        return context
             .Owners
             .Where(o => o.Id == ownerId)
             .FirstOrDefault();
    }

    public ICollection<Owner> GetOwnerOfAPokemon(int pokeId)
    {
        return context
            .PokemonsOwners
            .Where(po => po.PokemonId == pokeId)
            .Select(po => po.Owner)
            .ToList();
    }

    public ICollection<Owner> GetOwners()
    {
        return context
            .Owners
            .ToList();
    }

    public ICollection<Pokemon> GetPokemonByOwner(int ownerId)
    {
        return context
            .PokemonsOwners
            .Where(po => po.OwnerId == ownerId)
            .Select(po => po.Pokemon)
            .ToList();
    }

    public bool Save()
    {
        var save = context.SaveChanges();
        return save > 0 ? true : false; 
    }
}
