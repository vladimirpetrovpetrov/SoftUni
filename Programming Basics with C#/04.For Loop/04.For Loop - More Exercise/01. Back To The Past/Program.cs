using System;

namespace _01._Back_To_The_Past
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double inheritedMoney = double.Parse(Console.ReadLine());
            int finalYear = int.Parse(Console.ReadLine());

            for (int i = 1800; i <= finalYear; i++)
            {
                if (i % 2 == 0)
                {
                    inheritedMoney -= 12000;
                }
                else
                {
                    inheritedMoney -= 12000 + (50 * (18 + (i - 1800)));
                }
            }
            if (inheritedMoney < 0)
            {
                Console.WriteLine($"He will need {Math.Abs(inheritedMoney):0.00} dollars to survive.");
            }
            else
            {
                Console.WriteLine($"Yes! He will live a carefree life and will have {inheritedMoney:0.00} dollars left.");
            }
        }
    }
}
