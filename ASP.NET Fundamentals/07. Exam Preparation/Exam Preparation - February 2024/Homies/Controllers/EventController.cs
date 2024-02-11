using Homies.Contracts;
using Microsoft.AspNetCore.Mvc;

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
}
