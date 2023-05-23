
namespace FastFood.Data;

using FastFood.Common.DataConfiguration;
using Microsoft.EntityFrameworkCore;
using Models;

public class FastFoodContext : DbContext
{
    public FastFoodContext()
    {

    }

    public FastFoodContext(DbContextOptions<FastFoodContext> options)
    : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(ConnectionConfig.ConnectionString)
                .UseLazyLoadingProxies();
        }
        base.OnConfiguring(optionsBuilder);
    }
    public DbSet<Category> Categories { get; set; } = null!;

    public DbSet<Employee> Employees { get; set; } = null!;
    public DbSet<Item> Items { get; set; } = null!;

    public DbSet<Order> Orders { get; set; } = null!;

    public DbSet<OrderItem> OrderItems { get; set; } = null!;

    public DbSet<Position> Positions { get; set; } = null!;


    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<OrderItem>()
            .HasKey(oi => new { oi.OrderId, oi.ItemId });
        //if there is no key - the key will be name
        builder.Entity<Position>()
            .HasAlternateKey(p => p.Name);
        //if there is no key - the key will be name
        builder.Entity<Item>()
            .HasAlternateKey(i => i.Name);
    }
}
