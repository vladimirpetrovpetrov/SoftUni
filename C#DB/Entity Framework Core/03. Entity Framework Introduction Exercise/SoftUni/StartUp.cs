using SoftUni.Data;
using System.Text;

namespace SoftUni;

public class StartUp
{
    static void Main(string[] args)
    {
        SoftUniContext dbContext = new SoftUniContext();
        //Console.WriteLine(GetEmployeesFullInformation(dbContext)); 
        //Console.WriteLine(GetEmployeesWithSalaryOver50000(dbContext)); 
        Console.WriteLine(GetEmployeesFromResearchAndDevelopment(dbContext)); 

    }
    //Problem 3
    public static string GetEmployeesFullInformation(SoftUniContext context)
    {
        StringBuilder st = new StringBuilder();
        var employees = context.Employees
                               .OrderBy(e => e.EmployeeId)
                               .Select(e => new
                               {
                                   Name = e.FirstName,
                                   LastName = e.LastName,
                                   MiddleName = e.MiddleName,
                                   JobTitle = e.JobTitle,
                                   Salary = e.Salary,
                               }).ToList();
        foreach (var e in employees)
        {
            st.AppendLine($"{e.Name} {e.LastName} {e.MiddleName} {e.JobTitle} {e.Salary:f2}");
        }
        return st.ToString().TrimEnd();

    }

    //Problem 4
    public static string GetEmployeesWithSalaryOver50000(SoftUniContext context)
    {
        StringBuilder st = new StringBuilder();
        var employees = context.Employees
                               .Where(e => e.Salary > 50000)
                               .OrderBy(e => e.FirstName)
                               .Select(e => new
                               {
                                   Name = e.FirstName,
                                   Salary = e.Salary,
                               })
                               .ToList();
        foreach (var e in employees)
        {
            st.AppendLine($"{e.Name} - {e.Salary:f2}");
        }

        return st.ToString().TrimEnd();
    }

    //Problem 5
    public static string GetEmployeesFromResearchAndDevelopment(SoftUniContext context)
    {
        StringBuilder st = new StringBuilder();
        int depId = context.Departments
                           .FirstOrDefault(d => d.Name == "Research and Development")!.DepartmentId;
        var employees = context
            .Employees
            .Where(e => e.DepartmentId == depId)
            .OrderBy(e => e.Salary)
            .ThenByDescending(e => e.FirstName)
            .ToList();
        foreach (var e in employees)
        {
            st.AppendLine($"{e.FirstName} {e.LastName} from {e.Department.Name} - {e.Salary:f2}");
        }
        return st.ToString().TrimEnd();
    }
}
