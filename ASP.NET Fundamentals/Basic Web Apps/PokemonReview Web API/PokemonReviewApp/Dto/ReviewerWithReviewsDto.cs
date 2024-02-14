namespace PokemonReviewApp.Dto;

public class ReviewerWithReviewsDto
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty; 
    public ICollection<ReviewDto> Reviews { get; set; }
}
