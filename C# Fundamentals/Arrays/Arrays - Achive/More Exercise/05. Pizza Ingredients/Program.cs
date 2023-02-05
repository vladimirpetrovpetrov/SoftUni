using System;
using System.Collections.Generic;

namespace _05._Pizza_Ingredients
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var ingrediants = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int maxLength = int.Parse(Console.ReadLine());
            List<string> availableIngr = new List<string>();

            foreach (var item in ingrediants)
            {
                if(item.Length == maxLength)
                {
                    Console.WriteLine($"Adding {item}.");
                    availableIngr.Add(item);
                    if(availableIngr.Count == 10)
                    {
                        break;
                    }
                }
            }
            Console.WriteLine($"Made pizza with total of {availableIngr.Count} ingredients.");
            Console.Write($"The ingredients are: ");
            Console.WriteLine(String.Join(", ",availableIngr)+".");













        }
    }
}
