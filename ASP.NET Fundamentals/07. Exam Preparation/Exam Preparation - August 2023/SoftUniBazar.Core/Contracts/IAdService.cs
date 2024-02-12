using SoftUniBazar.Core.Models;

namespace SoftUniBazar.Core.Contracts;

public interface IAdService
{
    public Task<IEnumerable<AllAdModel>> GetAllAdAsync();
    public Task<AllAdModel?> GetAdByIdAsync(int id);
    public Task<bool> CheckIfAlreadyAddedAsync(int adId,string userId);
    public Task AddToCardAsync(string userId, int adId);
    public Task<IEnumerable<AllAdModel>> GetAllAdInCartAsync(string userId);
    public Task RemoveFromCartAsync(string userId, int adId);
}
