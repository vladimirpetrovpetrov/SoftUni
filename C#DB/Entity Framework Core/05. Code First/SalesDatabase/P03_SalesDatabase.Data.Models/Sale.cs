using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P03_SalesDatabase.Data.Models;

public class Sale
{
    [Key]
    public int SaleId { get; set; }
    public DateTime Date { get; set; }
    public int ProductId { get; set; }
    [ForeignKey(nameof(ProductId))]
    public virtual Product Product { get; set; } = null!;
    public int CustomerId { get; set; }
    [ForeignKey(nameof(CustomerId))]
    public virtual Customer Customer { get; set; } = null!;
    public int StoreId { get; set; }
    [ForeignKey(nameof(StoreId))]
    public virtual Store Store { get; set; } = null!;
}
