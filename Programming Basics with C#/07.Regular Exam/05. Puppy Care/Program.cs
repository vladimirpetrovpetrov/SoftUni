using System;

namespace _05._Puppy_Care
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var foodBougthInKg = int.Parse(Console.ReadLine());
            var gramsEaten = " ";
            var foodEaten = 0;
            var foodAvailable = foodBougthInKg * 1000;

            while(gramsEaten != "Adopted")
            {
                gramsEaten = Console.ReadLine();
                if (gramsEaten == "Adopted")
                {
                    if(foodAvailable >= 0)
                    {
                        Console.WriteLine($"Food is enough! Leftovers: {foodAvailable} grams.");
                    }
                    else
                    {
                        Console.WriteLine($"Food is not enough. You need {Math.Abs(foodAvailable)} grams more.");
                    }
                    return;
                }
                foodEaten = Convert.ToInt32(gramsEaten);
                foodAvailable -= foodEaten;
            }
        }
    }
}
