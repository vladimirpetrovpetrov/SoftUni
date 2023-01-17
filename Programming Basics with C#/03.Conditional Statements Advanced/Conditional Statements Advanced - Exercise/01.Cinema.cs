using System;

namespace Кино
{
    class Program
    {
        static void Main(string[] args)
        {

            var typeProj = Console.ReadLine();
            var rows = int.Parse(Console.ReadLine());
            var columns = int.Parse(Console.ReadLine());

            switch (typeProj)
            {
                case "Premiere":
                    Console.WriteLine((String.Format("{0:0.00}", (rows * columns) * 12.00)));
                    break;
                case "Normal":
                    Console.WriteLine((String.Format("{0:0.00}", (rows * columns) * 7.50)));
                    break;
                case "Discount":
                    Console.WriteLine((String.Format("{0:0.00}", (rows * columns) * 5.00)));
                    break;
            }




        }
    }
}
