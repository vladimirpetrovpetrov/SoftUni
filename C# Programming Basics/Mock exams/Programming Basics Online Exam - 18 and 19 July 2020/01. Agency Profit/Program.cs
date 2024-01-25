using System;

namespace _01._Agency_Profit
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            string companyName = Console.ReadLine();
            int adultTickets = int.Parse(Console.ReadLine());
            int kidTickets = int.Parse(Console.ReadLine());
            double adultTicketPrice = double.Parse(Console.ReadLine());
            double servicePrice = double.Parse(Console.ReadLine());
            double kidTicketPrice = adultTicketPrice * 0.30;
            double totalKidsProfit = (kidTicketPrice * kidTickets) + (kidTickets * servicePrice);
            double totalAdultProfit = (adultTickets * adultTicketPrice) +
                (adultTickets * servicePrice);
            double companyProfit = (totalKidsProfit + totalAdultProfit) * 0.20;
            Console.WriteLine($"The profit of your agency from {companyName} tickets is {companyProfit:f2} lv.");
        }
    }
}
