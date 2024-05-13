namespace TestJWT.Data.Models;

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;


public class RolePermission
{
    public string RoleId { get; set; } = string.Empty;
    [ForeignKey("RoleId")]
    public IdentityRole Role { get; set; } = null!;

    public int PermissionId { get; set; }
    [ForeignKey("PermissionId")]
    public Permission Permission { get; set; } = null!;
}

