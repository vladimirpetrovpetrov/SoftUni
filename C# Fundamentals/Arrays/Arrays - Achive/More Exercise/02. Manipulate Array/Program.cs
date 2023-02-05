using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Manipulate_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] array = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int commandsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandsCount; i++)
            {

                string[] command = Console.ReadLine().Split().ToArray();
                if (command[0] == "Reverse")
                {
                    Array.Reverse(array);
                }
                else if (command[0] == "Distinct")
                {
                    HashSet<string> distinct = new HashSet<string>();
                    for (int j = 0; j < array.Length; j++)
                    {
                        distinct.Add(array[j]);
                    }
                    array = distinct.ToArray();
                }
                else if (command[0] == "Replace")
                {
                    int index = int.Parse(command[1]);
                    array[index] = command[2];
                }
            }
            Console.WriteLine(String.Join(", ",array));
        }
    }
}
