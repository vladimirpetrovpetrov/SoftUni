using System.Xml.Serialization;

namespace ProductShop.DTOs.Import;
[XmlType("Product")]
public class ProductDTO
{
    [XmlElement("name")]
    public string Name { get; set; }
    [XmlElement("price")]
    public decimal Price { get; set; }
    [XmlElement("sellerId")]
    public int SellerId { get; set; }
    [XmlElement("buyerId")]
    public int? BuyerId { get; set; }
}


//<Product>
//        <name>CLARINS Ever Matte SPF 15 - 105 Nude</name>
//        <price>696.06</price>
//        <sellerId>39</sellerId>
//        <buyerId>56</buyerId>
//    </Product>