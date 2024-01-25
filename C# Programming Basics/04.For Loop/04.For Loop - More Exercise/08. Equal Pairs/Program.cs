using System;

namespace _08._Equal_Pairs
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int numberOfPairs = int.Parse(Console.ReadLine());
            bool areEqual = true;
            int oldSum = 0;
            int sum = 0;
            int maxDif = int.MinValue;
            for (int i = 1; i <= numberOfPairs * 2; i++)
            {
                int number = int.Parse(Console.ReadLine());
                sum += number;
                if (i % 2 == 0)
                {

                    if (i != 2)
                    {
                        if (sum != oldSum)
                        {
                            if (maxDif < Math.Abs(sum - oldSum))
                            {
                                maxDif = Math.Abs(sum - oldSum);
                            }
                            areEqual = false;
                        }
                    }
                    oldSum = sum;
                    sum = 0;
                }
            }
            if (areEqual)
            {
                Console.WriteLine($"Yes, value={oldSum}");
            }
            else
            {
                Console.WriteLine($"No, maxdiff={maxDif}");
            }
        }
    }
}
