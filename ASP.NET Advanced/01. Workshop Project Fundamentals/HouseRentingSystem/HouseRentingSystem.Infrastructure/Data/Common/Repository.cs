
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Infrastructure.Data.Common;

public class Repository : IRepository
{
    private readonly DbContext context;

    public Repository(HouseRentingDbContext context)
    {
        this.context = context;
    }
    private DbSet<T> DbSet<T>() where T : class
    {
        return context.Set<T>();
    }

    public IQueryable<T> All<T>() where T : class
    {
        return DbSet<T>();
    }
    public IQueryable<T> AllReadOnly<T>() where T : class
    {
        return DbSet<T>()
            .AsNoTracking();
    }
}
