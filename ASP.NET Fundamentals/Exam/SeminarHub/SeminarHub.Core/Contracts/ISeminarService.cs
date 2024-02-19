using SeminarHub.Core.Models;

namespace SeminarHub.Core.Contracts;

public interface ISeminarService
{
    public Task<ICollection<AllSeminarViewModel>> GetSeminarsAsync();
    public Task<DetailsSeminarViewModel> GetSeminarDetailsAsync(int id);
    public Task<EditSeminarViewModel> GetSeminarForEditAsync(int id);
    public Task UpdateSeminarAsync(EditSeminarViewModel model, DateTime dateTime);
    public Task AddSeminarAsync(AddSeminarForm model, string userId, DateTime dateTime);
    public Task<AllSeminarViewModel> GetSeminarByIdAsync(int id);

    public Task<bool> IsUserSubscribedAsync(string userId, int seminarId);
    public Task<bool> IsUserTheCreatorAsync(string userId, int seminarId);
    public Task SubscribeAsync(string userId, int seminarId);
    public Task<ICollection<AllSeminarViewModel>> GetSubscribedAsync(string userId);
    public Task UnSubscribeAsync(string userId, int seminarId);
    public Task<SeminarDeleteForm> GetSeminarForDeleteAsync(int seminarId);
    public Task DeleteAsync(int seminarId);
}
