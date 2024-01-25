using System;

namespace _03._Flowers
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            int boughtChrysant = int.Parse(Console.ReadLine());
            int boughtRoses = int.Parse(Console.ReadLine());
            int boughtTulips = int.Parse(Console.ReadLine());
            string season = Console.ReadLine().ToLower();
            string holiday = Console.ReadLine();
            double totalPrice = 0.0;
            double priceChrysant;
            double priceRoses;
            double priceTulips;
            switch (holiday)
            {
                case "Y":
                    switch (season)
                    {
                        case "spring":
                        case "summer":
                            priceChrysant = 2.00 * 1.15;
                            priceRoses = 4.10 * 1.15;
                            priceTulips = 2.50 * 1.15;
                            totalPrice = (priceChrysant * boughtChrysant) + (priceTulips * boughtTulips)
                                + (priceRoses * boughtRoses);
                            if (season == "spring" && boughtTulips > 7)
                            {
                                totalPrice *= 0.95;
                            }
                            if (boughtChrysant + boughtTulips + boughtRoses > 20)
                            {
                                totalPrice *= 0.80;
                            }
                            break;
                        case "autumn":
                        case "winter":
                            priceChrysant = 3.75 * 1.15;
                            priceRoses = 4.50 * 1.15;
                            priceTulips = 4.15 * 1.15;
                            totalPrice = (priceChrysant * boughtChrysant) + (priceTulips * boughtTulips)
                                + (priceRoses * boughtRoses);
                            if (season == "winter" && boughtRoses >= 10)
                            {
                                totalPrice *= 0.90;
                            }
                            if (boughtChrysant + boughtTulips + boughtRoses > 20)
                            {
                                totalPrice *= 0.80;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                case "N":
                    switch (season)
                    {
                        case "spring":
                        case "summer":
                            priceChrysant = 2.00;
                            priceRoses = 4.10;
                            priceTulips = 2.50;
                            totalPrice = (priceChrysant * boughtChrysant) + (priceTulips * boughtTulips)
                                + (priceRoses * boughtRoses);
                            if (season == "prolet" && boughtTulips > 7)
                            {
                                totalPrice *= 0.95;
                            }
                            if (boughtChrysant + boughtTulips + boughtRoses > 20)
                            {
                                totalPrice *= 0.80;
                            }
                            break;
                        case "autumn":
                        case "winter":
                            priceChrysant = 3.75;
                            priceRoses = 4.50;
                            priceTulips = 4.15;
                            totalPrice = (priceChrysant * boughtChrysant) + (priceTulips * boughtTulips)
                                + (priceRoses * boughtRoses);
                            if (season == "winter" && boughtRoses >= 10)
                            {
                                totalPrice *= 0.90;
                            }
                            if (boughtChrysant + boughtTulips + boughtRoses > 20)
                            {
                                totalPrice *= 0.80;
                            }
                            break;
                        default:
                            break;
                    }
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{totalPrice + 2:0.00}");








        }
    }
}
