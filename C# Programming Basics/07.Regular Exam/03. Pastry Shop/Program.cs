using System;

namespace _03._Pastry_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var typeOfSweet = Console.ReadLine();
            var orderCount = int.Parse(Console.ReadLine());
            var day = int.Parse(Console.ReadLine());
            double cakePrice = 0;
            double soufflePrice = 0;
            double baklavaPrice = 0;
            double totalPrice = 0;

            switch (typeOfSweet)
            {
                case "Cake":
                    if (day <= 15)
                    {
                        cakePrice = 24.00;
                        totalPrice = cakePrice * orderCount;
                    }
                    else
                    {
                        cakePrice = 28.70;
                        totalPrice = cakePrice * orderCount;
                    }
                    break;
                case "Souffle":
                    if (day <= 15)
                    {
                        soufflePrice = 6.66;
                        totalPrice = soufflePrice * orderCount;
                    }
                    else
                    {
                        soufflePrice = 9.80;
                        totalPrice = soufflePrice * orderCount;
                    }
                    break;
                case "Baklava":
                    if (day <= 15)
                    {
                        baklavaPrice = 12.60;
                        totalPrice = baklavaPrice * orderCount;
                    }
                    else
                    {
                        baklavaPrice = 16.98;
                        totalPrice = baklavaPrice * orderCount;
                    }
                    break;

                default:
                    break;
            }
            if(day<=22 && totalPrice>=100 && totalPrice <= 200)
            {
                totalPrice *= 0.85;
            }else if (day <= 22 && totalPrice > 200)
            {
                totalPrice *= 0.75;
            }
            if (day <= 15)
            {
                totalPrice *= 0.90;
            }
            Console.WriteLine($"{totalPrice:f2}");
        }
    }
}
