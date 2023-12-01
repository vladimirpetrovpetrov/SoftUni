using System.ComponentModel.DataAnnotations;

namespace Artillery.Data.Models;

public class Shell
{
    [Key]
    public int Id { get; set; }
    [Required]
    public double ShellWeight { get; set; }
    [Required]
    [MaxLength(30)]
    public string Caliber { get; set; }
    public ICollection<Gun> Guns { get; set; } = new HashSet<Gun>();

}
