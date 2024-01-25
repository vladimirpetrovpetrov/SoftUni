using System;

namespace _04._Car_Number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());

            for (int num1 = start; num1 <= stop; num1++)
            {
                for (int num2 = start; num2 <= stop; num2++)
                {
                    for (int num3 = start; num3 <= stop; num3++)
                    {
                        for (int num4 = start; num4 <= stop; num4++)
                        {
                            bool cond2 = num1 > num4;
                            bool cond1 = (num1 % 2 == 0 && num4 % 2 != 0) || (num1 % 2 != 0 && num4 % 2 == 0);
                            bool cond3 = (num2 + num3) % 2 == 0;
                            if (cond2 && cond1 && cond3)
                            {
                                Console.Write($"{num1}{num2}{num3}{num4} ");
                            }
                        }
                    }
                }
            }
        }
    }
}
