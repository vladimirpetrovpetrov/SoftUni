using Invoices.Data.Models;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Invoices.DataProcessor.ImportDto;

[XmlType("Client")]
public class ImportClientDto
{
    [XmlElement("Name")]
    [Required]
    [MinLength(10)]
    [MaxLength(25)]
    public string Name { get; set; }
    [XmlElement("NumberVat")]
    [Required]
    [MinLength(10)]
    [MaxLength(15)]
    public string NumberVat { get; set; }
    [XmlArray("Addresses")]
    public ImportAddressDto[] Addresses { get; set; }


}