using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Controllers;
[Route("api/[controller]")]
[ApiController]
public class CategoryController : Controller
{
    private readonly ICategoryRepository categoryRepository;
    private readonly IMapper mapper;

    public CategoryController(ICategoryRepository categoryRepository, IMapper mapper)
    {
        this.categoryRepository = categoryRepository;
        this.mapper = mapper;
    }

    [HttpGet("GetCategories")]
    [ProducesResponseType(200, Type = typeof(ICollection<CategoryDto>))]
    public IActionResult GetCategories()
    {
        var categories = mapper.Map<List<CategoryDto>>(categoryRepository.GetCategories());

        return Ok(categories);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(200, Type = typeof(CategoryDto))]
    [ProducesResponseType(400)]
    public IActionResult GetCategory(int id)
    {
        var category = mapper.Map<CategoryDto>(categoryRepository.GetCategory(id));

        if(category == null)
        {
            return NotFound();
        }

        if(!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(category);
    }

    [HttpGet("pokemon/{categoryId}")]
    [ProducesResponseType(200, Type = typeof(ICollection<PokemonDto>))]
    [ProducesResponseType(400)]
    public IActionResult GetPokemonsByCategory(int categoryId)
    {
        var pokemons = mapper.Map<ICollection<PokemonDto>>(categoryRepository.GetPokemonByCategory(categoryId));

        if (!ModelState.IsValid)
        {
            return BadRequest(pokemons);
        }

        return Ok(pokemons);
    }

}
