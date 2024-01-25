using System;

namespace Butterfly_with_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //var n = 3;

            var rows = 2 * (n - 2) + 1;
            var cols = 2 * n - 1;
            //upper part
            for (int row = 1; row <= rows / 2; row++)
            {
                if (row % 2 != 0)
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write("\\");
                    Console.Write(" ");
                    Console.Write("/");
                    Console.Write(new string('*', n - 2));
                }
                else
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write("\\");
                    Console.Write(" ");
                    Console.Write("/");
                    Console.Write(new string('-', n - 2));
                }
                Console.WriteLine();

            }

            //middle
            Console.Write(new string(' ', n - 1));
            Console.Write("@");
            Console.WriteLine(new string(' ', n - 1));


            //lower part
            for (int row = 1; row <= rows / 2; row++)
            {
                if (row % 2 != 0)
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write("\\");
                    Console.Write(new string('*', n - 2));
                }
                else
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write("/");
                    Console.Write(" ");
                    Console.Write("\\");
                    Console.Write(new string('-', n - 2));
                }
                Console.WriteLine();

            }

        }
    }
}