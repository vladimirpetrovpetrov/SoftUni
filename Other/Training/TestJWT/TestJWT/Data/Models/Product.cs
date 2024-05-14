using System.ComponentModel.DataAnnotations;

namespace TestJWT.Data.Models;

public class Product
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

    [Required]
    public int Quantity { get; set; }

    [Required]
    public bool IsFinished { get; set; }

    [Required]
    public bool InProgress { get; set; }

    [Required]
    public DateTime DateAdded { get; set; }

}
