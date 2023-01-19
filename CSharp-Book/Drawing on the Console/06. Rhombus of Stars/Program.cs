using System;

namespace Тренировка
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //var n = 4;
            var stars = 1;
            var spaces = n - 1;
            for (int rows = 0; rows < n; rows++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < stars; k++)
                {
                    Console.Write("* ");
                }
                for (int j = 0; j < spaces - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                spaces--;
                stars++;
            }
            stars = n - 1;
            spaces = n - (n - 1);
            for (int rows = 0; rows < n; rows++)
            {
                for (int j = 0; j < spaces; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < stars; k++)
                {
                    Console.Write("* ");
                }
                for (int j = 0; j < spaces - 1; j++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
                spaces++;
                stars--;
            }


        }
    }
}
