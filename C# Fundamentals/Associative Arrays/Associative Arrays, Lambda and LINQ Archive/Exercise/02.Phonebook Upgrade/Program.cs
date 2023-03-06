using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace _01._Phonebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var phoneBook = new SortedDictionary<string, string>();
            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "END")
                {
                    break;
                }
                if (input[0] == "A")
                {
                    if (!phoneBook.ContainsKey(input[1]))
                    {
                        phoneBook[input[1]] = input[2];
                    }
                    else
                    {
                        phoneBook[input[1]] = input[2];
                    }
                }
                else if (input[0] == "S")
                {
                    if (phoneBook.ContainsKey(input[1]))
                    {
                        foreach (var (key, value) in phoneBook)
                        {
                            if (key == input[1])
                            {
                                Console.WriteLine($"{key} -> {value}");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Contact {input[1]} does not exist.");
                    }
                }
                else if (input[0] == "ListAll")
                {
                    foreach (var (key, value) in phoneBook)
                    {
                        Console.WriteLine($"{key} -> {value}");
                    }
                }
            }






        }
    }
}
