using System;

namespace _05._Christmas_Hat
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            //The upper part of the Christmas hat

            Console.Write(new string('.', (2 * n) - 1));
            Console.Write("/|\\");
            Console.Write(new string('.', (2 * n) - 1));
            Console.WriteLine();
            Console.Write(new string('.', (2 * n) - 1));
            Console.Write("\\|/");
            Console.Write(new string('.', (2 * n) - 1));
            Console.WriteLine();

            //The middle part of the Christmas hat

            for (int row = 0; row < 2 * n; row++)
            {
                for (int i = (2 * n) - 1; i > row; i--)
                {
                    Console.Write(".");
                }
                Console.Write("*");
                for (int col = 0; col < row; col++)
                {
                    Console.Write("-");
                }

                Console.Write("*");
                for (int col = 0; col < row; col++)
                {
                    Console.Write("-");
                }
                Console.Write("*");
                for (int i = (2 * n) - 1; i > row; i--)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }




            //The lower side of the Christmas hat

            Console.WriteLine(new string('*', (4 * n) + 1));
            Console.Write("*");
            for (int i = 0; i < 2 * n; i++)
            {
                Console.Write(".*");
            }
            Console.WriteLine();
            Console.Write(new string('*', (4 * n) + 1));
        }
    }
}
