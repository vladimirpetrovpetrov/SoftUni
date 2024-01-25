using System;

namespace рисуване_на_запълнен_квадрат
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            FilledSquare(n);
        }


        static void FilledSquare(int num)
        {
            FirstOrLastRow(num);
            Console.WriteLine();
            for (int row = 0; row < num - 2; row++)
            {
                Console.Write("-");
                for (int col = 0; col < num - 1; col++)
                {
                    Console.Write("\\/");
                }
                Console.Write("-");
                Console.WriteLine();
            }
            FirstOrLastRow(num);
        }
        static void FirstOrLastRow(int num)
        {
            Console.Write(new string('-', 2 * num));
        }

    }
}
