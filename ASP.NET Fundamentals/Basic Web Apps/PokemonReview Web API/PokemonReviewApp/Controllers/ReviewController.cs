using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;
using System.Collections.Generic;

namespace PokemonReviewApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReviewController : Controller
{
    private readonly IReviewRepository reviewRepository;
    private readonly IMapper mapper;

    public ReviewController(IReviewRepository reviewRepository, IMapper mapper)
    {
        this.reviewRepository = reviewRepository;
        this.mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(200, Type = typeof(ICollection<ReviewDto>))]
    public IActionResult GetReviews()
    {
        var reviews = mapper.Map<ICollection<ReviewDto>>(reviewRepository.GetReviews());
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(reviews);
    }

    [HttpGet("{reviewId}")]
    [ProducesResponseType(200, Type = typeof(ReviewDto))]
    [ProducesResponseType(400)]
    public IActionResult GetReview(int reviewId)
    {
        var review = mapper.Map<ReviewDto>(reviewRepository.GetReview(reviewId));

        if (review == null)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(review);
    }

    [HttpGet("{pokeId}/reviews")]
    [ProducesResponseType(200, Type = typeof(ICollection<ReviewDto>))]
    [ProducesResponseType(400)]
    public IActionResult GetReviewsOfAPokemon(int pokeId)
    {
        var reviews = mapper.Map<ICollection<ReviewDto>>(reviewRepository.GetReviewsOfAPokemon(pokeId));

        if(reviews == null)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return Ok(reviews);
    }

}
//ICollection<Review> GetReviewsOfAPokemon(int pokeId);
