using System;

namespace _05._Travelling
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string destination = "empty";
            double totalSavedMoney = 0;
            double savedMoney;

            while (destination != "End")
            {
                destination = Console.ReadLine();
                if (destination == "End")
                {
                    return;
                }
                double minBudget = double.Parse(Console.ReadLine());
                while (totalSavedMoney < minBudget)
                {
                    savedMoney = double.Parse(Console.ReadLine());
                    totalSavedMoney += savedMoney;
                    if (totalSavedMoney >= minBudget)
                    {
                        Console.WriteLine($"Going to {destination}!");
                        totalSavedMoney -= minBudget;
                        break;
                    }
                }
            }
        }
    }
}
