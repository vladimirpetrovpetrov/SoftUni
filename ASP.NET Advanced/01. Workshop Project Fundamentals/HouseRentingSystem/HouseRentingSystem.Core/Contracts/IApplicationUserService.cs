namespace HouseRentingSystem.Core.Contracts;

public interface IApplicationUserService
{
    Task<string> GetUserNameAsync(string userId);
}
