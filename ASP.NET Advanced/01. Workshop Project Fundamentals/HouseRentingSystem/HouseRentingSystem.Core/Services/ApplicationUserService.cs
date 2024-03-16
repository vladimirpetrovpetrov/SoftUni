using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Data.Models;

namespace HouseRentingSystem.Core.Services;

public class ApplicationUserService : IApplicationUserService
{
    private readonly IRepository repository;

    public ApplicationUserService(IRepository repository)
    {
        this.repository = repository;
    }

    public async Task<string> GetUserNameAsync(string userId)
    {
        var user = await repository
            .GetByIdAsync<ApplicationUser>(userId);
        if (user == null ||
            string.IsNullOrEmpty(user.FirstName) ||
            string.IsNullOrEmpty(user.LastName))
        {
            return null;
        }

        return user.FirstName + " " + user.LastName;
    }
}

