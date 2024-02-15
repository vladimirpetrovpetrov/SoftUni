using AutoMapper;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Helper;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Pokemon, PokemonDto>();
        CreateMap<PokemonDto, Pokemon>();
        CreateMap<Category, CategoryDto>();
        CreateMap<CategoryAddDto, Category>();
        CreateMap<Country, CountryDto>();
        CreateMap<CountryAddDto, Country>();
        CreateMap<Owner, OwnerDto>();
        CreateMap<OwnerAddDto, Owner>();
        CreateMap<Review, ReviewDto>();
        CreateMap<Reviewer, ReviewerDto>();
    }
}
