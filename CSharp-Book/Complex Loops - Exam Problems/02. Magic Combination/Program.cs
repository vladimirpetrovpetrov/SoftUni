using System;

namespace _02._Magic_Combination
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
                            for (int d5 = 1; d5 <= 9; d5++)
                            {
                                for (int d6 = 1; d6 <= 9; d6++)
                                {
                                    if (d1 * d2 * d3 * d4 * d5 * d6 == n)
                                    {
                                        Console.Write($"{d1}{d2}{d3}{d4}{d5}{d6} ");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
