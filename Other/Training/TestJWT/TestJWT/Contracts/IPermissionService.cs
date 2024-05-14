namespace TestJWT.Contracts;

public interface IPermissionService
{
    Task AddRolePermission(string permissionName, string roleName);
    Task<bool> PermissionExistAsync(string name);
}
