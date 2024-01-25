using System;

namespace _04._Point_in_Figure
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var x = int.Parse(Console.ReadLine());

            var y = int.Parse(Console.ReadLine());

            //pravoygylnik =   4 <= x <= 10
            //                 -5 <= y <= 3
            //pravoygylnik2 =  2 <= x <= 12
            //                  -3 <= y <= 1

            var xFirst = (x >= 4 && x <= 10); //дали влиза в първия правоъгълник
            var yFirst = (y >= -5 && y <= 3);

            var xSecond = (x >= 2 && x <= 12);//дали влиза във втория правоъгълник
            var ySecond = (y >= -3 && y <= 1);

            var inside = (xFirst && yFirst) || (xSecond && ySecond);

            var result = inside ? "in" : "out";
            Console.WriteLine(result);
            







        }
    }
}
