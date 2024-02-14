using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PokemonReviewApp.Dto;
using PokemonReviewApp.Interfaces;
using PokemonReviewApp.Models;

namespace PokemonReviewApp.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ReviewerController : Controller
{
    private readonly IReviewerRepository reviewerRepository;
    private readonly IMapper mapper;

    public ReviewerController(IReviewerRepository reviewerRepository, IMapper mapper)
    {
        this.reviewerRepository = reviewerRepository;
        this.mapper = mapper;
    }
    [HttpGet]
    [ProducesResponseType(200, Type = typeof(ICollection<ReviewerDto>))]
    public IActionResult GetReviewers()
    {
        var reviewers = mapper.Map<ICollection<ReviewerDto>>(reviewerRepository.GetReviewers());

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(reviewers);
    }

    [HttpGet("{reviewerId}")]
    [ProducesResponseType(200, Type = typeof(ReviewerWithReviewsDto))]
    [ProducesResponseType(400)]
    public IActionResult GetReviewer(int reviewerId)
    {
        var reviewer = reviewerRepository.GetReviewer(reviewerId);


        if (reviewer == null)
        {
            return NotFound();
        }

        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }

        return Ok(reviewer);
    }

    [HttpGet("{reviewerId}/reviews")]
    [ProducesResponseType(200, Type = typeof(ICollection<ReviewDto>))]
    [ProducesResponseType(400)]
    public IActionResult GetReviewsByReviewer(int reviewerId)
    {
        var reviews = mapper.Map<ICollection<ReviewDto>>(reviewerRepository.GetReviewsByReviewer(reviewerId));

        if (reviews == null)
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