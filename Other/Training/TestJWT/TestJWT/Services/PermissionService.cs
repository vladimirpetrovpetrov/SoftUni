using Microsoft.EntityFrameworkCore;
using System.Data;
using TestJWT.Contracts;
using TestJWT.Data;
using TestJWT.Data.Models;

namespace TestJWT.Services
{
    public class PermissionService : IPermissionService
    {
        private readonly ApplicationDbContext context;

        public PermissionService(ApplicationDbContext context)
        {
            this.context = context;
        }

        public async Task AddRolePermission(string permissionName, string roleName)
        {
            var permission = await context.Permissions.FirstOrDefaultAsync(p => p.Name.ToLower() == permissionName.ToLower());

            var role = await context.Roles.FirstOrDefaultAsync(r => r.Name.ToLower() == roleName.ToLower());

            if (permission != null && role != null)
            {
                var rolePermission = new RolePermission
                {
                    PermissionId = permission.Id,
                    RoleId = role.Id
                };

                await context.RolesPermissions.AddAsync(rolePermission);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<string>> GetAllPermissionsForRoleAsync(string roleId)
        {
            return await context.RolesPermissions
                .Include(rp => rp.Permission)
                .Include(rp => rp.Role)
                .Where(rp => rp.RoleId == roleId)
                .Select(rp => rp.Permission.Name)
                .ToListAsync();

        }

        public async Task<bool> PermissionExistAsync(string name)
        {
            return await context.Permissions.AnyAsync(x => x.Name.ToLower() == name.ToLower());
        }
    }
}
