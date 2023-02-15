using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Bonus_Scoring_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = double.Parse(Console.ReadLine());
            var lecturers = double.Parse(Console.ReadLine());
            var addBonus = double.Parse(Console.ReadLine());
            
            double maxPoint = int.MinValue;
            int maxAttendance = int.MinValue;

            if (students == 0 || lecturers ==0)
            {
                Console.WriteLine($"Max Bonus: 0.");
                Console.WriteLine($"The student has attended 0 lectures.");
            }
            
            for (int i = 0; i < students; i++)
            {
                int attendance = int.Parse(Console.ReadLine());
                double pointsNow = attendance / lecturers * (5 + addBonus);
                if(pointsNow > maxPoint)
                {
                    maxPoint = pointsNow;
                    maxAttendance = attendance;
                }
            }
            Console.WriteLine($"Max Bonus: {Math.Ceiling(maxPoint)}.");
            Console.WriteLine($"The student has attended {maxAttendance} lectures.");
        }
    }
}
