using System.Xml.Serialization;

namespace CarDealer.DTOs.Import;
[XmlType("Supplier")]
public class SupplierDTO
{
    [XmlElement("name")]
    public string Name { get; set; }
    [XmlElement("isImporter")]
    public bool IsImporter { get; set; }
}
