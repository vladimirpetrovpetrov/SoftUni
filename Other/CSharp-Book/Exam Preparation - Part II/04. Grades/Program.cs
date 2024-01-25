using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Grades
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int studentCount = int.Parse(Console.ReadLine());
            double veryGood = 0.0; //5.00+
            double good = 0.0; //4.00 - 4.99
            double medium = 0.0; //3.00 - 3.99
            double fail = 0.0; //2.00 - 2.99
            List<double> grades = new List<double>();
            int oldStudentCount = studentCount;
            while (studentCount > 0)
            {
                double grade = double.Parse(Console.ReadLine());
                grades.Add(grade);
                if (grade >= 2.00 && grade < 3.00)
                {
                    fail++;
                }
                else if (grade >= 3.00 && grade < 4.00)
                {
                    medium++;
                }
                else if (grade >= 4.00 && grade < 5.00)
                {
                    good++;
                }
                else if (grade >= 5.00 && grade <= 6.00)
                {
                    veryGood++;
                }
                studentCount--;
            }
            double veryGoodP = veryGood / oldStudentCount * 100;
            double goodP = good / oldStudentCount * 100;
            double mediumP = medium / oldStudentCount * 100;
            double failP = fail / oldStudentCount * 100;
            Console.WriteLine($"Top students: {veryGoodP:0.00}%");
            Console.WriteLine($"Between 4.00 and 4.99: {goodP:0.00}%");
            Console.WriteLine($"Between 3.00 and 3.99: {mediumP:0.00}%");
            Console.WriteLine($"Fail: {failP:0.00}%");
            Console.WriteLine($"Average: {grades.Average():0.00}");
        }
    }
}
