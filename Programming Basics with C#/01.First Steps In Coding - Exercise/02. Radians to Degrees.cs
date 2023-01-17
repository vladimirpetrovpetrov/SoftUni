using System;
namespace _02.Radians_to
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double angle = double.Parse(Console.ReadLine());
            double result = angle * 180 / Math.PI;
            Console.WriteLine(result);
        }
    }
}