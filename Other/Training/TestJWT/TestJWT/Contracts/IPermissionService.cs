
namespace TestJWT.Contracts;

public interface IPermissionService
{
    Task AddRolePermission(string permissionName, string roleName);
    Task<Dictionary<string, bool>> GetAllPermissionsForRoleAsync(string roleId);
    Task<bool> PermissionExistAsync(string name);
}
