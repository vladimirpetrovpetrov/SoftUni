using System.ComponentModel.DataAnnotations;

namespace Invoices.Data.Models;

public class Client
{
    [Key]
    public int Id { get; set; }
    [Required]
    [StringLength(25)]
    public string Name { get; set; } = null!;
    [Required]
    [StringLength(15)]
    public string NumberVat { get; set; } = null!;
    public virtual ICollection<Invoice> Invoices { get; set; } = new List<Invoice>();
    public virtual ICollection<Address> Addresses { get; set; } = new List<Address>();
    public virtual ICollection<ProductClient> ProductsClients { get; set; } = new List<ProductClient>();
}
