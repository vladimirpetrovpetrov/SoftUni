using Microsoft.AspNetCore.Mvc;
using SeminarHub.Core.Contracts;
using SeminarHub.Core.Models;
using System.Globalization;
using static SeminarHub.Infrastructure.Data.DataConstants.SeminarDataConstants;

namespace SeminarHub.Controllers;

public class SeminarController : BaseController
{
    private readonly ISeminarService seminarService;
    private readonly ICategoryService categoryService;

    public SeminarController(ISeminarService seminarService, ICategoryService categoryService)
    {
        this.seminarService = seminarService;
        this.categoryService = categoryService;
    }

    public async Task<IActionResult> All()
    {
        var model = await seminarService.GetSeminarsAsync();

        return View(model);
    }

    public async Task<IActionResult> Details(int id)
    {
        var model = await seminarService.GetSeminarDetailsAsync(id);
        if (model == null)
        {
            return BadRequest();
        }

        return View(model);
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var model = await seminarService.GetSeminarForEditAsync(id);

        if (model == null)
        {
            return BadRequest();
        }

        var userId = GetUserId();

        if (model.OrganizerId != userId)
        {
            return Unauthorized();
        }

        model.Categories = await categoryService.GetCategoriesAsync();

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Edit(EditSeminarViewModel model)
    {
        var seminar = await seminarService.GetSeminarForEditAsync(model.Id);

        if (seminar == null)
        {
            return BadRequest();
        }

        var userId = GetUserId();

        if (seminar.OrganizerId != userId)
        {
            return Unauthorized();
        }

        DateTime dateTime = DateTime.Now;

        if (!DateTime.TryParseExact(
           model.DateAndTime,
           RequiredDateFormat,
           CultureInfo.InvariantCulture,
           DateTimeStyles.None,
           out dateTime))
        {
            ModelState.AddModelError(nameof(model.DateAndTime), $"Invalid date! Format must be {RequiredDateFormat}");
        }

        if (!ModelState.IsValid)
        {
            model.Categories = await categoryService.GetCategoriesAsync();

            return View(model);
        }

        await seminarService.UpdateSeminarAsync(model, dateTime);
        return RedirectToAction(nameof(All));
    }

    [HttpGet]
    public async Task<IActionResult> Add()
    {
        var model = new AddSeminarForm();
        model.Categories = await categoryService.GetCategoriesAsync();

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Add(AddSeminarForm model)
    {
        DateTime dateTime = DateTime.Now;

        if (!DateTime.TryParseExact(
           model.DateAndTime,
           RequiredDateFormat,
           CultureInfo.InvariantCulture,
           DateTimeStyles.None,
           out dateTime))
        {
            ModelState.AddModelError(nameof(model.DateAndTime), $"Invalid date! Format must be {RequiredDateFormat}");
        }

        if (!ModelState.IsValid)
        {
            model.Categories = await categoryService.GetCategoriesAsync();
            return View(model);
        }

        var userId = GetUserId();

        await seminarService.AddSeminarAsync(model, userId, dateTime);

        return RedirectToAction(nameof(All));

    }

    public async Task<IActionResult> Join(int id)
    {
        var model = await seminarService.GetSeminarByIdAsync(id);

        if (model == null)
        {
            return BadRequest();
        }

        var userId = GetUserId();

        var isAlreadySub = await seminarService.IsUserSubscribedAsync(userId, id);

        if (isAlreadySub)
        {
            return RedirectToAction(nameof(All));
        }

        var isTheCreator = await seminarService.IsUserTheCreatorAsync(userId, id);

        if (isTheCreator)
        {
            return RedirectToAction(nameof(Joined));
        }

        await seminarService.SubscribeAsync(userId, id);

        return RedirectToAction(nameof(Joined));
    }

    public async Task<IActionResult> Joined()
    {
        string userId = GetUserId();

        var model = await seminarService.GetSubscribedAsync(userId);
        return View(model);
    }

    public async Task<IActionResult> Leave(int id)
    {
        var model = await seminarService.GetSeminarByIdAsync(id);

        if (model == null)
        {
            return BadRequest();
        }

        string userId = GetUserId();

        var isAlreadySub = await seminarService.IsUserSubscribedAsync(userId, id);

        if (!isAlreadySub)
        {
            return RedirectToAction(nameof(Joined));
        }

        await seminarService.UnSubscribeAsync(userId, id);
        return RedirectToAction(nameof(Joined));
    }

    [HttpGet]
    public async Task<IActionResult> Delete(int id)
    {
        var model = await seminarService.GetSeminarForDeleteAsync(id);
        if (model == null)
        {
            return BadRequest();
        }
        var userId = GetUserId();

        var isTheCreator = await seminarService.IsUserTheCreatorAsync(userId, id);

        if (!isTheCreator)
        {
            return Unauthorized();
        }

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var model = await seminarService.GetSeminarForDeleteAsync(id);

        if (model == null)
        {
            return BadRequest();
        }
        var userId = GetUserId();

        var isTheCreator = await seminarService.IsUserTheCreatorAsync(userId, id);

        if (!isTheCreator)
        {
            return Unauthorized();
        }

        await seminarService.DeleteAsync(id);
        return RedirectToAction(nameof(All));

    }
}

