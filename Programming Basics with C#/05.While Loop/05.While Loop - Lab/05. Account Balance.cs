using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string end = Console.ReadLine();
            var currentBalance = 0.00;
            double number = 0;
            while (end != "NoMoreMoney")
            {
                number = double.Parse(end);
                if (number < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    Console.WriteLine($"Total: {currentBalance:0.00}");
                    break;
                }


                currentBalance += number;


                Console.WriteLine($"Increase: {number:0.00}");

                end = Console.ReadLine();

            }
            if (number > 0)
            {
                Console.WriteLine($"Total: {currentBalance:0.00}");
            }
        }
    }
}
