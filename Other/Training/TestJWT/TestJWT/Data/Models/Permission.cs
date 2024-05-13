using System.ComponentModel.DataAnnotations;

namespace TestJWT.Data.Models;

public class Permission
{
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;
        public ICollection<RolePermission> RolePermissions { get; set; }
    
}
