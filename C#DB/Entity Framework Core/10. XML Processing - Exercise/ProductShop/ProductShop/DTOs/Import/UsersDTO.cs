using System.Xml.Serialization;

namespace ProductShop.DTOs.Import;
[XmlType("User")]
public class UsersDTO
{
    [XmlElement("firstName")]
    public string FirstName { get; set; }
    [XmlElement("lastName")]
    public string LastName { get; set; }
    [XmlElement("age")]
    public int Age { get; set; }
}
//<User>
//        <firstName>Jacquelin</firstName>
//        <lastName>Fransoni</lastName>
//        <age>22</age>
//    </User>