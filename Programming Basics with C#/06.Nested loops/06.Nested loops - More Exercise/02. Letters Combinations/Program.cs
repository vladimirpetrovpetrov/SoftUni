using System;

namespace _02._Letters_Combinations
{
    internal class Program
    {
        private static void Main(string[] args)
        {


            char l1 = char.Parse(Console.ReadLine()); //начало на интервал
            char l2 = char.Parse(Console.ReadLine()); // край на интервал
            char l3 = char.Parse(Console.ReadLine()); // буква , с която комб се пропускат
            int count = 0;
            for (char i = l1; i <= l2; i++)
            {
                for (char j = l1; j <= l2; j++)
                {
                    for (char k = l1; k <= l2; k++)
                    {
                        bool conditionFirst = i != l3 && j != l3 && k != l3;
                        if (conditionFirst)
                        {
                            Console.Write($"{i}{j}{k} ");
                            count++;
                        }
                    }
                }
            }
            Console.WriteLine(count);





        }
    }
}
