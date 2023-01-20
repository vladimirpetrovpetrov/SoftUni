using System;
using System.Data;

namespace _09._Perfect_Diamond
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());



            //горна част
            for (int row = 1; row <= n; row++)
            {
                for (int i = 0; i < n - row; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 0; i < row - 1; i++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();
            }

            //долна част

            for (int row = n-1; row > 0; row--)
            {
                for (int i = 0; i < n-row; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("*");
                for (int i = 0; i < row-1; i++)
                {
                    Console.Write("-*");
                }
                Console.WriteLine();

            }








        }
    }
}
