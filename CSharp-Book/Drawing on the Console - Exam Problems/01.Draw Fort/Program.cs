using System;

namespace Stronghold_with_for_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            //var n = 4;


            var mid = 2 * n - 2 * (n / 2) - 4;
            if (mid < 0)
            {
                mid = 0;
            }

            //upper part
            Console.Write("/");
            Console.Write(new string('^', (n / 2)));
            Console.Write("\\");
            Console.Write(new string('_', mid));
            Console.Write("/");
            Console.Write(new string('^', (n / 2)));
            Console.Write("\\");
            //-------------------------
            Console.WriteLine();


            //middle part
            for (int row = 0; row < n - 2; row++)
            {
                if (row == n - 3)
                {

                    Console.Write("|");
                    Console.Write(new string(' ', (n / 2) + 1));
                    Console.Write(new string('_', mid));
                    Console.Write(new string(' ', (n / 2) + 1));
                    Console.Write("|");
                    continue;
                }
                Console.Write("|");
                Console.Write(new string(' ', ((n * 2) - 2)));
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine();
            //lower part
            Console.Write("\\");
            Console.Write(new string('_', (n / 2)));
            Console.Write("/");
            Console.Write(new string(' ', mid));
            Console.Write("\\");
            Console.Write(new string('_', (n / 2)));
            Console.Write("/");

        }
    }
}