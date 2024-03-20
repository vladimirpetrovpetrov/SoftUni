using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Models.User;
using HouseRentingSystem.Infrastructure.Data;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services;

public class ApplicationUserService : IApplicationUserService
{
    private readonly IRepository repository;

    public ApplicationUserService(IRepository repository)
    {
        this.repository = repository;
    }

    public async Task<IEnumerable<UserServiceModel>> All()
    {
        var allUsers = new List<UserServiceModel>();

        var agents = await repository
            .AllReadOnly<Agent>()
            .Select(a => new UserServiceModel
            {
                Email = a.User.Email,
                FullName = (a.User.FirstName + " " + a.User.LastName).Trim() ?? string.Empty,
                PhoneNumber = a.PhoneNumber
            })
            .ToListAsync();

        allUsers.AddRange(agents);

        var users = await repository
            .AllReadOnly<ApplicationUser>()
            .Where(u => !repository.AllReadOnly<Agent>().Any(ag => ag.UserId == u.Id))
            .Select(u => new UserServiceModel
            {
                Email = u.Email,
                FullName = (u.FirstName + " " + u.LastName).Trim() ?? string.Empty,
                PhoneNumber = u.PhoneNumber ?? string.Empty,
            })
            .ToListAsync();

        allUsers.AddRange(users);

        return allUsers;

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

