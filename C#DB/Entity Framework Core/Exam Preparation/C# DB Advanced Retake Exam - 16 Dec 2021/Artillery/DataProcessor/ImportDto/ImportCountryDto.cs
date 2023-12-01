using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Artillery.DataProcessor.ImportDto;
[XmlType("Country")]
public class ImportCountryDto
{
    [Required]
    [MinLength(4)]
    [MaxLength(60)]
    [XmlElement("CountryName")]
    public string CountryName { get; set; }
    [Required]
    [Range(50000,10000000)]
    [XmlElement("ArmySize")]
    public int ArmySize { get; set; }
}
