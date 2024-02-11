using Homies.Contracts;
using Homies.Data;
using Homies.Data.Models;
using Homies.Models;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using static Homies.Data.DataConstants.EventConstants;

namespace Homies.Service;

public class EventService : IEventService
{
    private readonly HomiesDbContext context;

    public EventService(HomiesDbContext context)
    {
        this.context = context;
    }

    public async Task AddEventAsync(string userId, AddEventViewModel model, DateTime start, DateTime end)
    {
        var eventToAdd = new Event()
        {
            Name = model.Name,
            Description = model.Description,
            CreatedOn = DateTime.Now,
            Start = start,
            End = end,
            OrganiserId = userId,
            TypeId = model.TypeId
        };

        await context.Events.AddAsync(eventToAdd);
        await context.SaveChangesAsync();
    }

    public async Task<bool> AddEventToJoinedAsync(string userId, EventViewModel model)
    {
        var isAlreadyJoined = await context.EventsParticipants
            .AnyAsync(ep => ep.HelperId == userId && ep.EventId == model.Id);

        if (isAlreadyJoined == false)
        {
            var toAdd = new EventParticipant
            {
                HelperId = userId,
                EventId = model.Id,
            };
            await context.EventsParticipants.AddAsync(toAdd);
            await context.SaveChangesAsync();

            return false;
        }
        return true;
    }

    public async Task EditEventAsync(string userId, AddEventViewModel model, DateTime start, DateTime end)
    {
        var eventToEdit = await context.Events
            .FindAsync(model.Id);
        if (eventToEdit != null)
        {
            eventToEdit.Name = model.Name;
            eventToEdit.Description = model.Description;
            eventToEdit.Start = start;
            eventToEdit.End = end;
            eventToEdit.TypeId = model.TypeId;

            await context.SaveChangesAsync();
        }


    }

    public async Task<IEnumerable<AllEventViewModel>> GetAllEventsAsync()
    {
        return await context.Events
            .Select(x => new AllEventViewModel
            {
                Id = x.Id,
                Name = x.Name,
                Start = x.Start.ToString(DateFormat),
                Type = x.Type.Name,
                Organiser = x.Organiser.UserName
            }).ToListAsync();
    }

    public async Task<List<TypeViewModel>> GetAllEventTypesAsync()
    {
        return await context.Types
            .Select(t => new TypeViewModel
            {
                Id = t.Id,
                Name = t.Name,
            }).ToListAsync();
    }

    public async Task<DetailsEventViewModel?> GetDetailsAsync(int id)
    {
        return await context.Events
             .Where(e => e.Id == id)
             .Select(e => new DetailsEventViewModel
             {
                 Id = e.Id,
                 Name = e.Name,
                 Description = e.Description,
                 Start = e.Start.ToString(DateFormat),
                 Type = e.Type.Name,
                 Organiser = e.Organiser.UserName,
                 End = e.End.ToString(DateFormat),
                 CreatedOn = e.CreatedOn.ToString(DateFormat),
             }).FirstOrDefaultAsync();
    }

    public async Task<EventViewModel?> GetEventByIdAsync(int id)
    {
        return await context.Events
            .Where(e => e.Id == id)
            .Select(e => new EventViewModel
            {
                Id = e.Id,
                Name = e.Name,
                Description = e.Description,
                Organiser = e.Organiser.UserName,
                CreatedOn = e.CreatedOn,
                Start = e.Start,
                End = e.End,
                Type = e.Type.Name
            }).FirstOrDefaultAsync();
    }

    public async Task<AddEventViewModel?> GetEventByIdForEditAsync(int id)
    {
        var types = await GetAllEventTypesAsync();
        return await context.Events
            .Where(e => e.Id == id)
            .Select(e => new AddEventViewModel
            {
                Id = e.Id,
                Name = e.Name,
                Description = e.Description,
                Start = e.Start.ToString(DateFormat, CultureInfo.InvariantCulture),
                End = e.End.ToString(DateFormat, CultureInfo.InvariantCulture),
                TypeId = e.TypeId,
                Types = types,
                Organiser = e.Organiser.Id
            }).FirstOrDefaultAsync();
    }

    public async Task<IEnumerable<AllEventViewModel>> GetJoinedEventsAsync(string userId)
    {
        return await context.EventsParticipants
            .Where(ep => ep.HelperId == userId)
            .Select(ep => new AllEventViewModel
            {
                Id = ep.Event.Id,
                Name = ep.Event.Name,
                Start = ep.Event.Start.ToString(DateFormat),
                Type = ep.Event.Type.Name,
                Organiser = ep.Event.Organiser.UserName
            })
            .ToListAsync();
    }

    public async Task RemoveEventFromJoinedAsync(string userId, EventViewModel model)
    {
        var isJoined = await context.EventsParticipants
            .AnyAsync(ep => ep.HelperId == userId && ep.EventId == model.Id);
        if (isJoined)
        {
            EventParticipant toRemove = new EventParticipant()
            {
                HelperId = userId,
                EventId = model.Id
            };
            context.EventsParticipants.Remove(toRemove);
            await context.SaveChangesAsync();
        }
    }
}
