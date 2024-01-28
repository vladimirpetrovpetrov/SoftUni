using AspNetCoreIntro2024.Contracts;
using AspNetCoreIntro2024.Models;

namespace AspNetCoreIntro2024.Services;

public class StudentService : IStudentService
{
    public Student GetStudent(int id)
    {
        return Database.GetStudent(id);
    }

    public bool UpdateStudent(Student student)
    {
        return Database.UpdateStudent(student);
    }
}
