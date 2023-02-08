using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Shoot_for_the_Win
{
    internal class Program
    {
        static int count = 0;
        static void Main(string[] args)
        {
            var targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }
                var target = int.Parse(command);
                ShootTarget(targets, target);
            }
            Console.WriteLine($"Shot targets: {count} -> {String.Join(" ", targets)}");





        }
        static void ShootTarget(List<int> target, int index)
        {
            if (index >= 0 && index <= target.Count - 1)
            {
                if (target[index] != -1)
                {
                    int temp = target[index];
                    target[index] = -1;
                    count++;

                    for (int i = 0; i < target.Count; i++)
                    {
                        if (i == index)
                        {
                            continue;
                        }
                        else if (target[i] > temp)
                        {
                            target[i] -= temp;
                        }
                        else if (target[i] <= temp && target[i] != -1)
                        {
                            target[i] += temp;
                        }
                    }
                }
            }
        }
    }
}
