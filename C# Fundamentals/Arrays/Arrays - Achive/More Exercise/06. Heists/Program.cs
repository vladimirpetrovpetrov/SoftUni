using System;
using System.Linq;

namespace _06._Heists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var prices = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int jPrice = prices[0];
            int gPrice = prices[1];
            int expenses = 0;
            int profits = 0;
            while (true)
            {
                string command = Console.ReadLine();
                if(command == "Jail Time")
                {
                    break;
                }
                var x = command.Split();
                expenses += int.Parse(x[1]);
                foreach(char item in x[0]) 
                {
                    if(item == '%')
                    {
                        profits += jPrice;
                    }else if(item == '$')
                    {
                        profits += gPrice;
                    }
                }
            }
            if(profits >= expenses)
            {
                Console.WriteLine($"Heists will continue. Total earnings: {profits-expenses}.");
            }
            else
            {
                Console.WriteLine($"Have to find another job. Lost: {expenses-profits}.");
            }
        }
    }
}