using System;

namespace _06._Easter_Decoration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var clientsCount = int.Parse(Console.ReadLine());
            var purchase = "";
            double totalCost = 0.0;
            var purchaseCount = 0;
            var allClientsBills = 0.0;

            for (int i = 0; i < clientsCount; i++)
            {
                while(purchase != "Finish")
                {
                    purchase = Console.ReadLine();
                    if (purchase == "Finish")
                    {
                        if (purchaseCount % 2 == 0)
                        {
                            totalCost *= 0.80;
                        }
                        Console.WriteLine($"You purchased {purchaseCount} items for {totalCost:f2} leva.");
                        allClientsBills += totalCost;
                        purchaseCount = 0;
                        totalCost = 0.0;
                        purchase = "";
                        break;
                    }
                    purchaseCount++;
                    if(purchase == "basket")
                    {
                        totalCost += 1.50;
                    }else if(purchase == "wreath")
                    {
                        totalCost += 3.80;
                    }else if(purchase == "chocolate bunny")
                    {
                        totalCost += 7.00;
                    }
                }
            }
            Console.WriteLine($"Average bill per client is: {allClientsBills/clientsCount:f2} leva.");
        }
    }
}
