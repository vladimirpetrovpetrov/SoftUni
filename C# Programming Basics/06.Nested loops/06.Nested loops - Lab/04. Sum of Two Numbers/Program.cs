using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var start = int.Parse(Console.ReadLine());
            var stop = int.Parse(Console.ReadLine());
            var magicNumber = int.Parse(Console.ReadLine());
            var combinations = 0;
            for (int n1 = start; n1 <= stop; n1++)
            {
                for (int n2 = start; n2 <= stop; n2++)
                {
                    combinations++;
                    if (n1 + n2 == magicNumber)
                    {

                        Console.WriteLine($"Combination N:{combinations} ({n1} + {n2} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinations} combinations - neither equals {magicNumber}");
        }
    }
}
