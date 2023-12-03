using Medicines.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Medicines.DataProcessor.ImportDtos;

public class ImportPatientDto
{
    [Required]
    [MinLength(5)]
    [MaxLength(100)]
    public string FullName { get; set; }
    [Required]
    [EnumDataType(typeof(AgeGroup))]
    public AgeGroup AgeGroup { get; set; }
    [Required]
    [EnumDataType(typeof(Gender))]
    public Gender Gender { get; set; }
    public int[] Medicines { get; set; }
}
