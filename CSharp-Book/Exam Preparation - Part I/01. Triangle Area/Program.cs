using System;

namespace _01._Triangle_Area
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x1 = int.Parse(Console.ReadLine());
            var y1 = int.Parse(Console.ReadLine());
            var x2 = int.Parse(Console.ReadLine());
            var y2 = int.Parse(Console.ReadLine());
            var x3 = int.Parse(Console.ReadLine());
            var y3 = int.Parse(Console.ReadLine());
            double a = Math.Abs(x2 - x3) ;
            double h = Math.Abs(y1 - y2) ;
            Console.WriteLine((a *(double)h) /2.0 );
        }
    }
}
