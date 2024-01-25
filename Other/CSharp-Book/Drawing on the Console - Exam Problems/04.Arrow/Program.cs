using System;

namespace Arrow_with_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            //first row 
            Console.Write(new string('.', n / 2));
            Console.Write(new string('#', n));
            Console.WriteLine(new string('.', n / 2));


            //1st row to -->
            var dots1 = n / 2;
            var dots2 = dots1 * 2 - 1;
            for (int row = 0; row < n - 2; row++)
            {
                for (int d1 = 0; d1 < dots1; d1++)
                {
                    Console.Write(".");
                }
                Console.Write("#");
                for (int d2 = 0; d2 < dots2; d2++)
                {
                    Console.Write(".");
                }
                Console.Write("#");
                for (int d1 = 0; d1 < dots1; d1++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }

            //middle
            Console.Write(new string('#', (n / 2 + 1)));
            Console.Write(new string('.', dots2));
            Console.WriteLine(new string('#', (n / 2 + 1)));

            //start-end -->
            dots1 = 1;
            dots2 = 2 * n - 1 - 4; //
            for (int row = 0; row < n - 2; row++)
            {
                for (int col = 0; col < dots1; col++)
                {
                    Console.Write(".");
                }
                Console.Write("#");
                for (int col = 0; col < dots2; col++)
                {
                    Console.Write(".");
                }
                Console.Write("#");
                for (int col = 0; col < dots1; col++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
                dots1++;
                dots2--;
                dots2--;
            }
            Console.Write(new string('.', dots1));
            Console.Write("#");
            Console.Write(new string('.', dots1));

        }
    }
}