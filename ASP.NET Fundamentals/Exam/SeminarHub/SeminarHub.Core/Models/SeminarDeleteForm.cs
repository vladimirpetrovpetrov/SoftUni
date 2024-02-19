namespace SeminarHub.Core.Models;

public class SeminarDeleteForm
{
    public int Id { get; set; }
    public string Topic { get; set; } = string.Empty;
    public DateTime DateAndTime { get; set; }
}
