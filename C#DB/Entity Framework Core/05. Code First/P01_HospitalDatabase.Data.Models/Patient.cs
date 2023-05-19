using P01_HospitalDatabase.Data.Common;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace P01_HospitalDatabase.Data.Models;

public class Patient
{
    public Patient()
    {
        this.Visitations = new HashSet<Visitation>();
        this.Prescriptions = new HashSet<PatientMedicament>();
        this.Diagnoses = new HashSet<Diagnose>();
    }
    [Key]
    public int PatientId { get; set; }
    [Required]
    [MaxLength(ValidationConstants.PatientNameMaxLength)]
    public string FirstName { get; set; } = null!;
    [Required]
    [MaxLength(ValidationConstants.PatientNameMaxLength)]
    public string LastName { get; set; } = null!;
    [Required]
    [MaxLength(ValidationConstants.PatientAddressMaxLength)]
    public string Address { get; set; } = null!;
    [Required]
    [Column(TypeName = "varchar(80)")]
    public string Email { get; set; } = null!;
    public bool HasInsurance { get; set; }
    public virtual ICollection<Visitation> Visitations { get; set; }
    public virtual ICollection<PatientMedicament> Prescriptions { get; set; }
    public virtual ICollection<Diagnose> Diagnoses { get; set; }


}