namespace FastFood.Models;

using FastFood.Common.EntityConfiguration;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

public class Position
{
    public Position()
    {
        this.Employees = new HashSet<Employee>();
    }
    [Key]
    public int Id { get; set; }

    [StringLength(ValidationConstants.PositionNameMaxLength, MinimumLength = 3)]
    public string Name { get; set; } = null!;

    public virtual ICollection<Employee> Employees { get; set; }
}