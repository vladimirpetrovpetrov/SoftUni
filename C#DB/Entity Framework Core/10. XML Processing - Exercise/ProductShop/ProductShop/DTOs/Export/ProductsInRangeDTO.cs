using System.Xml.Serialization;

namespace ProductShop.DTOs.Export;
[XmlType("Product")]
public class ProductsInRangeDTO
{
    [XmlElement("name")]
    public string Name { get; set; }
    [XmlElement("price")]
    public decimal Price { get; set; }
    [XmlElement("buyer")]
    public string BuyerName { get; set; }
}
