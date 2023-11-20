using System.Xml.Serialization;

namespace ProductShop.DTOs.Export;
[XmlType("Users")]
public class UsersAndProductsDTO
{
    [XmlElement("count")]
    public int Count { get; set; }
    [XmlArray("users")]
    public UserHelperDto[] Users { get; set; }

}


[XmlType("User")]
public class UserHelperDto
{
    [XmlElement("firstName")]
    public string FirstName { get; set; }
    [XmlElement("lastName")]
    public string LastName { get; set; }
    [XmlElement("age")]
    public int? Age { get; set; }
    public SoldProductHelper SoldProducts { get; set; }
}
[XmlType("SoldProducts")]
public class SoldProductHelper
{
    [XmlElement("count")]
    public int Count { get; set; }
    [XmlArray("products")]
    public ProductNamePriceDTO[] Products { get; set; }
}

[XmlType("Product")]
public class ProductNamePriceDTO
{
    [XmlElement("name")]
    public string Name { get; set; }
    [XmlElement("price")]
    public decimal Price { get; set; }
}