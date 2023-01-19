using System;

namespace Тренировка
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());


            for (int row = 0; row < n; row++)
            {
                if (row == 0 || row == n - 1)
                {
                    Console.Write("+ ");
                }
                else
                {
                    Console.Write("| ");
                }
                for (int col = 0; col < n - 2; col++)
                {
                    Console.Write("- ");
                }
                if (row == n - 1 || row == 0)
                {
                    Console.Write("+");
                }
                else
                {
                    Console.Write("|");
                }
                Console.WriteLine();
            }


        }
    }
}
