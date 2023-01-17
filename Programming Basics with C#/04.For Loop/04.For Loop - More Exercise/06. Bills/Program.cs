using System;

namespace _06._Bills
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            const int waterBill = 20;
            const int netBill = 15;
            //other bills = full bill for the month * 0.2
            int months = int.Parse(Console.ReadLine());
            double fullCost = 0.0;
            double allElBills = 0.0;

            for (int i = 0; i < months; i++)
            {
                double electricityBill = double.Parse(Console.ReadLine());
                fullCost += electricityBill + waterBill + netBill;
                allElBills += electricityBill;
            }

            double otherBills = (allElBills + waterBill * months + netBill * months) * 0.20
    + (allElBills + waterBill * months + netBill * months);

            Console.WriteLine($"Electricity: {allElBills:0.00} lv");
            Console.WriteLine($"Water: {waterBill * months:0.00} lv");
            Console.WriteLine($"Internet: {netBill * months:0.00} lv");
            Console.WriteLine($"Other: {otherBills:0.00} lv");
            Console.WriteLine($"Average: {(fullCost + otherBills) / months:0.00} lv");
        }
    }
}
