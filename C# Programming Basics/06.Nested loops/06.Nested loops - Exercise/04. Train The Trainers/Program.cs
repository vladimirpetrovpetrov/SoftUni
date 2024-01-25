using System;

namespace _04._Train_The_Trainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numberOfJury = int.Parse(Console.ReadLine());
            var nameOfPresentation = " ";
            var sum = 0.0;
            var count = 0;
            var allGrades = 0.0;
            while (nameOfPresentation != "Finish")
            {
                nameOfPresentation = Console.ReadLine();
                if (nameOfPresentation == "Finish")
                {
                    Console.WriteLine($"Student's final assessment is {allGrades / count:f2}.");
                    return;
                }
                for (int i = 0; i < numberOfJury; i++)
                {
                    var grade = double.Parse(Console.ReadLine());
                    sum += grade;
                    count++;
                    allGrades += grade;
                }
                Console.WriteLine($"{nameOfPresentation} - {(sum/numberOfJury):f2}.");
                sum = 0.0;
            }
        }
    }
}
