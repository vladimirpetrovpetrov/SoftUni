using System;

namespace _02._Bricks
{
    internal class Program
    {
        static void Main(string[] args)
        {



            var bricks = int.Parse(Console.ReadLine());
            var workers = int.Parse(Console.ReadLine());
            var volumePerCart = int.Parse(Console.ReadLine());

            double minCircles = (double)bricks / (workers * volumePerCart);
            minCircles = Math.Ceiling(minCircles);
            Console.WriteLine(minCircles);









        }
    }
}
