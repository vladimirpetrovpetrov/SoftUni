using PokemonReviewApp.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace PokemonReviewApp.Dto;

public class OwnerAddDto
{
    public string FirstName { get; set; } 
    public string LastName { get; set; } 
    public string Gym { get; set; } 
    public CountryAddDto Country {  get; set; }
}
