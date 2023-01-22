using System;

namespace _03._Travel_Agency
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            string cityName = Console.ReadLine();
            string packageName = Console.ReadLine();
            string vip = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            if (days < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else
            {
                double totalPrice;
                switch (cityName)
                {
                    case "Bansko":
                    case "Borovets":
                        double banskoPrice;
                        switch (packageName)
                        {
                            case "noEquipment":
                                switch (vip)
                                {
                                    case "yes":
                                        banskoPrice = 80 * 0.95;
                                        totalPrice = banskoPrice * days;
                                        if (days > 7)
                                        {
                                            totalPrice = banskoPrice * (days - 1);
                                        }
                                        Console.WriteLine($"The price is {totalPrice:0.00}lv! Have a nice time!");
                                        break;
                                    case "no":
                                        banskoPrice = 80;
                                        totalPrice = banskoPrice * days;
                                        if (days > 7)
                                        {
                                            totalPrice = banskoPrice * (days - 1);
                                        }
                                        Console.WriteLine($"The price is {totalPrice:0.00}lv! Have a nice time!");
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case "withEquipment":
                                switch (vip)
                                {
                                    case "yes":
                                        banskoPrice = 100 * 0.90;
                                        totalPrice = banskoPrice * days;
                                        if (days > 7)
                                        {
                                            totalPrice = banskoPrice * (days - 1);
                                        }
                                        Console.WriteLine($"The price is {totalPrice:0.00}lv! Have a nice time!");
                                        break;
                                    case "no":
                                        banskoPrice = 100;
                                        totalPrice = banskoPrice * days;
                                        if (days > 7)
                                        {
                                            totalPrice = banskoPrice * (days - 1);
                                        }
                                        Console.WriteLine($"The price is {totalPrice:0.00}lv! Have a nice time!");
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid input!");
                                break;
                        }
                        break;
                    case "Varna":
                    case "Burgas":
                        double varnaPrice;
                        switch (packageName)
                        {
                            case "withBreakfast":
                                switch (vip)
                                {
                                    case "yes":
                                        varnaPrice = 130 * 0.88;
                                        totalPrice = varnaPrice * days;
                                        if (days > 7)
                                        {
                                            totalPrice = varnaPrice * (days - 1);
                                        }
                                        Console.WriteLine($"The price is {totalPrice:0.00}lv! Have a nice time!");
                                        break;
                                    case "no":
                                        varnaPrice = 130;
                                        totalPrice = varnaPrice * days;
                                        if (days > 7)
                                        {
                                            totalPrice = varnaPrice * (days - 1);
                                        }
                                        Console.WriteLine($"The price is {totalPrice:0.00}lv! Have a nice time!");
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            case "noBreakfast":
                                switch (vip)
                                {
                                    case "yes":
                                        varnaPrice = 100 * 0.93;
                                        totalPrice = varnaPrice * days;
                                        if (days > 7)
                                        {
                                            totalPrice = varnaPrice * (days - 1);
                                        }
                                        Console.WriteLine($"The price is {totalPrice:0.00}lv! Have a nice time!");
                                        break;
                                    case "no":
                                        varnaPrice = 100;
                                        totalPrice = varnaPrice * days;
                                        if (days > 7)
                                        {
                                            totalPrice = varnaPrice * (days - 1);
                                        }
                                        Console.WriteLine($"The price is {totalPrice:0.00}lv! Have a nice time!");
                                        break;
                                    default:
                                        break;
                                }
                                break;
                            default:
                                Console.WriteLine("Invalid input!");
                                break;
                        }
                        break;


                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
        }
    }
}
