using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Artillery.DataProcessor.ImportDto;
[XmlType("Shell")]
public class ImportShellDto
{
    [Required]
    [XmlElement("ShellWeight")]
    [Range(2.0d , 1680.0d)]
    public double ShellWeight { get; set; }
    [Required]
    [MinLength(4)]
    [MaxLength(30)]
    [XmlElement("Caliber")]
    public string Caliber { get; set; }
}
