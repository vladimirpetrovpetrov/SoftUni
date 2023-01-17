using System;
using System.Linq;

namespace _04._Grades
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            double countTwoThree = 0.0;
            double countThreeFour = 0.0;
            double countFourFive = 0.0;
            double countFiveSix = 0.0;
            double[] grades = new double[studentsCount];

            for (int i = 0; i < studentsCount; i++)
            {

                double grade = double.Parse(Console.ReadLine());
                grades[i] = grade;
                if (grade >= 2 && grade < 3)
                {
                    countTwoThree++;
                }
                else if (grade >= 3 && grade < 4)
                {
                    countThreeFour++;
                }
                else if (grade >= 4 && grade < 5)
                {
                    countFourFive++;
                }
                else
                {
                    countFiveSix++;
                }
            }
            Console.WriteLine($"Top students: {countFiveSix / studentsCount * 100:0.00}%");
            Console.WriteLine($"Between 4.00 and 4.99: {countFourFive / studentsCount * 100:0.00}%");
            Console.WriteLine($"Between 3.00 and 3.99: {countThreeFour / studentsCount * 100:0.00}%");
            Console.WriteLine($"Fail: {countTwoThree / studentsCount * 100:0.00}%");
            Console.WriteLine($"Average: {grades.Average():0.00}");
        }
    }
}
