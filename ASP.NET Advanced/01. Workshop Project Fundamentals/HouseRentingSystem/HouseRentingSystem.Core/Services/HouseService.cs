using HouseRentingSystem.Core.Contracts;
using HouseRentingSystem.Core.Enums;
using HouseRentingSystem.Core.Models.Home;
using HouseRentingSystem.Core.Models.House;
using HouseRentingSystem.Infrastructure.Data.Common;
using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Core.Services;

public class HouseService : IHouseService
{
    private readonly IRepository repository;

    public HouseService(IRepository repository)
    {
        this.repository = repository;
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
                .ThenByDescending(h=>h.Id),
            _ => housesToShow
                .OrderByDescending(h=>h.Id)
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
}
