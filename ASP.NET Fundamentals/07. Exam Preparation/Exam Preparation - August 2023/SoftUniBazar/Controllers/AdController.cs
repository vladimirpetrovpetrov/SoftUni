using Microsoft.AspNetCore.Mvc;
using SoftUniBazar.Core.Contracts;

namespace SoftUniBazar.Controllers
{
    public class AdController : BaseController
    {
        private readonly IAdService adService;

        public AdController(IAdService adService)
        {
            this.adService = adService;
        }

        public async Task<IActionResult> All()
        {
            var model = await adService.GetAllAdAsync();

            return View(model);
        }

        public async Task<IActionResult> AddToCart(int id)
        {
            var model = await adService.GetAdByIdAsync(id);

            if (model == null)
            {
                return BadRequest();
            }
            var userId = GetUserId();
            var isAdded = await adService.CheckIfAlreadyAddedAsync(model.Id, userId);

            if (isAdded)
            {
                return RedirectToAction("All");
            }

            await adService.AddToCardAsync(userId, model.Id);

            return RedirectToAction("Cart");
        }

        public async Task<IActionResult> Cart()
        {
            var userId = GetUserId();

            var model = await adService.GetAllAdInCartAsync(userId);

            return View(model);
        }

        public async Task<IActionResult> RemoveFromCart(int id)
        {
            var model = await adService.GetAdByIdAsync(id);

            if (model == null)
            {
                return BadRequest();
            }
            var userId = GetUserId();
            var isAdded = await adService.CheckIfAlreadyAddedAsync(model.Id, userId);

            if (!isAdded)
            {
                return RedirectToAction("Cart");
            }

            await adService.RemoveFromCartAsync(userId, model.Id);

            return RedirectToAction("All");
        }
    }
}
