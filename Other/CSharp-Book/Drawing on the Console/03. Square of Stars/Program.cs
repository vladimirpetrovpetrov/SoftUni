using System;

namespace Тренировка
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            for (int k = 0; k < n; k++)
            {
                Console.Write("*");

                for (int i = 0; i < n - 1; i++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }
        }
    }
}