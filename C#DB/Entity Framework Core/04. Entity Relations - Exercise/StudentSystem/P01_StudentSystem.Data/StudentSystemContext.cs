using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data.Common;
using P01_StudentSystem.Data.Models;

namespace P01_StudentSystem.Data;

public class StudentSystemContext : DbContext
{
    public StudentSystemContext()
    {

    }
    public StudentSystemContext(DbContextOptions options) : base(options)
    {

    }
    //DBSets
    public DbSet<Student> Students { get; set; } = null!;
    public DbSet<Course> Courses { get; set; } = null!;
    public DbSet<Homework> Homeworks { get; set; } = null!;
    public DbSet<Resource> Resources { get; set; } = null!;
    public DbSet<StudentCourse> StudentsCourses { get; set; } = null!;
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(DbConfig.ConnectionString);
        }
        base.OnConfiguring(optionsBuilder);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Student>()
            .Property(s => s.PhoneNumber)
            .IsRequired(false);
        modelBuilder.Entity<Student>()
            .Property(s => s.PhoneNumber)
            .HasColumnType("char(10)");
        modelBuilder.Entity<Student>()
            .Property(s => s.Birthday)
            .IsRequired(false);
        modelBuilder.Entity<Course>()
            .Property(s => s.Description)
            .IsRequired(false);
        modelBuilder.Entity<StudentCourse>()
            .HasKey(sc => new { sc.StudentId, sc.CourseId });
    }
}