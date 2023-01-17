using System;

namespace Ћ€тно_облекло
{
    class Program
    {
        static void Main(string[] args)
        {
            var degrees = int.Parse(Console.ReadLine());
            var time = Console.ReadLine();

            string Outfit = "";
            string Shoes = "";
            switch (time)
            {
                case "Morning":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        Outfit = "Sweatshirt";
                        Shoes = "Sneakers";
                        Console.WriteLine("It's " + degrees + " degrees, get your " + Outfit + " and " + Shoes + ".");
                    }
                    else if (degrees > 18 && degrees <= 24)
                    {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                        Console.WriteLine("It's " + degrees + " degrees, get your " + Outfit + " and " + Shoes + ".");
                    }
                    else if (degrees >= 25)
                    {
                        Outfit = "T-Shirt";
                        Shoes = "Sandals";
                        Console.WriteLine("It's " + degrees + " degrees, get your " + Outfit + " and " + Shoes + ".");
                    }
                    break;
                case "Afternoon":
                    if (degrees >= 10 && degrees <= 18)
                    {
                        Outfit = "Shirt";
                        Shoes = "Moccasins";
                        Console.WriteLine("It's " + degrees + " degrees, get your " + Outfit + " and " + Shoes + ".");
                    }
                    else if (degrees > 18 && degrees <= 24)
                    {
                        Outfit = "T-Shirt";
                        Shoes = "Sandals";
                        Console.WriteLine("It's " + degrees + " degrees, get your " + Outfit + " and " + Shoes + ".");
                    }
                    else if (degrees >= 25)
                    {
                        Outfit = "Swim Suit";
                        Shoes = "Barefoot";
                        Console.WriteLine("It's " + degrees + " degrees, get your " + Outfit + " and " + Shoes + ".");
                    }
                    break;
                case "Evening":
                    Outfit = "Shirt";
                    Shoes = "Moccasins";
                    Console.WriteLine("It's " + degrees + " degrees, get your " + Outfit + " and " + Shoes + ".");
                    break;
            }

        }
    }
}
