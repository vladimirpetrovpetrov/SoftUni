using System;

namespace _02._Report_System
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //cycle - paying cash / paying with credit card
            //sum > 100 - cant pay cash
            //sum < 10 - cant pay with card 
            //program ends if we collect enough money or when we type End



            int neededMoney = int.Parse(Console.ReadLine());
            string command = " ";
            int count = 0;
            double totalMoneyPayedWithCash = 0.0;
            double totalMoneyPayedWithCard = 0.0;
            int countPaymentsWithCash = 0;
            int countPaymentsWithCard = 0;

            while (command != "End" && neededMoney > 0)
            {
                command = Console.ReadLine();
                int sum;
                if (command == "End")
                {
                    Console.WriteLine("Failed to collect required money for charity.");
                    return;
                }
                else { sum = int.Parse(command); }
                count++;
                if (count % 2 == 0)
                {
                    if (sum < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        countPaymentsWithCard++;
                        neededMoney -= sum;
                        totalMoneyPayedWithCard += sum;
                        Console.WriteLine("Product sold!");
                    }
                }
                else
                {
                    if (sum > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        countPaymentsWithCash++;
                        neededMoney -= sum;
                        totalMoneyPayedWithCash += sum;
                        Console.WriteLine("Product sold!");
                    }
                }
            }
            double averagePaymentsWithCard = totalMoneyPayedWithCard / countPaymentsWithCard;
            double averagePaymentsWithCash = totalMoneyPayedWithCash / countPaymentsWithCash;

            Console.WriteLine($"Average CS: {averagePaymentsWithCash:0.00}");
            Console.WriteLine($"Average CC: {averagePaymentsWithCard:0.00}");







        }
    }
}
