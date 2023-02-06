using System;

namespace _01.Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double sum = 0;
            bool isItSpecial = false;
            while (true)
            {
                var price = Console.ReadLine();
                if (price == "special" || price == "regular")
                {
                    if (sum <= 0)
                    {
                        Console.WriteLine("Invalid order!");
                        return;
                    }
                    if (price == "special")
                    {
                        isItSpecial = true;
                    }
                    break;
                }
                if (double.Parse(price) >= 0)
                {
                    sum += double.Parse(price);
                }
                else
                {
                    Console.WriteLine("Invalid price!");
                }
            }
            double taxes = sum * 0.20;

            Console.WriteLine("Congratulations you've just bought a new computer!");
            Console.WriteLine($"Price without taxes: {sum:f2}$");
            Console.WriteLine($"Taxes: {taxes:f2}$");
            Console.WriteLine("-----------");
            if (isItSpecial)
            {
                sum = (sum + taxes) * 0.90;
            }
            else
            {
                sum += taxes;
            }
            Console.WriteLine($"Total price: {sum:f2}$");
        }
    }
}
