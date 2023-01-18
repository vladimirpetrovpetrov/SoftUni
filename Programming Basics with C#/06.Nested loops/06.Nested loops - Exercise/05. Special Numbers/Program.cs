using System;

namespace _05._Special_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());

            for (int i = 1111; i <= 9999; i++)
            {
                if (SpecialNumberDividePerfect(i, n))
                {
                    Console.Write(i + " ");
                };
            }
        }
        static bool SpecialNumberDividePerfect(int num, int n)
        {
            var dividePerfect = true;
            var digit = 0;
            while (num > 0)
            {
                digit = num % 10;
                if (digit == 0)
                {
                    return false;
                }
                else if (!(n % digit == 0))
                {
                    dividePerfect = false;
                    if (!dividePerfect)
                    {
                        return dividePerfect;
                    }
                }
                num /= 10;
            }
            return dividePerfect;
        }
    }
}
