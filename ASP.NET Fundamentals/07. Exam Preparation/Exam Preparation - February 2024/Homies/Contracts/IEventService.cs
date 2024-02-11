using Homies.Models;

namespace Homies.Contracts;

public interface IEventService
{
    public Task<IEnumerable<AllEventViewModel>> GetAllEventsAsync();
    public Task<IEnumerable<AllEventViewModel>> GetJoinedEventsAsync(string userId);
    public Task<EventViewModel> GetEventByIdAsync(int id);
    public Task<bool> AddEventToJoinedAsync(string userId,EventViewModel model);
    public Task RemoveEventFromJoinedAsync(string userId, EventViewModel model);
}
