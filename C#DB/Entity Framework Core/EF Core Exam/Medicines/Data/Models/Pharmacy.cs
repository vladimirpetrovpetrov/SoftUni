using System.ComponentModel.DataAnnotations;

namespace Medicines.Data.Models;

public class Pharmacy
{
    [Key]
    public int Id { get; set; }
    [Required]
    [MaxLength(50)]
    public string Name { get; set; }
    [Required]
    [MaxLength(14)]
    public string PhoneNumber { get; set; }
    [Required]
    public bool IsNonStop { get; set; }
    public ICollection<Medicine> Medicines { get; set; } = new HashSet<Medicine>();
}
