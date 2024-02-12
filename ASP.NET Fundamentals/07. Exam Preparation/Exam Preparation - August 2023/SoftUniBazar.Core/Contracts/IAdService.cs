using SoftUniBazar.Core.Models;

namespace SoftUniBazar.Core.Contracts;

public interface IAdService
{
    public Task<IEnumerable<AllAdModel>> GetAllAdAsync();   
}
