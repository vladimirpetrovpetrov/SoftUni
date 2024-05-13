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
            return users.ToArray();
        }
    }
}
