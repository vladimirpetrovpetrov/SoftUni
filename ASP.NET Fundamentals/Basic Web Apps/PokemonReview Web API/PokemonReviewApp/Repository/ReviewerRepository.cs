using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Data;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Repository;

public class ReviewerRepository : IReviewerRepository
{
    private readonly PokemonReviewAppDbContext context;

    public ReviewerRepository(PokemonReviewAppDbContext context)
    {
        this.context = context;
    }

    public ReviewerWithReviewsDto? GetReviewer(int id)
    {
        return context
            .Reviewers
            .Where(r => r.Id == id)
            .Select(r => new ReviewerWithReviewsDto
            {
                Id = r.Id,
                FirstName = r.FirstName,
                LastName = r.LastName,
                Reviews = r.Reviews.Select(re => new ReviewDto
                {
                    Id = re.Id,
                    Title = re.Title,
                    Text = re.Text,
                    Rating = re.Rating,
                }).ToList()
            })
            .FirstOrDefault();
    }

    public ICollection<Reviewer> GetReviewers()
    {
        return context
            .Reviewers
            .ToList();
    }

    public ICollection<Review> GetReviewsByReviewer(int reviewerId)
    {
        return context.Reviews
            .Where(r => r.ReviewerId == reviewerId)
            .ToList();
    }
}
