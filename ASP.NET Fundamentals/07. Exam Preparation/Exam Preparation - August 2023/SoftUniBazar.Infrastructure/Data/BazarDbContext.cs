using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SoftUniBazar.Infrastructure.Data.Models;

namespace SoftUniBazar.Data;

public class BazarDbContext : IdentityDbContext
{
    public BazarDbContext(DbContextOptions<BazarDbContext> options)
        : base(options)
    {
    }

    public DbSet<Ad> Ads { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<AdBuyer> AdsBuyers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdBuyer>()
            .HasKey(ab => new { ab.BuyerId, ab.AdId });

        modelBuilder.Entity<Ad>()
            .HasOne(a => a.Owner)
            .WithMany()
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.Entity<Ad>()
                .Property(p => p.Price)
                .HasPrecision(18, 2);

        modelBuilder
            .Entity<Category>()
            .HasData(new Category()
            {
                Id = 1,
                Name = "Books"
            },
            new Category()
            {
                Id = 2,
                Name = "Cars"
            },
            new Category()
            {
                Id = 3,
                Name = "Clothes"
            },
            new Category()
            {
                Id = 4,
                Name = "Home"
            },
            new Category()
            {
                Id = 5,
                Name = "Technology"
            });

        base.OnModelCreating(modelBuilder);
    }
}