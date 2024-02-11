using Homies.Models;
using Type = Homies.Data.Models.Type;
namespace Homies.Contracts;

public interface IEventService
{
    public Task<IEnumerable<AllEventViewModel>> GetAllEventsAsync();
    public Task<IEnumerable<AllEventViewModel>> GetJoinedEventsAsync(string userId);
    public Task<EventViewModel> GetEventByIdAsync(int id);
    public Task<bool> AddEventToJoinedAsync(string userId,EventViewModel model);
    public Task RemoveEventFromJoinedAsync(string userId, EventViewModel model);
    public Task<List<TypeViewModel>> GetAllEventTypesAsync();
    public Task AddEventAsync(string userId, AddEventViewModel model, DateTime start, DateTime end);
}
