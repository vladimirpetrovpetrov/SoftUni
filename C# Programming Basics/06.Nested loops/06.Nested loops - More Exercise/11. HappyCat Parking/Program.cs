using System;

namespace _11._HappyCat_Parking
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            double sum = 0.0;
            double totalSum = 0.0;

            for (int day = 1; day <= days; day++)
            {
                for (int hour = 1; hour <= hours; hour++)
                {
                    bool cond1 = day % 2 == 0 && hour % 2 != 0;
                    bool cond2 = day % 2 != 0 && hour % 2 == 0;
                    if (cond1)
                    {
                        sum += 2.50;
                    }
                    if (cond2)
                    {
                        sum += 1.25;
                    }
                    if (!cond1 && !cond2)
                    {
                        sum += 1.00;
                    }
                }
                totalSum += sum;
                Console.WriteLine($"Day: {day} - {sum:0.00} leva");
                sum = 0;
            }
            Console.WriteLine($"Total: {totalSum:0.00} leva");
        }
    }
}
