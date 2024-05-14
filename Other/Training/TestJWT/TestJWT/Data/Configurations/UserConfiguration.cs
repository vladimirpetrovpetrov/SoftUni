using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TestJWT.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> builder)
        {
            builder.HasData(GenerateUsers());
        }

        private IdentityUser[] GenerateUsers()
        {
            ICollection<IdentityUser> users = new HashSet<IdentityUser>();

            var hasher = new PasswordHasher<IdentityUser>();

            var userOne = new IdentityUser()
            {
                Id = "f99c5e20-d91e-4a5e-9b73-fdb38b89ffc3",
                UserName = "levelOne@gmail.com",
                NormalizedUserName = "LEVELONE@GMAIL.COM",
                Email = "levelOne@gmail.com",
                NormalizedEmail = "LEVELONE@GMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
            };
            userOne.PasswordHash = hasher.HashPassword(userOne, "password");
            users.Add(userOne);

            var userTwo = new IdentityUser()
            {
                Id = "ef210b4c-f90b-47b0-8750-aeb9aa036264",
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                EmailConfirmed = true,
                LockoutEnabled = false,
            };

            userTwo.PasswordHash = hasher.HashPassword(userTwo, "admin");
            users.Add(userTwo);
            return users.ToArray();
        }
    }
}
