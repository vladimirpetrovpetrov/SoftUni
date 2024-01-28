namespace AspNetCoreIntro2024.Models;

static class Database
{
    private static List<Student> _students = new List<Student>()
    {
        new Student()
        {
            Id=1,
            Name = "John Doe",
            Email = "john@doe.com"
        },
        new Student()
        {
            Id=2,
            Name = "Jane Doe",
            Email = "jane@doe.com"
        }

    };

    public static Student GetStudent(int id)
    {
        return _students.FirstOrDefault(s=>s.Id == id);
    }

    public static bool UpdateStudent(Student student)
    {
        var existingStudent = _students.FirstOrDefault(s=>s.Id==student.Id);
        bool result = false;
        if(existingStudent != null)
        {
            existingStudent.Name = student.Name;
            existingStudent.Email = student.Email;

            result = true;
        }
        return result;
    }

}
