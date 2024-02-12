using Microsoft.EntityFrameworkCore;
using SoftUniBazar.Core.Contracts;
using SoftUniBazar.Core.Models;
using SoftUniBazar.Data;
using static SoftUniBazar.Infrastructure.Constants.AdDataConstants;

namespace SoftUniBazar.Core.Services;

public class AdService : IAdService
{
    private readonly BazarDbContext context;

    public AdService(BazarDbContext context)
    {
        this.context = context;
    }

    public async Task<IEnumerable<AllAdModel>> GetAllAdAsync()
    {
        return await context.Ads
            .Select(ad => new AllAdModel
            {
                Id = ad.Id,
                Owner = ad.Owner.UserName,
                OwnerId = ad.Owner.Id,
                CreatedOn = ad.CreatedOn.ToString(AdDateFormat),
                Category = ad.Category.Name,
                Description = ad.Description,
                Price = ad.Price.ToString("F2"),
                Name = ad.Name,
                ImageUrl = ad.ImageUrl
            })
            .ToListAsync();
    }
}
