using System;

namespace _01._Moon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double toTheMoon = 384400;
            double averageSpeed = double.Parse(Console.ReadLine());
            double litresPer100km = double.Parse(Console.ReadLine());

            double totalKm = toTheMoon * 2;
            double time = Math.Ceiling(totalKm / averageSpeed);
            double totalTime = time + 3;
            Console.WriteLine(totalTime);
            Console.WriteLine((totalKm /100.0)*litresPer100km);
        }
    }
}
