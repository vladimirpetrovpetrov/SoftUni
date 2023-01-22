using System;

namespace _01._Pool_Day
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            double entFee = double.Parse(Console.ReadLine());
            double costPerBed = double.Parse(Console.ReadLine());
            double costPerUmrella = double.Parse(Console.ReadLine());

            double totalEntFee = peopleCount * entFee;

            double totalBedCost = Math.Ceiling(peopleCount * 0.75) * costPerBed;


            double totalUmrella = Math.Ceiling(peopleCount / 2.00) * costPerUmrella;
            double entireCost = totalEntFee + totalBedCost + totalUmrella;
            Console.WriteLine($"{entireCost:0.00} lv.");
        }
    }
}
