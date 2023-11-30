using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Footballers.DataProcessor.ImportDto;
[XmlType("Coach")]
public class ImportCoachDto
{
    [XmlElement("Name")]
    [MinLength(2)]
    [MaxLength(40)]
    [Required]
    public string Name { get; set; }
    [Required]
    [XmlElement("Nationality")]
    public string Nationality { get; set; }
    [XmlArray("Footballers")]
    public ImportFootballerDto[] Footballers { get; set; }



}