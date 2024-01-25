using System;

namespace _09._Clock
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            for (int hour = 0; hour < 24; hour++)
            {
                for (int min = 0; min < 60; min++)
                {
                    Console.WriteLine($"{hour} : {min}");
                }
            }
        }
    }
}
