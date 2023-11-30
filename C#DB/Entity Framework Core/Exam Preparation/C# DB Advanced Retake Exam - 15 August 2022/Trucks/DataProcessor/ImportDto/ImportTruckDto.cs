using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Trucks.DataProcessor.ImportDto;
[XmlType("Truck")]
public class ImportTruckDto
{
    [XmlElement("RegistrationNumber")]
    [MaxLength(8)]
    [RegularExpression("^[A-Z]{2}\\d{4}[A-Z]{2}$")]
    [Required]
    public string RegistrationNumber { get; set; }
    [XmlElement("VinNumber")]
    [Required]
    [MinLength(17)]
    [MaxLength(17)]
    public string VinNumber { get; set; }
    [XmlElement("TankCapacity")]
    [Range(950, 1420)]
    public int TankCapacity { get; set; }
    [XmlElement("CargoCapacity")]
    [Range(5000, 29000)]
    public int CargoCapacity { get; set; }
    [XmlElement("CategoryType")]
    [Range(0, 3)]
    [Required]
    public int CategoryType { get; set; }
    [XmlElement("MakeType")]
    [Range(0, 4)]
    [Required]
    public int MakeType { get; set; }
}