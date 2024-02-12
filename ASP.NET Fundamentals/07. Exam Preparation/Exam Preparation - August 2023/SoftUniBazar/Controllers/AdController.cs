using Microsoft.AspNetCore.Mvc;
using SoftUniBazar.Core.Contracts;
using SoftUniBazar.Core.Models;

namespace SoftUniBazar.Controllers
{
    public class AdController : BaseController
    {
        private readonly IAdService adService;
        private readonly ICategoryService categoryService;

        public AdController(IAdService adService, ICategoryService categoryService)
        {
            this.adService = adService;
            this.categoryService = categoryService;
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

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new AddAdModel();
            var categories = await categoryService.GetAllCategoriesAsync();
            model.Categories = categories;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(AddAdModel model)
        {
            
            if (model == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await categoryService.GetAllCategoriesAsync();
                return View(model);
            }
            var userId = GetUserId();


            await adService.AddAdAsync(userId,model);

            return RedirectToAction("All");
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await adService.GetModelForEditByIdAsync(id);
            if (model == null)
            {
                return BadRequest();
            }

            if(model.OwnerId != GetUserId())
            {
                return BadRequest();
            }

            model.Categories = await categoryService.GetAllCategoriesAsync();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(EditAdModel model)
        {
           if(model == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                model.Categories = await categoryService.GetAllCategoriesAsync();
                return View(model);
            }

            await adService.EditAdAsync(model);

            return RedirectToAction("All");
        }
    }
}
