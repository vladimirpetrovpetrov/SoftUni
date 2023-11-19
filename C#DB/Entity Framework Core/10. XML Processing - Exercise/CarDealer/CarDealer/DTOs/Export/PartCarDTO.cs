using System.Xml.Serialization;

namespace CarDealer.DTOs.Export;
[XmlType("part")]
public class PartCarDTO
{
    [XmlAttribute("name")]
    public string PartName { get; set; }
    [XmlAttribute("price")]
    public decimal PartPrice { get; set; }

}
