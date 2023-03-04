using System.Text;

namespace _01._Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employee> listE = new List<Employee>();
            List<Dep> listD = new List<Dep>();
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);
                var employeName = input[0];
                var employeSalary = double.Parse(input[1]);
                var employeDepartment = input[2];

                
                Employee employe = new Employee(employeName,employeSalary, employeDepartment);
                listE.Add(employe);

                
                bool dExist = listD.Any(x => x.Name == employeDepartment);
                if (!dExist)
                {
                    Dep department = new Dep(employeDepartment);
                    department.Members.Add(employe);
                    department.Salaries.Add(employe.Salary);
                    department.CalcSal();
                    listD.Add(department);
                }
                else
                {
                    listD.First(x=>x.Name == employeDepartment).Members.Add(employe);
                    listD.First(x => x.Name == employeDepartment).Salaries.Add(employe.Salary);
                    listD.First(x => x.Name == employeDepartment).CalcSal();
                }
            }

            
            var biggestSalary = listD.Max(x => x.AvrgSalary);
            var depWithBiggestSalary = string.Empty;
            foreach (var item in listD)
            {
                if(item.AvrgSalary == biggestSalary)
                {
                    Console.WriteLine(item);
                    break;
                }
            }
        }
    }
    public class Employee
    {
        public Employee(string name, double salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }

    }
    public class Dep
    {
        public Dep(string name)
        {
            Name = name;
        }

        
        public List<Employee> Members { get; set; } = new List<Employee>();
        public string Name { get; set; }
        public List<double> Salaries { get; set; } = new List<double>();
        public double AvrgSalary { get; set; } 
        public void CalcSal()
        {
            this.AvrgSalary = Salaries.Average();
        }
        public override string ToString()
        {
            StringBuilder st = new StringBuilder();
            st.AppendLine($"Highest Average Salary: {Name}");
            this.Members = Members.OrderByDescending(x=>x.Salary).ToList();
            for (int i = 0; i < Members.Count; i++)
            {
                st.AppendLine($"{Members[i].Name} {Members[i].Salary:F2}");
            }

            return st.ToString().TrimEnd('\n');
        }
    }
}