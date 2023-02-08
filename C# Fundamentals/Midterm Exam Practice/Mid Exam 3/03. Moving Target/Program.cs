using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace _03._Moving_Target
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            List<int> targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    Console.WriteLine(String.Join("|", targets));
                    return;
                }
                string[] instr = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (instr[0] == "Shoot")
                {
                    int index = int.Parse(instr[1]);
                    int power = int.Parse(instr[2]);
                    Shoot(targets, index, power);
                  //  Console.WriteLine(String.Join("|", targets));
                }
                else if (instr[0] == "Add")
                {
                    int index = int.Parse(instr[1]);
                    int value = int.Parse(instr[2]);
                    AddTarget(targets, index, value);
                   // Console.WriteLine(String.Join("|", targets));
                }
                else if (instr[0] == "Strike")
                {
                    int index = int.Parse(instr[1]);
                    int radius = int.Parse(instr[2]);
                    Strike(targets, index, radius);
                    //Console.WriteLine(String.Join("|", targets));
                }
            }
        }
        static void Shoot(List<int> target, int index, int power)
        {
            if (index >= 0 && index <= target.Count - 1 && power >= 0)
            {
                target[index] -= power;
                if (target[index] <= 0)
                {
                    target.RemoveAt(index);
                }
            }
        }
        static void AddTarget(List<int> target, int index, int value)
        {
            if (index >= 0 && index <= target.Count - 1)
            {if (value >= 0)
                {
                    target.Insert(index, value);
                        
                }
            }
            else
            {
                Console.WriteLine("Invalid placement!");
            }

        }
        static void Strike(List<int> target, int index, int radius)
        {
            if (index >= 0 && index <= target.Count - 1 &&
                index - radius >= 0 && index + radius <= target.Count - 1 )
            {
                for (int i = 0; i < 2 * radius + 1; i++)
                {
                    target.RemoveAt(index - radius);
                }

            }
            else
            {
                Console.WriteLine("Strike missed!");
            }

        }
    }
}
