using System;

namespace _10._Profit
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int oneLevaCount = int.Parse(Console.ReadLine());
            int twoLevaCount = int.Parse(Console.ReadLine());
            int fiveLevaCount = int.Parse(Console.ReadLine());
            int sum = int.Parse(Console.ReadLine());

            for (int oneLev = 0; oneLev <= oneLevaCount; oneLev++) //бройки
            {
                for (int twoLeva = 0; twoLeva <= twoLevaCount; twoLeva++) //бройки
                {
                    for (int fiveLeva = 0; fiveLeva <= fiveLevaCount; fiveLeva++) //бройки
                    {
                        if ((oneLev * 1) + (twoLeva * 2) + (fiveLeva * 5) == sum)
                        {
                            Console.WriteLine($"{oneLev} * 1 lv. + {twoLeva} * 2 lv. + {fiveLeva} * 5 lv. = {sum} lv.");
                        }
                    }
                }
            }














        }
    }
}
