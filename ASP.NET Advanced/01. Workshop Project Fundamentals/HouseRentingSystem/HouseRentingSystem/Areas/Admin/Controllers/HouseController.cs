using HouseRentingSystem.Areas.Admin.Models;
using HouseRentingSystem.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace HouseRentingSystem.Areas.Admin.Controllers
{
    public class HouseController : AdminController
    {
        private readonly IHouseService houseService;
        private readonly IAgentService agentService;

        public HouseController(IHouseService houseService, IAgentService agentService)
        {
            this.houseService = houseService;
            this.agentService = agentService;
        }

        public async Task<IActionResult> Mine()
        {
            var myHouses = new MyHousesViewModel();

            var adminUserId = User.Id();
            myHouses.RentedHouses = await houseService.AllHousesByUserIdAsync(adminUserId);

            var adminAgentId = await agentService.GetAgentIdAsync(adminUserId);
            if (adminAgentId != null)
            {
                myHouses.AddedHouses = await houseService.AllHousesByAgentIdAsync((int)adminAgentId);
            }
            return View(myHouses);

        }
    }
}
