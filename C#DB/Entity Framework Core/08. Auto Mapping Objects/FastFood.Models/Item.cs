namespace FastFood.Models;

using FastFood.Common;
using FastFood.Common.EntityConfiguration;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

public class Item
{
    public Item()
    {
        this.Id = Guid.NewGuid().ToString();
        this.OrderItems = new HashSet<OrderItem>();
    }
    [Key]
    public string Id { get; set; }

    [StringLength(ValidationConstants.ItemNameMaxLength, MinimumLength = 3)]
    public string? Name { get; set; }
    [ForeignKey(nameof(Category))]
    public int CategoryId { get; set; }

    public virtual Category Category { get; set; } = null!;

    [Range(typeof(decimal), "0.01", "79228162514264337593543950335")]
    public decimal Price { get; set; }

    public virtual ICollection<OrderItem> OrderItems { get; set; }
}