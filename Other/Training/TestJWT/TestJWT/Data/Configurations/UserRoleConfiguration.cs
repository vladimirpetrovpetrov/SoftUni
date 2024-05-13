using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace TestJWT.Data.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(GeneratesUsersRoles());
        }

        private IdentityUserRole<string>[] GeneratesUsersRoles()
        {
            ICollection<IdentityUserRole<string>> roles = new HashSet<IdentityUserRole<string>>();

            roles.Add(new IdentityUserRole<string>
            {
                UserId = "f99c5e20-d91e-4a5e-9b73-fdb38b89ffc3",
                RoleId = "44a539b2-223a-4c1b-9d1c-954ef8d889ff"
            });

            return roles.ToArray();
        }
    }
}
