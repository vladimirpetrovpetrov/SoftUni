using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestJWT.Data.Models;

namespace TestJWT.Data.Configurations
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasData(GeneratesPermissions());
        }

        private List<Permission> GeneratesPermissions()
        {
            List<Permission> permissions = new List<Permission>
            {
                new Permission { Id = 1, Name = "CreateZone" },
                new Permission { Id = 2, Name = "ReadZone" },
                new Permission { Id = 3, Name = "UpdateZone" },
                new Permission { Id = 4, Name = "DeleteZone" }
            };

            return permissions;
        }
    }
}

