using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace P03_SalesDatabase.Data.Models;

public class Customer
{
    [Key]
    public int CustomerId { get; set; }
    [StringLength(100)]
    [Unicode(true)]
    public string Name { get; set; } = null!;
    [StringLength(80)]
    [Unicode(false)]
    public string Email { get; set; } = null!;
    public string CreditCardNumber { get; set; } = null!;
    public virtual ICollection<Sale> Sales { get; set;} = new List<Sale>();
}
