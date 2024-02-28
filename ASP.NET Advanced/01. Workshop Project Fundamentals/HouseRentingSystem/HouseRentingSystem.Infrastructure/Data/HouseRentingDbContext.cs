using HouseRentingSystem.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HouseRentingSystem.Infrastructure.Data;

public class HouseRentingDbContext : IdentityDbContext
{
    public HouseRentingDbContext(DbContextOptions<HouseRentingDbContext> options)
        : base(options)
    {
    }

    public DbSet<House> Houses { get; set; } = null!;
    public DbSet<Agent> Agents { get; set; } = null!;
    public DbSet<Category> Categories { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<House>()
            .HasOne(h => h.Category)
            .WithMany(c=> c.Houses)
            .HasForeignKey(h => h.CategoryId)
            .OnDelete(DeleteBehavior.Restrict);

        builder.Entity<House>()
            .HasOne(h => h.Agent)
            .WithMany(a => a.Houses)
            .HasForeignKey(h => h.AgentId)
            .OnDelete(DeleteBehavior.Restrict);

        base.OnModelCreating(builder);
    }
}
