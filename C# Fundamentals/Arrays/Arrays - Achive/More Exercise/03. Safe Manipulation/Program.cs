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

            
            
            while (true)
            {

                var command = Console.ReadLine();
                if(command== "END")
                {
                    Console.WriteLine(String.Join(", ", array));
                    return;
                }
                var splitCommand = command.Split(" ").ToArray();

                if (splitCommand[0] == "Reverse")
                {
                    Array.Reverse(array);
                }
                else if (splitCommand[0] == "Distinct")
                {
                    HashSet<string> distinct = new HashSet<string>();
                    for (int j = 0; j < array.Length; j++)
                    {
                        distinct.Add(array[j]);
                    }
                    array = distinct.ToArray();
                }
                else if (splitCommand[0] == "Replace")
                {
                    int index = int.Parse(splitCommand[1]);
                    if (index < 0 || index > array.Length - 1)
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        array[index] = splitCommand[2];
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
            
        }
    }
}
