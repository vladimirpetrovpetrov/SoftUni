using HouseRentingSystem.Core.Models.User;

namespace HouseRentingSystem.Core.Contracts;

public interface IApplicationUserService
{
    Task<string> GetUserNameAsync(string userId);
    Task<IEnumerable<UserServiceModel>> All();
}
