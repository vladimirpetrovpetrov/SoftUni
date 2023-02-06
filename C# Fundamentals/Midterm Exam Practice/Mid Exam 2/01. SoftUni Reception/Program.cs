using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace _01._SoftUni_Reception
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double totalHours = 0;
            int s1 = int.Parse(Console.ReadLine());
            int s2 = int.Parse(Console.ReadLine());
            int s3 = int.Parse(Console.ReadLine());
            int hour = 0;

            int studentsCount = int.Parse(Console.ReadLine());
            int perHour = s1 + s2 + s3;
            
            while (studentsCount > 0)
            {
                hour++;
                if(hour%4==0)
                {
                    continue;
                }
                studentsCount -= perHour;
            }
            Console.WriteLine($"Time needed: {hour}h.");
        }
    }
}
