using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository;

public class CountryRepository : ICountryRepository
{
    private readonly PokemonReviewAppDbContext context;

    public CountryRepository(PokemonReviewAppDbContext context)
    {
        this.context = context;
    }

    public bool CreateCountry(Country country)
    {
        context.Add(country);
        return Save();
    }

    public ICollection<Country> GetCountries()
    {
        return context
            .Countries
            .ToList();
    }

    public Country? GetCountry(int id)
    {
        return context
            .Countries
            .Where(c => c.Id == id)
            .FirstOrDefault();
    }

    public Country? GetCountryByOwner(int ownerId)
    {
        var country = context
            .Owners
            .Where(o => o.Id == ownerId)
            .Select(c => c.Country)
            .FirstOrDefault();

        return country;

    }

    public ICollection<Owner> GetOwnersFromCountry(int countryId)
    {
        return context
            .Owners
            .Where(o => o.CountryId == countryId)
            .ToList();
    }

    public bool Save()
    {
        var save = context.SaveChanges();
        return save > 0 ? true : false;
    }
}
