using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_StudentSystem.Models
{
    public class Student
    {
        
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string? PhoneNumber { get; set; }
        public DateTime RegistredOn { get; set; }
        public DateTime? Birthday { get; set; }
        public ICollection<StudentCourse> Courses { get; set; }
        public ICollection<Homework> Homeworks { get; set; }





    }
}
