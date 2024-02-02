using Microsoft.EntityFrameworkCore;
using ToDoList.Infrastructure.Data.Models;

namespace ToDoList.Infrastructure.Data;

public class ToDoListDbContext : DbContext
{
    public ToDoListDbContext(DbContextOptions<ToDoListDbContext> options) : base(options)
    {

    }

    public DbSet<Models.Task> Tasks { get; set; } 




}
