using System;

namespace _01.Days_of_the_Week
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] days = { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };

            var n = int.Parse(Console.ReadLine());
            if (n < 1 || n > 7)
            {
                Console.WriteLine("Invalid Day!");
            }
            else
            {
                Console.WriteLine(days[n-1]);
            }
        }
    }
}
