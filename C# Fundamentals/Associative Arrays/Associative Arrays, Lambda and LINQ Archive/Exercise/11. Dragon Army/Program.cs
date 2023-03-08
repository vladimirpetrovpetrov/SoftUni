using System;
using System.Collections.Generic;

namespace _11._Dragon_Army
{
    internal class Program
    {

        static void Main(string[] args)
        {
            var dragons = new Dictionary<string, SortedDictionary<string, List<long>>>();
            //type , (name,(dmg,hp,armor))
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var type = input[0]; //key
                var name = input[1]; //value then key
                var damage = 0l; var health = 0l; var armor = 0l;
                if (input[2] == "null")
                {
                    damage = 45;
                }
                else
                {
                    damage = long.Parse(input[2]);
                }
                if (input[3] == "null")
                {
                    health = 250;
                }
                else
                {
                    health = long.Parse(input[3]);
                }
                if (input[4] == "null")
                {
                    armor = 10;
                }
                else
                {
                    armor = long.Parse(input[4]);
                }
                var stats = new List<long> { damage, health, armor };


                if (!dragons.ContainsKey(type)) //ако няма още такъв тип
                {
                    //If the same dragon is added a second time, the new stats should overwrite the previous ones. Two dragons are considered equal if they match by both name and type.
                    var currentList = stats;
                    var currentDict = new SortedDictionary<string, List<long>> { { name, currentList } };

                    dragons.Add(type, currentDict);
                }
                else //ако има такъв тип
                {
                    //ако има такъв тип и няма такъв дракон
                    if (!dragons[type].ContainsKey(name))
                    {
                        dragons[type].Add(name, stats);
                    }
                    else
                    {
                        dragons[type][name] = stats;
                    }
                }
            }
            //type / dictionary
            foreach (var (key, value) in dragons)
            {//{Type}::({damage}/{health}/{armor})
                var averageDamage = 0d; var averageHealth = 0d; var averageArmor = 0d;
                var count = value.Values.Count;
                foreach (var item in value.Values)
                {
                    averageDamage += item[0];
                    averageHealth += item[1];
                    averageArmor += item[2];
                }
                averageDamage /= count; averageHealth /= count; averageArmor /= count;
                Console.WriteLine($"{key}::({averageDamage:f2}/{averageHealth:f2}/{averageArmor:f2})");
                foreach (var item in value)
                {
                    Console.WriteLine($"-{item.Key} -> damage: {value[item.Key][0]}, health: {value[item.Key][1]}, armor: {value[item.Key][2]}");
                }
            }





        }
    }
}
