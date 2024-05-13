using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestJWT.Data.Models;

namespace TestJWT.Data.Configurations
{
    public class RolesPermissionsConfiguration : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.HasData(GenerateRolesPermissions());
        }

        private List<RolePermission> GenerateRolesPermissions()
        {
            var rolePermissions = new List<RolePermission>
            {
                new RolePermission { RoleId = "44a539b2-223a-4c1b-9d1c-954ef8d889ff", PermissionId = 2}, // LevelOne with ReadZone
                new RolePermission { RoleId = "dc3cf4ec-f90c-4915-b749-4ab01863fdf6", PermissionId = 1}, // LevelTwo with CreateZone
                new RolePermission { RoleId = "dc3cf4ec-f90c-4915-b749-4ab01863fdf6", PermissionId = 2 }, // LevelTwo with ReadZone
                new RolePermission { RoleId = "77af610e-3202-4bea-8d5c-c20c07f7effe", PermissionId = 1 }, // LevelThree with CreateZone
                new RolePermission { RoleId = "77af610e-3202-4bea-8d5c-c20c07f7effe", PermissionId = 2 }, // LevelThree with ReadZone
                new RolePermission { RoleId = "77af610e-3202-4bea-8d5c-c20c07f7effe", PermissionId = 3 }, // LevelThree with UpdateZone
                new RolePermission { RoleId = "77af610e-3202-4bea-8d5c-c20c07f7effe", PermissionId = 4 }  // LevelThree with DeleteZone
            };

            return rolePermissions;
        }
    }
}
