using Artillery.Data.Models;
using Artillery.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Artillery.DataProcessor.ImportDto;

public class ImportGunDto
{
    [Required]
    public int ManufacturerId { get; set; }
    [Required]
    [Range(100,1350000)]
    public int GunWeight { get; set; }
    [Required]
    [Range(2.00d, 35.00d)]
    public double BarrelLength { get; set; }
    public int? NumberBuild { get; set; }
    [Required]
    [Range(1, 100000)]
    public int Range { get; set; }
    [Required]
    public string GunType { get; set; }
    [Required]
    public int ShellId { get; set; }
    public ImportCountryIdDto[] Countries { get; set; }
}
public class ImportCountryIdDto
{
    public int Id { get; set; }
}
