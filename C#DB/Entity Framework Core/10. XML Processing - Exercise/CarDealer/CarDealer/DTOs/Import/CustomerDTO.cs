using CarDealer.Models;
using System.Xml.Serialization;

namespace CarDealer.DTOs.Import;
[XmlType("Customer")]
public class CustomerDTO
{
    [XmlElement("name")]
    public string Name { get; set; }
    [XmlElement("birthDate")]
    public DateTime BirthDay { get; set; }
    [XmlElement("isYoungDriver")]
    public bool isYoungDriver { get; set; }
}
