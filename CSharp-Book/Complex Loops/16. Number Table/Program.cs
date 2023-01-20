using System;

namespace Таблица_с_числа
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    var num = col + row + 1;
                    if (num > n)
                    {
                        num = -num + 2 * n;
                    }
                    Console.Write(num + " ");
                }
                Console.WriteLine();
            }
            //for (int row = 0; row < n; row++)
            //{
            //    for (int col = 0; col < n; col++)
            //    {
            //        var num = row + col + 1;
            //        if(num > n)
            //        {
            //            num = -num + 2*n;
            //        }
            //        Console.Write(num + " ");

            //    }
            //    Console.WriteLine();
            //}

        }
    }
}
