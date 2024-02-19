namespace SeminarHub.Core.Models;
using static SeminarHub.Infrastructure.Data.DataConstants.SeminarDataConstants;

public class AllSeminarViewModel
{
    public AllSeminarViewModel(int id, string topic, string lecturer, string organizer, DateTime dateAndTime, string category)
    {
        Id = id;
        Topic = topic;
        Lecturer = lecturer;
        Organizer = organizer;
        DateAndTime = dateAndTime.ToString(RequiredDateFormat);
        Category = category;
    }

    public int Id { get; set; }
    public string Topic { get; set; }
    public string Lecturer { get; set; }
    public string Organizer { get; set; }
    public string DateAndTime { get; set; }
    public string Category { get; set; }
}
