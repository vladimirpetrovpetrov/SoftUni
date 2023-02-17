using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Array_Manipulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var x = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToList();

            while (9 == 9)
            {
                var command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (command[0] == "print")
                {
                    break;
                }
                if (command[0] == "add")
                {
                    x.Insert(int.Parse(command[1]), int.Parse(command[2]));
                }else if (command[0] == "addMany")
                {
                    int index = int.Parse(command[1]);
                    x.InsertRange(index, command.Skip(2).Select(int.Parse));
                }
                else if (command[0] == "contains")
                {
                    if (x.Contains(int.Parse(command[1])))
                    {
                        Console.WriteLine(x.IndexOf(int.Parse(command[1])));
                    }
                    else
                    {
                        Console.WriteLine("-1");
                    }
                }
                else if (command[0] == "remove")
                {
                    int index = int.Parse(command[1]);
                    x.RemoveAt(index);
                }
                else if (command[0] == "shift")
                {
                    int rotations = int.Parse(command[1]);
                    Shift(x,rotations);
                }
                else if (command[0] == "sumPairs")
                {
                    int sum = 0;
                    List<int> list = new List<int>();
                    if(x.Count%2 ==0)
                    {
                        for (int i = 0; i < x.Count-1; i+=2)
                        {
                            sum = x[i] + x[i+1];
                            list.Add(sum);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < x.Count - 2; i += 2)
                        {
                            sum = x[i] + x[i + 1];
                            list.Add(sum);
                        }
                        list.Add(x[x.Count - 1]);
                    }
                    x = list;
                }
            }
            Console.WriteLine("["+String.Join(", ",x)+"]");
        }
        static void Shift(List<int> x,int rotations)
        {
            for (int i = 0; i < rotations; i++)
            {
                int temp = x[0];
                x.RemoveAt(0);
                x.Add(temp);
            }

        }

    }
}
