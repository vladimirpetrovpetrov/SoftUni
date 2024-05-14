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

            roles.Add(new IdentityUserRole<string>
            {
                UserId = "ef210b4c-f90b-47b0-8750-aeb9aa036264",
                RoleId = "00535050-d3db-47c6-a29f-64c26430a191"
            });

            return roles.ToArray();
        }
    }
}
