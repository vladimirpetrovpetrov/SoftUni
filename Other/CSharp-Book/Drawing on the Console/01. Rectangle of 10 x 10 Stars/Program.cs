using System;
using System.Console;

namespace Тренировка
{
    class Program
    {
        static void Main(string[] args)
        {
            // var n = int.Parse(Console.ReadLine());

            var rows = 10;
            for (int k = 0; k < rows; k++)
            {
                for (int i = 0; i < rows; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}