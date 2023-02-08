using System;

namespace _01._Counter_Strike
{
    internal class Program
    {
        static int wins = 0;
        static void Main(string[] args)
        {
            var initialEnergy = int.Parse(Console.ReadLine());
            bool fail = false;
            while (true)
            {
                var distance = Console.ReadLine();
                if (distance == "End of battle")
                {
                    Console.WriteLine($"Won battles: {wins}. Energy left: {initialEnergy}");
                    return;
                }

                var points = int.Parse(distance);
                (initialEnergy, fail) = Fight(initialEnergy, points);
                if (fail)
                {
                    Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {initialEnergy} energy");
                    return;
                }
            }
        }
        static (int, bool) Fight(int energy, int distance)
        {
            bool fail = false;
            if (energy >= distance)
            {
                wins++;
                if (wins % 3 == 0)
                {
                    energy += wins;
                }
                energy -= distance;
            }
            else
            {
                fail = true;
                return (energy, fail);
            }
            return (energy, fail);
        }
        static void CheckEnergy(int energy)
        {
            Console.WriteLine($"Not enough energy! Game ends with {wins} won battles and {energy} energy");
        }
    }
}
