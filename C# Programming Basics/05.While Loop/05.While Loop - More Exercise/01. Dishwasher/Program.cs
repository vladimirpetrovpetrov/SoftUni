using System;

namespace _01._Dishwasher
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //bottle = 750ml
            //plate = 5ml
            //pot = 15ml
            //every cycle of washing is with plates, but every third - which is with pots.


            int boottlesOfDetergent = int.Parse(Console.ReadLine());
            int amountDetergentInMl = boottlesOfDetergent * 750;
            string countOfDishes = " ";
            int cycles = 0;
            int cleanPlates = 0;
            int cleanPots = 0;




            while (amountDetergentInMl >= 0 && countOfDishes != "End")
            {
                countOfDishes = Console.ReadLine();
                if (countOfDishes == "End")
                {
                    Console.WriteLine("Detergent was enough!");
                    Console.WriteLine($"{cleanPlates} dishes and {cleanPots} pots were washed.");
                    Console.WriteLine($"Leftover detergent {amountDetergentInMl} ml.");
                    return;
                }
                cycles++;
                if (cycles % 3 == 0)
                {
                    amountDetergentInMl -= int.Parse(countOfDishes) * 15;
                    cleanPots += int.Parse(countOfDishes);
                }
                else
                {
                    amountDetergentInMl -= int.Parse(countOfDishes) * 5;
                    cleanPlates += int.Parse(countOfDishes);
                }
            }
            if (amountDetergentInMl < 0)
            {
                Console.WriteLine($"Not enough detergent, {Math.Abs(amountDetergentInMl)} ml. more necessary!");
            }













        }
    }
}
