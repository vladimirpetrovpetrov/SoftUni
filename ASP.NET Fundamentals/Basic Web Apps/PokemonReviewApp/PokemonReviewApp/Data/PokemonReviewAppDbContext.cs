using Microsoft.EntityFrameworkCore;
using PokemonReviewApp.Models;
using System.Reflection.Emit;

namespace PokemonReviewApp.Data
{
    public class PokemonReviewAppDbContext : DbContext
    {
        public PokemonReviewAppDbContext(DbContextOptions<PokemonReviewAppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Owner> Owners { get; set; }
        public DbSet<Pokemon> Pokemons { get; set; }
        public DbSet<PokemonCategory> PokemonsCategories { get; set; }
        public DbSet<PokemonOwner> PokemonsOwners { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Reviewer> Reviewers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PokemonCategory>()
                    .HasKey(pc => new { pc.PokemonId, pc.CategoryId });
            modelBuilder.Entity<PokemonCategory>()
                    .HasOne(p => p.Pokemon)
                    .WithMany(pc => pc.PokemonsCategories)
                    .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonCategory>()
                    .HasOne(p => p.Category)
                    .WithMany(pc => pc.PokemonsCategories)
                    .HasForeignKey(c => c.CategoryId);

            modelBuilder.Entity<PokemonOwner>()
                    .HasKey(po => new { po.PokemonId, po.OwnerId });
            modelBuilder.Entity<PokemonOwner>()
                    .HasOne(p => p.Pokemon)
                    .WithMany(pc => pc.PokemonsOwners)
                    .HasForeignKey(p => p.PokemonId);
            modelBuilder.Entity<PokemonOwner>()
                    .HasOne(p => p.Owner)
                    .WithMany(pc => pc.PokemonsOwners)
                    .HasForeignKey(c => c.OwnerId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
