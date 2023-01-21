using System;

namespace _05._Easter_Bake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var easternBreadsCount = int.Parse(Console.ReadLine());
            var maxSugar = int.MinValue;
            var maxFlour = int.MinValue;
            var totalSugar = 0.0;
            var totalFlour = 0.0;
            for (int i = 0; i < easternBreadsCount; i++)
            {
                var sugarGr = int.Parse(Console.ReadLine());
                var flourGr = int.Parse(Console.ReadLine());
                if (sugarGr > maxSugar)
                {
                    maxSugar = sugarGr;
                }
                if (flourGr > maxFlour)
                {
                    maxFlour = flourGr;
                }
                totalSugar += sugarGr;
                totalFlour += flourGr;
            }
            var packetsSugar = Math.Ceiling(totalSugar / 950);
            var packetsFlour = Math.Ceiling(totalFlour / 750);
            Console.WriteLine($"Sugar: {packetsSugar}");
            Console.WriteLine($"Flour: {packetsFlour}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
