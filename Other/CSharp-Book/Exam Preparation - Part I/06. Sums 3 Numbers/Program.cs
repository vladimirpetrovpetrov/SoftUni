using System;

namespace _06._Sums_3_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var z = int.Parse(Console.ReadLine());




            var min = Math.Min(Math.Min(x, y), z);
            var max = Math.Max(Math.Max(x, y), z);
            var sum = x + y + z;
            var mid = sum - max - min;

            if(min + mid == max)
            {
                Console.WriteLine($"{min}+{mid}={max}");
            }
            else
            {
                Console.WriteLine("No");
            }










            /*
            var firstSecond = (x + y == z);
            var firstThird = (x + z == y);
            var SecondThird = (y + z == x);

            if (firstSecond)
            {
                if (x < y)
                {
                    Console.WriteLine($"{x}+{y}={z}");
                }
                else
                {
                    Console.WriteLine($"{y}+{x}={z}");
                }
            }
            else if (firstThird)
            {
                if (x < z)
                {
                    Console.WriteLine($"{x}+{z}={y}");
                }
                else
                {
                    Console.WriteLine($"{z}+{x}={y}");
                }
            }
            else if (SecondThird)
            {
                if (y < z)
                {
                    Console.WriteLine($"{y}+{z}={x}");
                }
                else
                {
                    Console.WriteLine($"{z}+{y}={x}");
                }
            }
            else
            {
                Console.WriteLine("No");
            }
            */


        }
    }
}
