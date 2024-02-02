using Microsoft.EntityFrameworkCore;
using ToDoList.Infrastructure.Data.Configuration;
using ToDoList.Infrastructure.Data.Models;

namespace ToDoList.Infrastructure.Data;

public class ToDoListDbContext : DbContext
{
    public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new TaskConfiguration());

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Models.Task> Tasks { get; set; } 




}
