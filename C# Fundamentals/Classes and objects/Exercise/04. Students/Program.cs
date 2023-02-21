using System.Security.Cryptography.X509Certificates;

public class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        int times = int.Parse(Console.ReadLine());
        for (int i = 0; i < times; i++)
        {
            var input = Console.ReadLine().Split(" ").ToList();
            students.Add(new Student(input[0], input[1], double.Parse(input[2])));
        }
        students.OrderByDescending(x => x.Grade).ToList().ForEach(x => x.Print());
    }
}
public class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }

    public Student(string firstName,string lastName,double grade)
    {
        this.LastName = lastName;
        this.FirstName = firstName;
        this.Grade = grade;
    }
    public void Print()
    {
        Console.WriteLine($"{this.FirstName} {this.LastName}: {this.Grade:f2}");
    }
}
