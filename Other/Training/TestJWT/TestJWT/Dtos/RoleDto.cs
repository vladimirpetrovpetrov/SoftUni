namespace TestJWT.Dtos;

public class RoleDto
{
    public string RoleName { get; set; } = string.Empty;
    public string[] Permissions { get; set; }
}
