using System.Xml.Serialization;

namespace ProductShop.DTOs.Import;

[XmlType("CategoryProduct")]
public class CatProDTO
{
    [XmlElement("CategoryId")]
    public int CategoryId { get; set; }
    [XmlElement("ProductId")]
    public int ProductId { get; set; }
    //Check if the xml ids could be null

}