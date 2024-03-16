using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Enums;
using HouseRentingSystem.Core.Models.Home;
using HouseRentingSystem.Core.Models.House;
using HouseRentingSystem.Core.Models.Statistics;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services;

public class HouseService : IHouseService
{
    private readonly IRepository repository;
    private readonly IApplicationUserService applicationUserService;

    public HouseService(IRepository repository, IApplicationUserService applicationUserService)
    {
        this.repository = repository;
        this.applicationUserService = applicationUserService;
    }

    public async Task<HouseQueryServiceModel> AllAsync(
        string? category = null,
        string? searchTerm = null,
        HouseSorting sorting = HouseSorting.Newest,
        int currentPage = 1,
        int housesPerPage = 1)
    {
        var housesToShow = repository.AllReadOnly<House>();

        if (category != null)
        {
            housesToShow = housesToShow
                .Where(h => h.Category.Name == category);
        }

        if (searchTerm != null)
        {
            string normalizedSearchTerm = searchTerm.ToLower();
            housesToShow = housesToShow
                .Where(h => (
                h.Title.ToLower().Contains(normalizedSearchTerm)) ||
                h.Address.ToLower().Contains(normalizedSearchTerm) ||
                h.Description.ToLower().Contains(normalizedSearchTerm)
                );
        }

        housesToShow = sorting switch
        {
            HouseSorting.Price => housesToShow
                .OrderBy(h => h.PricePerMonth),
            HouseSorting.NotRented => housesToShow
                .OrderBy(h => h.RenterId != null)
                .ThenByDescending(h => h.Id),
            _ => housesToShow
                .OrderByDescending(h => h.Id)
        };

        var houses = await housesToShow
            .Skip((currentPage - 1) * housesPerPage)
            .Take(housesPerPage)
            .ProjectToHouseServiceModel()
            .ToListAsync();

        int totalHouses = await housesToShow.CountAsync();

        return new HouseQueryServiceModel()
        {
            Houses = houses,
            TotalHousesCount = totalHouses
        };

    }

    public async Task<IEnumerable<HouseCategoryServiceModel>> AllCategoriesAsync()
    {
        return await repository
            .AllReadOnly<Category>()
            .Select(c => new HouseCategoryServiceModel()
            {
                Id = c.Id,
                Name = c.Name,
            })
            .ToListAsync();
    }

    public async Task<IEnumerable<string>> AllCategoriesNamesAsync()
    {
        return await repository.AllReadOnly<Category>()
            .Select(c => c.Name)
            .Distinct()
            .ToListAsync();
    }

    public async Task<IEnumerable<HouseServiceModel>> AllHousesByAgentIdAsync(int agentId)
    {
        return await repository
            .AllReadOnly<House>()
            .Where(h => h.AgentId == agentId)
            .ProjectToHouseServiceModel()
            .ToListAsync();
    }

    public async Task<IEnumerable<HouseServiceModel>> AllHousesByUserIdAsync(string userId)
    {
        return await repository
            .AllReadOnly<House>()
            .Where(h => h.RenterId == userId)
            .ProjectToHouseServiceModel()
            .ToListAsync();
    }

    public async Task<bool> CategoryExistsAsync(int categoryId)
    {
        return await repository
            .AllReadOnly<Category>()
            .AnyAsync(c => c.Id == categoryId);
    }

    public async Task<int> CreateAsync(HouseFormModel model, int agentId)
    {
        var house = new House()
        {
            Address = model.Address,
            AgentId = agentId,
            CategoryId = model.CategoryId,
            Description = model.Description,
            ImageUrl = model.ImageUrl,
            PricePerMonth = model.PricePerMonth,
            Title = model.Title
        };

        await repository.AddAsync(house);
        await repository.SaveChangesAsync();

        return house.Id;
    }

    public async Task DeleteAsync(int houseId)
    {
        if (await ExistsAsync(houseId))
        {
            var houseToDelete = await repository
                .GetByIdAsync<House>(houseId);
            repository.Delete(houseToDelete!);
        }
        await repository.SaveChangesAsync();
    }

