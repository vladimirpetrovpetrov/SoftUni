using Boardgames.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;
using System.Xml.Serialization;

namespace Boardgames.DataProcessor.ImportDto;
[XmlType("Boardgame")]
public class ImportBoardgameDto
{
    [XmlElement("Name")]
    [Required]
    [MinLength(10)]
    [MaxLength(20)]
    public string Name { get; set; }
    [XmlElement("Rating")]
    [Required]
    [Range(1.00,10.00)]
    public double Rating { get; set; }
    [Required]
    [XmlElement("YearPublished")]
    [Range(2018,2023)]
    public int YearPublished { get; set; }
    [Required]
    [XmlElement("CategoryType")]
    public int CategoryType { get; set; }
    [Required]
    [XmlElement("Mechanics")]
    public string Mechanics { get; set; }



}