

namespace P01_StudentSystem.Models
{
    public class Resource
    {
        public int ResourceId { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public ResourceType ResourceType { get; set; }
        public int CourseId { get; set; }
        //add a navigation property
        public Course Course { get; set; } 
    }
    public enum ResourceType
    {
        Video,
        Presentation,
        Document,
        Other
    }
}
