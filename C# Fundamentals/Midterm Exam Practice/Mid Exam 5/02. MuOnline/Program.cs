using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._MuOnline
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dungeon = Console.ReadLine().Split("|", StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> type = new List<string>();
            List<int> values = new List<int>();
            for (int i = 0; i < dungeon.Count; i++)
            {
                var x = dungeon[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                type.Add(x[0]);
                values.Add(int.Parse(x[1]));
            }
             int hP = 100;
             int bC = 0;

            for (int i = 0; i < dungeon.Count; i++)
            {
                if (type[i] == "potion")
                {
                    int healed = 0;
                    hP += values[i];
                    if (hP > 100)
                    {
                        healed = values[i] - (hP - 100);
                        hP = 100;
                    }
                    else
                    {
                        healed = values[i];
                    }
                    Console.WriteLine($"You healed for {healed} hp.");
                    Console.WriteLine($"Current health: {hP} hp.");
                }
                else if (type[i] == "chest")
                {
                    bC+= values[i];
                    Console.WriteLine($"You found {values[i]} bitcoins.");
                }
                else
                {
                    hP -= values[i];
                    if (hP <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {type[i]}.");
                        Console.WriteLine($"Best room: {i+1}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {type[i]}.");
                    }
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {bC}");
            Console.WriteLine($"Health: {hP}");
        }
    }
}
