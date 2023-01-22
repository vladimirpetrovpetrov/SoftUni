using System;

namespace _02._Family_Trip
{
    internal class Program
    {
        private static void Main(string[] args)
        {



            double budget = double.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int percentForExtraExpenses = int.Parse(Console.ReadLine());

            if (nightsCount > 7)
            {
                pricePerNight *= 0.95;
            }
            double extra = percentForExtraExpenses / 100.00 * budget;
            double totalCost = (nightsCount * pricePerNight) + extra;
            if (budget >= totalCost)
            {
                Console.WriteLine($"Ivanovi will be left with {budget - totalCost:0.00} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{totalCost - budget:0.00} leva needed.");
            }
        }
    }
}
