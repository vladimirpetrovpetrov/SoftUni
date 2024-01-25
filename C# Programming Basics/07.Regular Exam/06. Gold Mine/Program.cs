using System;

namespace _06._Gold_Mine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var totalLocations = int.Parse(Console.ReadLine());
            var totalYieldPerLocation = 0.0;

            for (int i = 0; i < totalLocations; i++)
            {
                var wantedAverageYield = double.Parse(Console.ReadLine());
                var daysForTheLocation = int.Parse(Console.ReadLine());
                for (int day = 0; day < daysForTheLocation; day++)
                {
                    var yieldPerDay = double.Parse(Console.ReadLine());
                    totalYieldPerLocation += yieldPerDay;
                }
                if(totalYieldPerLocation/daysForTheLocation >= wantedAverageYield)
                {
                    Console.WriteLine($"Good job! Average gold per day: {totalYieldPerLocation / daysForTheLocation:f2}.");
                }
                else
                {
                    Console.WriteLine($"You need {wantedAverageYield-(totalYieldPerLocation / daysForTheLocation):f2} gold.");
                }
                totalYieldPerLocation = 0.0;
            }
        }
    }
}
