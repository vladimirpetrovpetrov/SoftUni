using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Interfaces;

public interface IReviewerRepository
{
    ICollection<Reviewer> GetReviewers();
    ReviewerWithReviewsDto GetReviewer(int id);
    ICollection<Review> GetReviewsByReviewer(int reviewerId);
}
