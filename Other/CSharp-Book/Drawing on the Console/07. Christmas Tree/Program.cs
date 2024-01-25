using System;

namespace Christmas_tree_with_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            var stars = 0;
            var spaces = n;


            for (int row = 0; row <= n; row++)
            {

                for (int col = 0; col < spaces; col++)
                {
                    Console.Write(" ");

                }
                for (int i = 0; i < stars; i++)
                {
                    Console.Write("*");
                }
                Console.Write(" | ");
                for (int i = 0; i < stars; i++)
                {
                    Console.Write("*");
                }
                for (int col = 0; col < spaces; col++)
                {
                    Console.Write(" ");

                }
                Console.WriteLine();

                stars++;
                spaces--;

            }










        }
    }
}