using System;

namespace _04._Special_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {


            int n = int.Parse(Console.ReadLine());

            for (int d1 = 1; d1 <= 9; d1++)
            {
                for (int d2 = 1; d2 <= 9; d2++)
                {
                    for (int d3 = 1; d3 <= 9; d3++)
                    {
                        for (int d4 = 1; d4 <= 9; d4++)
                        {
                            if (n % d1 == 0 && n % d2 == 0 && n % d3 == 0 && n % d4 == 0)
                            {
                                Console.Write($"{d1}{d2}{d3}{d4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
