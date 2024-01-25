using System;

namespace Training
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var days = int.Parse(Console.ReadLine());
            var foodLeft = int.Parse(Console.ReadLine());
            var dogKgDay = double.Parse(Console.ReadLine());
            var catKgDay = double.Parse(Console.ReadLine());
            var turtleGrDay = double.Parse(Console.ReadLine());

            var dogFoodKg = days * dogKgDay;
            var catFoodKg = days * catKgDay;
            var turtleFoodKog = days * turtleGrDay / 1000;

            var neededFood = dogFoodKg + catFoodKg + turtleFoodKog;


            if (neededFood <= foodLeft)
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodLeft - neededFood));
            }
            else
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(neededFood - foodLeft));
            }



        }
    }
}
