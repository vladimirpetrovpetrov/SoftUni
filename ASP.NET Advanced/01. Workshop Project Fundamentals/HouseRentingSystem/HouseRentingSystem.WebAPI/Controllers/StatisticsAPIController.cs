using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.Statistics;
using Microsoft.AspNetCore.Mvc;

namespace HouseRentingSystem.WebAPI.Controllers
{
    [Route("api/statistics")]
    [ApiController]
    public class StatisticsAPIController : ControllerBase
    {
        private readonly IHouseService houseService;

        public StatisticsAPIController(IHouseService houseService)
        {
            this.houseService = houseService;
        }

        [HttpGet]
        [Produces(contentType:"application/json")]
        [ProducesResponseType(200,Type = typeof(StatisticsServiceModel))]
        [ProducesResponseType(400)]
        public async Task<IActionResult> GetStatistics()
        {
            var result = await houseService.GetStatisticsAsync();

            if (result == null)
            {
                return NotFound();
            }

            return Ok(result);
        }


    }
}
