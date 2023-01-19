using System;

namespace House_with_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //покрив

            if (n % 2 == 0)
            {
                var stars = 2;
                var spaces = (n - stars) / 2;
                for (int row = 0; row < n / 2; row++)
                {
                    Console.Write(new string('-', (spaces)));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', (spaces)));

                    spaces--;
                    stars++;
                    stars++;

                    Console.WriteLine();
                }

            }
            else
            {
                var stars = 1;
                var spaces = (n - stars) / 2;
                for (int row = 0; row < (n + 1) / 2; row++)
                {
                    Console.Write(new string('-', (spaces)));
                    Console.Write(new string('*', stars));
                    Console.Write(new string('-', (spaces)));

                    spaces--;
                    stars++;
                    stars++;

                    Console.WriteLine();
                }
            }


            //долна част
            if (n % 2 == 0)
            {
                for (int row = 0; row < n / 2; row++)
                {
                    Console.Write("|");
                    for (int col = 0; col < n - 2; col++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }
            }
            else
            {
                for (int row = 0; row < (n - 1) / 2; row++)
                {
                    Console.Write("|");
                    for (int col = 0; col < n - 2; col++)
                    {
                        Console.Write("*");
                    }
                    Console.Write("|");
                    Console.WriteLine();
                }
            }
        }
    }
}
