using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CountryController : Controller
{

    private readonly ICountryRepository countryRepository;
    private readonly IMapper mapper;

    public CountryController(ICountryRepository countryRepository, IMapper mapper)
    {
        this.countryRepository = countryRepository;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(200,Type = typeof(ICollection<CountryDto>))]
    public IActionResult GetCountries()
    {
        var countries = mapper.Map<ICollection<CountryDto>>(countryRepository.GetCountries());

        return Ok(countries);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(200, Type = typeof(CountryDto))]
    [ProducesResponseType(400)]
    public IActionResult GetCountry(int id)
    {
        CountryDto country = mapper.Map<CountryDto>(countryRepository.GetCountry(id));

        if(country == null)
        {
            return NotFound();
        }

        if(!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(country);
    }
    [HttpGet("owners/{ownerId}")]
    [ProducesResponseType(200, Type = typeof(CountryDto))]
    [ProducesResponseType(400)]
    public IActionResult GetOwnersByCategory(int ownerId)
    {
        var country = mapper.Map<CountryDto>(countryRepository.GetCountryByOwner(ownerId));

        if(country == null)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(country);
    }

    [HttpGet("Owners/countryId")]
    [ProducesResponseType(200, Type = typeof(ICollection<OwnerDto>))]
    [ProducesResponseType(400)]
    public IActionResult GetOwnersByCountryId(int countryId)
    {
        var owners = mapper.Map<ICollection<OwnerDto>>(countryRepository.GetOwnersFromCountry(countryId));

        if(owners == null)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(owners);
    }


}