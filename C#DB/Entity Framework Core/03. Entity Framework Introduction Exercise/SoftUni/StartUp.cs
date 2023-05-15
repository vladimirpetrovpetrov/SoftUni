using SoftUni.Data;
using SoftUni.Models;
using System.Globalization;
using System.Text;

namespace SoftUni;

public class StartUp
{
    static void Main(string[] args)
    {
        SoftUniContext dbContext = new SoftUniContext();
        //Console.WriteLine(GetEmployeesFullInformation(dbContext)); 
        //Console.WriteLine(GetEmployeesWithSalaryOver50000(dbContext)); 
        //Console.WriteLine(GetEmployeesFromResearchAndDevelopment(dbContext));
        //Console.WriteLine(AddNewAddressToEmployee(dbContext));
        //Console.WriteLine(GetEmployeesInPeriod(dbContext));
        //Console.WriteLine(GetAddressesByTown(dbContext));
        //Console.WriteLine(GetEmployee147(dbContext));
        //Console.WriteLine(GetDepartmentsWithMoreThan5Employees(dbContext));
        //Console.WriteLine(GetLatestProjects(dbContext));
        //Console.WriteLine(IncreaseSalaries(dbContext));
        //Console.WriteLine(GetEmployeesByFirstNameStartingWithSa(dbContext));
        //Console.WriteLine(DeleteProjectById(dbContext));
        Console.WriteLine(RemoveTown(dbContext));
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
        var employees = context
            .Employees
            .Where(e => e.Department.Name == "Research and Development")
            .Select(e => new
            {
                e.FirstName,
                e.LastName,
                DepartmentName = e.Department.Name,
                e.Salary
            })
            .OrderBy(e => e.Salary)
            .ThenByDescending(e => e.FirstName)
            .ToList();
        foreach (var e in employees)
        {
            st.AppendLine($"{e.FirstName} {e.LastName} from {e.DepartmentName} - ${e.Salary:f2}");
        }
        return st.ToString().TrimEnd();
    }
    //Problem 6
    public static string AddNewAddressToEmployee(SoftUniContext context)
    {
        StringBuilder st = new StringBuilder();
        Address newAdress = new()
        {
            AddressText = "Vitoshka 15",
            TownId = 4
        };
        Employee? employee = context
            .Employees
            .FirstOrDefault(e => e.LastName == "Nakov");

        employee.Address = newAdress;
        context.SaveChanges();

        var employeeAddresses = context.Employees
            .OrderByDescending(e => e.AddressId)
            .Take(10)
            .Select(e => new { e.Address!.AddressText })
            .ToArray();
        foreach (var item in employeeAddresses)
        {
            st.AppendLine($"{item.AddressText}");
        }

        return st.ToString().TrimEnd();
    }
    //Problem 7
    public static string GetEmployeesInPeriod(SoftUniContext context)
    {
        StringBuilder st = new StringBuilder();


        var employeesWithProjects = context.Employees
            //.Where(e => e.EmployeesProjects.Any(ep => ep.Project.StartDate.Year >= 2001 && ep.Project.StartDate.Year <= 2003))
            .Take(10)
            .Select(e => new
            {
                e.FirstName,
                e.LastName,
                ManagerFirstName = e.Manager!.FirstName,
                ManagerLastName = e.Manager!.LastName,
                Projects = e.EmployeesProjects
                .Where(p => p.Project.StartDate.Year >= 2001 && p.Project.StartDate.Year <= 2003)
                .Select(ep => new
                {
                    ProjectName = ep.Project.Name,
                    StartDate = ep.Project.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture),
                    EndDate = ep.Project.EndDate.HasValue ?
                    ep.Project.EndDate.Value.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture) : "not finished"
                })
                .ToArray()
            })
            .ToArray();
        foreach (var e in employeesWithProjects)
        {
            st.AppendLine($"{e.FirstName} {e.LastName} - Manager: {e.ManagerFirstName} {e.ManagerLastName}");
            foreach (var p in e.Projects)
            {
                st.AppendLine($"--{p.ProjectName} - {p.StartDate} - {p.EndDate}");
            }
        }



        return st.ToString().TrimEnd();
    }
    //Problem 8
    public static string GetAddressesByTown(SoftUniContext context)
    {
        StringBuilder st = new StringBuilder();
        var addresses = context.Addresses
            .OrderByDescending(a => a.Employees.Count)
            .ThenBy(a => a.Town.Name)
            .ThenBy(a => a.AddressText)
            .Take(10)
            .Select(a => new
            {
                a.AddressText,
                TownName = a.Town.Name,
                EmployeeCount = a.Employees.Count
            })
            .ToArray();

        foreach (var a in addresses)
        {
            st.AppendLine($"{a.AddressText}, {a.TownName} - {a.EmployeeCount} employees");
        }


        return st.ToString().TrimEnd();
    }
    //Problem 9
    public static string GetEmployee147(SoftUniContext context)
    {
        StringBuilder st = new StringBuilder();
        var employees = context.Employees
             .Where(e => e.EmployeeId == 147)
             .Select(e => new
             {
                 e.FirstName,
                 e.LastName,
                 e.JobTitle,
                 Projects = e.EmployeesProjects
                 .Select(p => new
                 {
                     ProjectName = p.Project.Name
                 })
                 .OrderBy(p => p.ProjectName)
                 .ToArray()
             }).ToArray();

        foreach (var e in employees)
        {
            st.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
            foreach (var p in e.Projects)
            {
                st.AppendLine($"{p.ProjectName}");
            }
        }
        return st.ToString().TrimEnd();
    }
    //Problem 10
    public static string GetDepartmentsWithMoreThan5Employees(SoftUniContext context)
    {
        StringBuilder st = new StringBuilder();
        var depWithMoreThanFiveEmp = context.Departments
            .Where(d => d.Employees.Count > 5)
            .OrderBy(d => d.Employees.Count)
            .ThenBy(d => d.Name)
            .Select(d => new
            {
                d.Name,
                DepartmentManagerFirstName = d.Manager.FirstName,
                DepartmentManagerLastName = d.Manager.LastName,
                Employees = d.Employees
                .OrderBy(e => e.FirstName)
                .ThenBy(e => e.LastName)
                .ToArray()
            })
            .ToArray();
        foreach (var d in depWithMoreThanFiveEmp)
        {
            st.AppendLine($"{d.Name} - {d.DepartmentManagerFirstName} {d.DepartmentManagerLastName}");
            foreach (var e in d.Employees)
            {
                st.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle}");
            }
        }
        return st.ToString().TrimEnd();
    }
    //Problem 11
    public static string GetLatestProjects(SoftUniContext context)
    {
        StringBuilder st = new StringBuilder();
        var latestProjects = context.Projects
            .OrderByDescending(d => d.StartDate)
            .Take(10)
            .OrderBy(d => d.Name)
            .Select(p => new
            {
                p.Name,
                p.Description,
                StartDate = p.StartDate.ToString("M/d/yyyy h:mm:ss tt", CultureInfo.InvariantCulture)
            })
            .ToArray();
        foreach (var p in latestProjects)
        {
            st.AppendLine($"{p.Name}");
            st.AppendLine($"{p.Description}");
            st.AppendLine($"{p.StartDate}");
        }
        return st.ToString().TrimEnd();
    }
    //Problem 12
    public static string IncreaseSalaries(SoftUniContext context)
    {
        StringBuilder st = new StringBuilder();
        var employeesToIncrease = context
            .Employees
            .Where(e => e.Department.Name == "Engineering" ||
                      e.Department.Name == "Tool Design" ||
                      e.Department.Name == "Marketing" ||
                      e.Department.Name == "Information Services")
            .Select(e => new
            {
                e.FirstName,
                e.LastName,
                Salary = e.Salary * 1.12m
            })
            .OrderBy(e => e.FirstName)
            .ThenBy(e => e.LastName)
            .ToArray();

        foreach (var e in employeesToIncrease)
        {
            st.AppendLine($"{e.FirstName} {e.LastName} (${e.Salary:f2})");
        }
        return st.ToString().TrimEnd();
    }
    //Problem 13
    public static string GetEmployeesByFirstNameStartingWithSa(SoftUniContext context)
    {
        StringBuilder st = new StringBuilder();
        var employeesStartingWithSa = context
            .Employees
            .Where(e => e.FirstName.StartsWith("Sa"))
            .Select(e => new
            {
                e.FirstName,
                e.LastName,
                e.JobTitle,
                e.Salary
            })
            .OrderBy(e => e.FirstName)
            .ThenBy(e => e.LastName)
            .ToArray();
        foreach (var e in employeesStartingWithSa)
        {
            st.AppendLine($"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:f2})");
        }
        return st.ToString().TrimEnd();
    }
    //Problem 14
    public static string DeleteProjectById(SoftUniContext context)
    {
        StringBuilder st = new StringBuilder();
        var projectsToDelete = context.EmployeesProjects
            .Where(e => e.ProjectId == 2);
        context.EmployeesProjects.RemoveRange(projectsToDelete);
        var projectToDelete = context.Projects.Find(2)!;
        context.Projects.Remove(projectToDelete);
        context.SaveChanges();
        var projects = context.Projects
            .Take(10)
            .Select(e => e.Name)
            .ToArray();
        foreach (var project in projects)
        {
            st.AppendLine($"{project}");
        }
        return st.ToString().TrimEnd();
    }
    //Problem 15
    public static string RemoveTown(SoftUniContext context)
    {
        var addressesInSeattle = context.Addresses.Where(x => x.Town.Name == "Seattle");

        int addressesCount = addressesInSeattle.Count();

        foreach (var employee in context.Employees)
        {
            if (addressesInSeattle.Contains(employee.Address))
            {
                employee.Address = null;
            }
        }

        foreach (var address in addressesInSeattle)
        {
            context.Addresses.Remove(address);
        }

        var town = context.Towns.FirstOrDefault(x => x.Name == "Seattle");

        context.Towns.Remove(town);

        context.SaveChanges();

        return $"{addressesCount} addresses in {town.Name} were deleted";
    }
}
