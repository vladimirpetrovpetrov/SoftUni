using AspNetCoreIntro2024.Models;

namespace AspNetCoreIntro2024.Contracts;

public interface IStudentService
{
    Student GetStudent(int id);
    bool UpdateStudent(Student student);
}
