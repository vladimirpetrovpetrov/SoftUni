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

                for (int i = 0; i < n; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}