    public async Task EditAsync(int houseId, HouseFormModel model)
    {
        var house = await repository.GetByIdAsync<House>(houseId);

        if (house != null)
        {
            house.Address = model.Address;
            house.CategoryId = model.CategoryId;
            house.Description = model.Description;
            house.ImageUrl = model.ImageUrl;
            house.PricePerMonth = model.PricePerMonth;
            house.Title = model.Title;
        }

        await repository.SaveChangesAsync();
    }

    public async Task<bool> ExistsAsync(int id)
    {
        return await repository
            .AllReadOnly<House>()
            .AnyAsync(h => h.Id == id);
    }

    public async Task<HouseFormModel?> GetHouseForModelByIdAsync(int id)
    {
        var house = await repository
            .AllReadOnly<House>()
            .Where(h => h.Id == id)
            .Select(h => new HouseFormModel
            {
                Address = h.Address,
                CategoryId = h.CategoryId,
                Description = h.Description,
                ImageUrl = h.ImageUrl,
                PricePerMonth = h.PricePerMonth,
                Title = h.Title
            })
            .FirstOrDefaultAsync();

        if (house != null)
        {
            house.Categories = await AllCategoriesAsync();
        }

        return house;
    }

    public async Task<StatisticsServiceModel> GetStatisticsAsync()
    {
        return new StatisticsServiceModel()
        {
            TotalHouses = await repository
            .AllReadOnly<House>()
            .CountAsync(),
            TotalRents = await repository
            .AllReadOnly<House>()
            .Where(h => h.RenterId != null)
            .CountAsync()
        };
    }

    public async Task<bool> HasAgentWithIdAsync(int houseId, string userId)
    {
        return await repository
            .AllReadOnly<House>()
            .AnyAsync(h => h.Id == houseId && h.Agent.UserId == userId);
    }

    public async Task<HouseDetailsServiceModel> HouseDetailsByIdAsync(int id)
    {
        var house = await repository
       .AllReadOnly<House>()
       .Include(h=>h.Agent)
       .Where(h => h.Id == id)
       .FirstAsync();

        var agentFullName = await applicationUserService.GetUserNameAsync(house.Agent.UserId);



        return await repository
            .AllReadOnly<House>()
            .Where(h => h.Id == id)
            .Select(h => new HouseDetailsServiceModel
            {
                Id = h.Id,
                Address = h.Address,
                Agent = new Models.Agent.AgentServiceModel()
                {
                    FullName = agentFullName,
                    Email = h.Agent.User.Email,
                    PhoneNumber = h.Agent.PhoneNumber
                },
                Category = h.Category.Name,
                Description = h.Description,
                ImageUrl = h.ImageUrl,
                IsRented = h.RenterId != null,
                PricePerMonth = h.PricePerMonth,
                Title = h.Title
            })
            .FirstAsync();
    }

    public async Task<bool> IsRentedAsync(int houseId)
    {
        var house = await repository
            .GetByIdAsync<House>(houseId);

        return house!.RenterId == null ? false : true;
    }

    public async Task<bool> IsRentedByUserWithIdAsync(int houseId, string userId)
    {
        var house = await repository
            .GetByIdAsync<House>(houseId);
        if (house == null)
        {
            return false;
        }

        return house!.RenterId == userId;
    }

    public async Task<IEnumerable<HouseIndexServiceModel>> LastThreeHousesAsync()
    {
        return await repository
            .AllReadOnly<House>()
            .OrderByDescending(x => x.Id)
            .Take(3)
            .Select(h => new HouseIndexServiceModel
            {
                Id = h.Id,
                ImageUrl = h.ImageUrl,
                Title = h.Title,
            })
            .ToListAsync();
    }

    public async Task LeaveAsync(int houseId)
    {
        var house = await repository
            .GetByIdAsync<House>(houseId);
        if (house != null)
        {
            house.RenterId = null;
        }
        await repository.SaveChangesAsync();

    }

    public async Task RentAsync(int houseId, string userId)
    {
        var house = await repository
           .GetByIdAsync<House>(houseId);

        house!.RenterId = userId;
        await repository.SaveChangesAsync();
    }
}
