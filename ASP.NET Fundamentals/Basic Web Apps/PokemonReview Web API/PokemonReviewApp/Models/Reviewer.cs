namespace PokemonReviewApp.Models;

public class Reviewer
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; }= string.Empty;
    public ICollection<Review> Reviews { get; set; } = new List<Review>();

}
