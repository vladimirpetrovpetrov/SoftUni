using System;

namespace _01._Easter_Bakery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	цената на килограм захар е с 25 % по - ниска от тази на килограм брашно
            //•	цената на една кора с яйца е с 10 % по - висока от цената на килограм брашно
            //•	цената на един пакет мая е с 80 % по - ниска от цената на килограм захар


            var flourPricePerKg = double.Parse(Console.ReadLine());
            var flourKg = double.Parse(Console.ReadLine());
            var sugarKg = double.Parse(Console.ReadLine());
            var packsOfEggs = int.Parse(Console.ReadLine());
            var packsOfYeast = int.Parse(Console.ReadLine());

            var sugarPricePerKg = flourPricePerKg * 0.75;
            var packOfEggsPrice = flourPricePerKg * 1.10;
            var packOfYeastPrice = sugarPricePerKg * 0.20;

            var totalCost = flourPricePerKg * flourKg + sugarPricePerKg * sugarKg +
                packsOfEggs * packOfEggsPrice + packsOfYeast * packOfYeastPrice;
            Console.WriteLine($"{totalCost:f2}");
        }
    }
}
