using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Controllers;
[Route("api/[controller]")]
[ApiController]
public class PokemonController : Controller
{
    private readonly IPokemonRepository pokemonRepository;
    private readonly IMapper mapper;

    public PokemonController(IPokemonRepository pokemonRepository, IMapper mapper)
    {
        this.pokemonRepository = pokemonRepository;
        this.mapper = mapper;
    }
    [HttpGet]
    [ProducesResponseType(200,Type = typeof(IEnumerable<PokemonDto>))]
    public IActionResult GetPokemons()
    {
        var pokemons = mapper.Map<List<PokemonDto>>(pokemonRepository.GetPokemons());

        if(!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(pokemons);
    }

    [HttpGet("{pokeId}")]
    [ProducesResponseType(200, Type = typeof(PokemonDto))]
    [ProducesResponseType(400)]
    public IActionResult GetPokemon(int pokeId)
    {
       if(!pokemonRepository.PokemonExists(pokeId))
        {
            return NotFound();
        }

       var pokemon = mapper.Map<PokemonDto>(pokemonRepository.GetPokemon(pokeId));

        if(!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(pokemon);
    }

    [HttpGet("{pokeId}/rating")]
    [ProducesResponseType(200, Type = typeof(decimal))]
    [ProducesResponseType(400)]
    public IActionResult GetPokemonRating(int pokeId)
    {
        if (!pokemonRepository.PokemonExists(pokeId))
        {
            return NotFound();
        }

        var averageRating = pokemonRepository.GetPokemonRating(pokeId);

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(averageRating);
    }

}
