using System;

namespace _09._Sum_of_Two_Numbers
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int stop = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int count = 0;

            for (int n1 = start; n1 <= stop; n1++)
            {
                for (int n2 = start; n2 <= stop; n2++)
                {
                    count++;
                    if (n1 + n2 == magicNumber)
                    {
                        Console.Write($"Combination N:{count} ");
                        Console.WriteLine($"({n1} + {n2} = {magicNumber})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{count} combinations - neither equals {magicNumber}");

        }
    }
}
