using System;

namespace _02._Easter_Guests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //•	Един козунак струва 4лв. - за трима
            //•	Едно яйце струва 0.45лв. - по 2 яйца на всеки гост

            var guestCount = int.Parse(Console.ReadLine());
            var budget = int.Parse(Console.ReadLine());

            var neededEasterBreads = Math.Ceiling(guestCount / 3.00);
            var neededEggs = guestCount * 2.00;

            var totalCost = neededEasterBreads * 4.00 + neededEggs * 0.45;
            if (totalCost <= budget)
            {
                Console.WriteLine($"Lyubo bought {(int)neededEasterBreads} Easter bread and {(int)neededEggs} eggs.");
                Console.WriteLine($"He has {budget - totalCost:f2} lv. left.");
            }
            else
            {
                Console.WriteLine("Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {totalCost-budget:f2} lv. more.");
            }
        }
    }
}
