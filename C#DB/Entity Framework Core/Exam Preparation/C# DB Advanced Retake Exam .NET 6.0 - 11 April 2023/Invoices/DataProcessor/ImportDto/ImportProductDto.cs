using Invoices.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Invoices.DataProcessor.ImportDto;

public class ImportProductDto

{
    [Required]
    [MinLength(9)]
    [MaxLength(30)]
    public string Name { get; set; } = null!;
    [Required]
    [Range(5.00, 1000.00)]
    public decimal Price { get; set; }
    [Required]
    [EnumDataType(typeof(CategoryType))]
    public CategoryType CategoryType { get; set; }
    //в самият метод ще направим проверка
    public int[] Clients { get; set; }
}
