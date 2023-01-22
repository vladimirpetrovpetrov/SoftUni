using System;

namespace _03._Coffee_Machine
{
    internal class Program
    {
        private static void Main(string[] args)
        {


            string typeBev = Console.ReadLine();
            string sugar = Console.ReadLine();
            int countBev = int.Parse(Console.ReadLine());
            double totalCost = 0.00;
            double cPrice;
            switch (typeBev)
            {
                case "Espresso":
                    double ePrice;
                    switch (sugar)
                    {
                        case "Without":
                            ePrice = 0.90 * 0.65;   //отстъпката за без захар 35 % 
                            if (countBev >= 5)
                            {
                                ePrice *= 0.75; //отстъпката за 5 броя еспресо 25%
                            }
                            totalCost = countBev * ePrice;
                            if (totalCost > 15)
                            {
                                totalCost *= 0.80; //отстъпка за над 15 лв - 20%
                            }
                            break;
                        case "Normal":
                            ePrice = 1.00;
                            if (countBev >= 5)
                            {
                                ePrice *= 0.75; //отстъпката за 5 броя еспресо 25%
                            }
                            totalCost = countBev * ePrice;
                            if (totalCost > 15)
                            {
                                totalCost *= 0.80; //отстъпка за над 15 лв - 20%
                            }
                            break;
                        case "Extra":
                            ePrice = 1.20;
                            if (countBev >= 5)
                            {
                                ePrice *= 0.75; //отстъпката за 5 броя еспресо 25%
                            }
                            totalCost = countBev * ePrice;
                            if (totalCost > 15)
                            {
                                totalCost *= 0.80; //отстъпка за над 15 лв - 20%
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case "Cappuccino":
                    switch (sugar)
                    {
                        case "Without":
                            cPrice = 1.00 * 0.65;   //отстъпката за без захар 35 % 
                            totalCost = countBev * cPrice;
                            if (totalCost > 15)
                            {
                                totalCost *= 0.80; //отстъпка за над 15 лв - 20%
                            }
                            break;
                        case "Normal":
                            cPrice = 1.20;
                            totalCost = countBev * cPrice;
                            if (totalCost > 15)
                            {
                                totalCost *= 0.80; //отстъпка за над 15 лв - 20%
                            }
                            break;
                        case "Extra":
                            cPrice = 1.60;
                            totalCost = countBev * cPrice;
                            if (totalCost > 15)
                            {
                                totalCost *= 0.80; //отстъпка за над 15 лв - 20%
                            }
                            break;
                        default:
                            break;
                    }
                    break;

                case "Tea":
                    switch (sugar)
                    {
                        case "Without":
                            cPrice = 0.50 * 0.65;   //отстъпката за без захар 35 % 
                            totalCost = countBev * cPrice;
                            if (totalCost > 15)
                            {
                                totalCost *= 0.80; //отстъпка за над 15 лв - 20%
                            }
                            break;
                        case "Normal":
                            cPrice = 0.60;
                            totalCost = countBev * cPrice;
                            if (totalCost > 15)
                            {
                                totalCost *= 0.80; //отстъпка за над 15 лв - 20%
                            }
                            break;
                        case "Extra":
                            cPrice = 0.70;
                            totalCost = countBev * cPrice;
                            if (totalCost > 15)
                            {
                                totalCost *= 0.80; //отстъпка за над 15 лв - 20%
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"You bought {countBev} cups of {typeBev} for {totalCost:0.00} lv.");


        }
    }
}
