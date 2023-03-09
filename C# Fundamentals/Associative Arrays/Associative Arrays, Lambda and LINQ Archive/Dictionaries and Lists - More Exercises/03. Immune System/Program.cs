using System;
using System.Collections.Generic;

namespace _03._Immune_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var defeated = false;
            var defeatedViruses = new HashSet<string>();
            //virus’ strength = sum of all the virus
            //name’s letters’ ASCII codes / 3.

            //time it takes in seconds = virus strength, * name.Lenght;
            var initialHealth = int.Parse(Console.ReadLine());
            double immuneStr = initialHealth;
            while (true)
            {
                var virusName = Console.ReadLine();
                if (virusName == "end")
                {
                    break;
                }
                var virusStr = 0; //АКО НЕ ПРОБВАЙ С ДАБЪЛ
                var timeToDefeatInSec = 0;
                for (int i = 0; i < virusName.Length; i++)
                {
                    virusStr += virusName[i];
                }
                
                virusStr /= 3;
                timeToDefeatInSec = virusStr * virusName.Length;
                if (defeatedViruses.Contains(virusName))
                {
                    timeToDefeatInSec /= 3;
                }


                Console.WriteLine($"Virus {virusName}: {virusStr} => {timeToDefeatInSec} seconds");
                if (immuneStr > timeToDefeatInSec)
                {
                    
                    Console.WriteLine($"{virusName} defeated in {timeToDefeatInSec/60}m {timeToDefeatInSec % 60}s.");
                    immuneStr -= timeToDefeatInSec;
                    Console.WriteLine($"Remaining health: {immuneStr}");
                    immuneStr = (int)(1.20 * immuneStr);
                    if (immuneStr > initialHealth)
                    {
                        immuneStr= initialHealth;
                    }
                    defeatedViruses.Add(virusName);
                    
                }
                else
                {
                    Console.WriteLine("Immune System Defeated.");
                    defeated = true;
                    break;
                }
            }
            if (!defeated)
            {
                Console.WriteLine($"Final Health: {immuneStr}");
            }






        }
    }
}
