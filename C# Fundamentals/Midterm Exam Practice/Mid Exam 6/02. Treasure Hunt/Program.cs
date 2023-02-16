using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Treasure_Hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var initialChest = Console.ReadLine().Split("|").ToList();

            while (true)
            {
                var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (command[0] == "Yohoho!")
                {
                    break;
                }
                if (command[0] == "Loot")
                {
                    foreach (var item in command.Skip(1))
                    {
                        if(!initialChest.Contains(item))
                        {
                            initialChest.Insert(0, item);
                        }
                    }
                }else if (command[0] == "Drop")
                {
                    int index = int.Parse(command[1]);
                    if(index >= 0 && index <= initialChest.Count - 1)
                    {
                        string temp = initialChest[index];
                        initialChest.RemoveAt(index);
                        initialChest.Add(temp);
                    }
                }
                else if (command[0] == "Steal")
                {
                    int num = int.Parse(command[1]);
                    if (num >= initialChest.Count)
                    {
                        Console.WriteLine(String.Join(", ",initialChest));
                        initialChest.Clear();
                    }
                    else
                    {
                        List<string> tempList = new List<string>();
                        for (int i = 0; i < num; i++)
                        {
                            tempList.Add(initialChest[initialChest.Count-1]);
                            initialChest.RemoveAt(initialChest.Count - 1);
                        }
                        tempList.Reverse();
                        Console.WriteLine(String.Join(", ",tempList));
                    }
                }
            }
            if (initialChest.Count > 0)
            {
                double sum = 0;
                foreach (var item in initialChest)
                {
                    sum += item.Length;
                }
                sum/= (double)initialChest.Count;
                Console.WriteLine($"Average treasure gain: {sum:F2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
}
