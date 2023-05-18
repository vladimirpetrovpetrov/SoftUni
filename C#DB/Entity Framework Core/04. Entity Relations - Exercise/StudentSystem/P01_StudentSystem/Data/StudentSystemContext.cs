using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Models;
using System.Security.Cryptography.X509Certificates;

namespace P01_StudentSystem.Data
{
    public class StudentSystemContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Resource> Resources { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Homework> Homeworks { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-3APE4MB;Database=StudentSystem;Integrated Security=True;TrustServerCertificate=True");
            }



        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>()
                .Property(x => x.Name)
                .HasColumnType("nvarchar(100)");
            modelBuilder.Entity<Student>()
                .Property(x => x.PhoneNumber)
                .HasColumnType("char(10)");
            modelBuilder.Entity<Resource>()
                .Property(x => x.Name)
                .HasColumnType("nvarchar(50)");
            modelBuilder.Entity<Resource>()
                .Property(x => x.Url)
                .HasColumnType("varchar(max)");
            modelBuilder.Entity<Resource>()
                .HasOne(x => x.Course)
                .WithMany(x => x.Resources)
                .HasForeignKey(x => x.CourseId);
            //composite key
            modelBuilder.Entity<StudentCourse>()
                .HasKey(x => new {x.StudentId,x.CourseId});
            modelBuilder.Entity<Homework>()
                .Property(x => x.Content)
                .HasColumnType("varchar(max)");



        }






    }
}
