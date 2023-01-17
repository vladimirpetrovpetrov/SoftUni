using System;

namespace Тренировка
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            var n = int.Parse(Console.ReadLine());
            var sum1 = 0;
            var sum2 = 0;
            for (int i = 1; i <= 2 * n; i++)
            {
                var number = int.Parse(Console.ReadLine());
                if (i <= n)
                {
                    sum1 += number;
                }
                else
                {
                    sum2 += number;
                }

            }
            if (sum1 == sum2)
            {
                Console.WriteLine($"Yes, sum = {sum1}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum1 - sum2)}");
            }

        }
    }
}
