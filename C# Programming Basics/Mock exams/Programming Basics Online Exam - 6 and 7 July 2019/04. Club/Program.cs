using System;

namespace _04._Club
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double wantedProfit = double.Parse(Console.ReadLine());
            double currentProfit = 0.0;
            while (true)
            {
                string bevName = Console.ReadLine();
                if (bevName == "Party!")
                {
                    Console.WriteLine($"We need {wantedProfit - currentProfit:0.00} leva more.");
                    Console.WriteLine($"Club income - {currentProfit:0.00} leva.");
                    break;
                }

                double bevCount = int.Parse(Console.ReadLine());
                double priceCocktail = bevName.Length;
                double currentОrderPrice = priceCocktail * bevCount;
                if (currentОrderPrice % 2 != 0)
                {
                    currentProfit += priceCocktail * bevCount * 0.75;
                }
                else
                {
                    currentProfit += priceCocktail * bevCount;
                }
                if (currentProfit >= wantedProfit)
                {
                    Console.WriteLine("Target acquired.");
                    Console.WriteLine($"Club income - {currentProfit:0.00} leva.");
                    break;
                }
            }
        }
    }
}
