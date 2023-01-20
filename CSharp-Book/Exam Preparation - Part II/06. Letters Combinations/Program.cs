using System;

namespace _06._Letters_Combinations
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char exclLetter = char.Parse(Console.ReadLine());
            int count = 0;
            for (char l1 = firstLetter; l1 <= secondLetter; l1++)
            {
                for (char l2 = firstLetter; l2 <= secondLetter; l2++)
                {
                    for (char l3 = firstLetter; l3 <= secondLetter; l3++)
                    {
                        if (l1 != exclLetter && l2 != exclLetter && l3 != exclLetter)
                        {
                            count++;
                            Console.Write($"{l1}{l2}{l3} ");
                        }
                    }
                }
            }
            Console.WriteLine(count);
        }
    }
}
