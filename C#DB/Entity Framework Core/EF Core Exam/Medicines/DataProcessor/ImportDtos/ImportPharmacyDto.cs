using Medicines.Data.Models.Enums;
using Medicines.Data.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Medicines.DataProcessor.ImportDtos;
[XmlType("Pharmacy")]
public class ImportPharmacyDto
{
    [Required]
    [XmlAttribute("non-stop")]
    public string IsNonStop { get; set; }
    [XmlElement("Name")]
    [Required]
    [MinLength(2)]
    [MaxLength(50)]
    public string Name { get; set; }
    [XmlElement("PhoneNumber")]
    [MinLength(14)]
    [MaxLength(14)]
    [Required]
    [RegularExpression(@"^\(\d{3}\) \d{3}-\d{4}$", ErrorMessage = "Invalid phone number format. It should be in the format (123) 456-7890.")]
    public string PhoneNumber { get; set; }
    [XmlArray("Medicines")]
    public ImportMedicineDto[] Medicines { get; set; }
}
[XmlType("Medicine")]
public class ImportMedicineDto
{
    [XmlAttribute("category")]
    [Required]
    [Range(0,4)]
    public int Category { get; set; }
    [XmlElement("Name")]
    [Required]
    [MinLength(3)]
    [MaxLength(150)]
    public string Name { get; set; }
    [XmlElement("Price")]
    [Required]
    [Range(0.01,1000.0)]
    public decimal Price { get; set; }
    [XmlElement("ProductionDate")]
    [Required]
    public string ProductionDate { get; set; }
    [XmlElement("ExpiryDate")]
    [Required]
    public string ExpiryDate { get; set; }
    [XmlElement("Producer")]
    [MinLength(3)]
    [MaxLength(100)]
    [Required]
    public string Producer { get; set; }
   
}
