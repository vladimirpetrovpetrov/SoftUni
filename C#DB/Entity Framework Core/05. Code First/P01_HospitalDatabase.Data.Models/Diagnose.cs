using P01_HospitalDatabase.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_HospitalDatabase.Data.Models;

public class Diagnose
{
    [Key]
    public int DiagnoseId { get; set; }
    [Required]
    [MaxLength(ValidationConstants.DiagnoseNameMaxLength)]
    public string Name { get; set; } = null!;
    [Required]
    [MaxLength(ValidationConstants.DiagnoseCommentsMaxLength)]
    public string Comments { get; set; } = null!;
    [ForeignKey(nameof(Patient))]
    public int PatientId { get; set; }
    public virtual Patient Patient { get; set; } = null!;

}
