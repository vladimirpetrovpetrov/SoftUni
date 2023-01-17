using System;
using System.Diagnostics.CodeAnalysis;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var studentName = Console.ReadLine();
            var passedClasses = 0;
            var fs = 0;
            double sum = 0;

            while (fs < 2 && passedClasses < 12)
            {
                var grade = double.Parse(Console.ReadLine());
                if (grade <= 3)
                {
                    fs++;
                }
                if (fs >= 2)
                {
                    Console.WriteLine($"{studentName} has been excluded at {passedClasses} grade");
                }
                sum += grade;
                passedClasses++;
            }
            var average = sum / 12;
            if (fs < 2)
            {
                Console.WriteLine($"{studentName} graduated. Average grade: {average:0.00}");
            }
        }
    }
}
