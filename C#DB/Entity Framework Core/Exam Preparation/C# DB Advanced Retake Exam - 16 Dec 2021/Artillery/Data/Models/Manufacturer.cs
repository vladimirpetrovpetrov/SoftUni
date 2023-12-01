using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace Artillery.Data.Models;

public class Manufacturer
{
    [Key]
    public int Id { get; set; }
    [MaxLength(40)]
    [Required]
    public string ManufacturerName { get; set; }
    [MaxLength(100)]
    [Required]
    public string Founded { get; set; }
    public ICollection<Gun> Guns { get; set; } = new HashSet<Gun>();



}
