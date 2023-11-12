using System.ComponentModel.DataAnnotations;

namespace P03_SalesDatabase.Data.Models;

public class Product
{
    [Key]
    public int ProductId { get; set; }
    [Required]
    [StringLength(50)]
    public string Name { get; set; } = null!;
    public double Quantity { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; } = null!;

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();

}
