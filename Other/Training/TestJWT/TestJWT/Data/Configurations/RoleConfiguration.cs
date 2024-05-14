using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace TestJWT.Data.Configurations
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(GeneratesRoles());
        }
        private IdentityRole[] GeneratesRoles()
        {
            ICollection<IdentityRole> roles = new HashSet<IdentityRole>();

            roles.Add(new IdentityRole
            {
                Name = "LevelOne",
                NormalizedName = "LEVELONE",
                Id = "44a539b2-223a-4c1b-9d1c-954ef8d889ff",
                ConcurrencyStamp = "eb8f0668-2e21-4903-81a3-b858513bb59c"

            });

            roles.Add(new IdentityRole()
            {
                Name = "LevelTwo",
                NormalizedName = "LEVELTWO",
                Id = "dc3cf4ec-f90c-4915-b749-4ab01863fdf6",
                ConcurrencyStamp = "1c72eeac-aa45-4a8e-8606-6bbd1dca9a73"
            });

            roles.Add(new IdentityRole()
            {
                Name = "LevelThree",
                NormalizedName = "LEVELTHREE",
                Id = "77af610e-3202-4bea-8d5c-c20c07f7effe",
                ConcurrencyStamp = "3882b86e-4ce3-49e6-83a1-a0294c57a8ff"
            });

            roles.Add(new IdentityRole()
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
                Id = "00535050-d3db-47c6-a29f-64c26430a191",
                ConcurrencyStamp = "af593598-7041-4d59-ae63-418a1b784b75"
            });

            return roles.ToArray();
        }
    }
}
