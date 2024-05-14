
namespace TestJWT.Contracts;

public interface IPermissionService
{
    Task AddRolePermission(string permissionName, string roleName);
    Task<List<string>> GetAllPermissionsForRoleAsync(string roleId);
    Task<bool> PermissionExistAsync(string name);
}
