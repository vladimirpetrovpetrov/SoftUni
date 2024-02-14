using PokemonReviewApp.Data;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository;

public class ReviewRepository : IReviewRepository
{
    private readonly PokemonReviewAppDbContext context;

    public ReviewRepository(PokemonReviewAppDbContext context)
    {
        this.context = context;
    }
    public Review? GetReview(int id)
    {
        return context
            .Reviews
            .Where(r => r.Id == id)
            .FirstOrDefault();
    }

    public ICollection<Review> GetReviews()
    {
        return context
            .Reviews
            .ToList();
    }

    public ICollection<Review> GetReviewsOfAPokemon(int pokeId)
    {
        var reviews = context
            .Reviews
            .Where(r=>r.PokemonId == pokeId)
            .ToList();
        return reviews;
    }
}
