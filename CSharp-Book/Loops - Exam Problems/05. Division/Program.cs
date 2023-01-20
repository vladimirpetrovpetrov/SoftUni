using System;

namespace Division_without_remainder
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = int.Parse(Console.ReadLine());
            var p1Count = 0.00;
            var p2Count = 0.00;
            var p3Count = 0.00;
            for (int i = 0; i < x; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (num % 2 == 0)
                {
                    p1Count += 1;
                }
                if (num % 3 == 0)
                {
                    p2Count += 1;
                }
                if (num % 4 == 0)
                {
                    p3Count += 1;
                }

            }
            Console.WriteLine("{0}%", String.Format("{0:0.00}", (p1Count / x) * 100));
            Console.WriteLine("{0}%", String.Format("{0:0.00}", (p2Count / x) * 100));
            Console.WriteLine("{0}%", String.Format("{0:0.00}", (p3Count / x) * 100));
        }
    }
}
