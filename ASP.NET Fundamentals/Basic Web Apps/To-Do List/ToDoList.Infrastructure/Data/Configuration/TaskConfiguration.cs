using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ToDoList.Infrastructure.Data.Configuration;

public class TaskConfiguration : IEntityTypeConfiguration<Models.Task>
{
    private Models.Task[] initialTasks = new Models.Task[]
    {
        new Models.Task() { Id = 1,Title = "Write first task", Description = "To write something interesting.", Deadline = DateTime.Now.AddDays(2), IsCompleted = false},
        new Models.Task() { Id = 2,Title = "Write second task", Description = "To write something interesting.", Deadline = DateTime.Now.AddDays(2), IsCompleted = false},
        new Models.Task() { Id = 3,Title = "Write third task", Description = "To write something interesting.", Deadline = DateTime.Now.AddDays(2), IsCompleted = false}
    };

    public void Configure(EntityTypeBuilder<Models.Task> builder)
    {
        builder.HasData(initialTasks);
    }
}
