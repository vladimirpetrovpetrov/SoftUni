using Invoices.Data.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace Invoices.DataProcessor.ImportDto;

public class ImportInvoiceDto
{
    [Required]
    [Range(1000000000, 1500000000)]
    public int Number { get; set; }
    [Required]
    public DateTime IssueDate { get; set; }
    [Required]
    public DateTime DueDate { get; set; }
    [Required]
    public decimal Amount { get; set; }
    [Required]
    [EnumDataType(typeof(CurrencyType))]
    public CurrencyType CurrencyType { get; set; }
    [Required]
    public int ClientId { get; set; }
}
