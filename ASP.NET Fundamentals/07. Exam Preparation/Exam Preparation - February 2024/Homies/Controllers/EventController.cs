using Homies.Contracts;
using Homies.Data;
using Homies.Models;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace Homies.Controllers;

public class EventController : BaseController
{
    private readonly IEventService eventService;

    public EventController(IEventService eventService)
    {
        this.eventService = eventService;
    }

    public async Task<IActionResult> All()
    {
        var model = await eventService.GetAllEventsAsync();

        return View(model);
    }

    public async Task<IActionResult> Joined()
    {
        var userId = GetUserId();
        var model = await eventService.GetJoinedEventsAsync(userId);
        return View(model);
    }

    public async Task<IActionResult> Join(int id)
    {
        var eventToAdd = await eventService.GetEventByIdAsync(id);
        if(eventToAdd == null)
        {
            return RedirectToAction("All");
        }

        var userId = GetUserId();
        bool alreadyJoinedEvent = await eventService.AddEventToJoinedAsync(userId, eventToAdd);
        if(alreadyJoinedEvent)
        {
            return RedirectToAction("All");
        }

        return RedirectToAction("Joined");
    }

    public async Task<IActionResult> Leave(int id)
    {
        var eventToRemove = await eventService.GetEventByIdAsync(id);
        if (eventToRemove == null)
        {
            return BadRequest();
        }

        var userId = GetUserId();

        await eventService.RemoveEventFromJoinedAsync(userId, eventToRemove);

        return RedirectToAction("All");
    }
    [HttpGet]
    public async Task<IActionResult> Add()
    {
        List<TypeViewModel> tpm = await eventService.GetAllEventTypesAsync();

        AddEventViewModel model = new AddEventViewModel
        {
            Types = tpm
        };

        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Add(AddEventViewModel model)
    {
        DateTime start = DateTime.Now;
        DateTime end = DateTime.Now;

        if(!DateTime.TryParseExact(
            model.Start,
            DataConstants.EventConstants.DateFormat
            ,CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out start)
            )
        {
            ModelState.AddModelError(nameof(model.Start), $"Invalid date! Format must be: {DataConstants.EventConstants.DateFormat}");
        }

        if (!DateTime.TryParseExact(
            model.End,
            DataConstants.EventConstants.DateFormat
            , CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out end)
            )
        {
            ModelState.AddModelError(nameof(model.End), $"Invalid date! Format must be: {DataConstants.EventConstants.DateFormat}");
        }

        if (!ModelState.IsValid)
        {
            model.Types = await eventService.GetAllEventTypesAsync();

            return View(model);
        }

        var userId = GetUserId();

        await eventService.AddEventAsync(userId, model, start,end);

        return RedirectToAction("All");
    }

    [HttpGet]
    public async Task<IActionResult> Edit(int id)
    {
        var model = await eventService.GetEventByIdForEditAsync(id);

        if (model == null)
        {
            return BadRequest();
        }

        var userId = GetUserId();
        if(userId != model.Organiser)
        {
            return Unauthorized();
        }
        return View(model);
    }
    [HttpPost]
    public async Task<IActionResult> Edit(AddEventViewModel model)
    {
        if (model == null)
        {
            return BadRequest();
        }

        var userId = GetUserId();


        DateTime start = DateTime.Now;
        DateTime end = DateTime.Now;

        if (!DateTime.TryParseExact(
            model.Start,
            DataConstants.EventConstants.DateFormat
            , CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out start)
            )
        {
            ModelState.AddModelError(nameof(model.Start), $"Invalid date! Format must be: {DataConstants.EventConstants.DateFormat}");
        }

        if (!DateTime.TryParseExact(
            model.End,
            DataConstants.EventConstants.DateFormat
            , CultureInfo.InvariantCulture,
            DateTimeStyles.None,
            out end)
            )
        {
            ModelState.AddModelError(nameof(model.End), $"Invalid date! Format must be: {DataConstants.EventConstants.DateFormat}");
        }

        if (!ModelState.IsValid)
        {
            model.Types = await eventService.GetAllEventTypesAsync();
            model.Organiser = model.Organiser;
            return View(model);
        }

        await eventService.EditEventAsync(userId, model, start, end);

        return RedirectToAction("All");
    }

    public async Task<IActionResult> Details(int id)
    {
        var model = await eventService.GetDetailsAsync(id);

        if(model == null)
        {
            return BadRequest();
        }

        return View(model);
    }

}
