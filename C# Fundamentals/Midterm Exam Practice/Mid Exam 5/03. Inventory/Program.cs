using System;
using System.Linq;

namespace _03._Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).ToList();

            while(true)
            {
                var command = Console.ReadLine().Split(" - ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (command[0] == "Craft!")
                {
                    break;
                }
                if (command[0] == "Collect")
                {
                    if (!list.Contains(command[1]))
                    {
                        list.Add(command[1]);
                    }
                }
                else if (command[0] == "Drop")
                {
                    if (list.Contains(command[1]))
                    {
                        list.Remove(command[1]);
                    }
                }
                else if (command[0] == "Combine Items")
                {
                    var items = command[1].Split(":").ToList();
                    if (list.Contains(items[0]))
                    {
                        int index = list.IndexOf(items[0]);
                        list.Insert(index + 1, items[1]);
                    }

                }
                else if (command[0] == "Renew")
                {
                    if (list.Contains(command[1]))
                    {
                        int index = list.IndexOf(command[1]);
                        list.RemoveAt(index);
                        list.Add(command[1]);
                    }
                }
            }
                Console.WriteLine(String.Join(", ",list));
        }
    }
}
