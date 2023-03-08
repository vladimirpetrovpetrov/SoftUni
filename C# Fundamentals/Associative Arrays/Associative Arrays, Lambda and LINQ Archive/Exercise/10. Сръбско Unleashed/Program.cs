using System;
using System.Collections.Generic;
using System.Linq;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ulong вместо long, 
            Dictionary<string, Dictionary<string, long>> info = new Dictionary<string, Dictionary<string, long>>();

            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
                if (input[0] == "End")
                {
                    break;
                }
                //"singer @venue ticketsPrice ticketsCount"
                var startsWithA = false;
                var indexOfA = 0;
                foreach (var item in input) //провери дали някоя от думата започва с @
                {
                    if (item.StartsWith('@'))
                    {
                        startsWithA = true;
                        indexOfA = input.IndexOf(item);
                        break;
                    }
                }
                if (!startsWithA)
                {
                    continue;
                }

                bool lastIsDigitOne = true;
                bool lastIsDigitTwo = true;
                foreach (var item in input[^1]) //провери дали последната дума е само от цифри
                {
                    if (!Char.IsDigit(item))
                    {
                        lastIsDigitOne = false;
                        break;
                    }
                }
                foreach (var item in input[^2])//провери дали предпоследната дума е само от цифри
                {
                    if (!Char.IsDigit(item))
                    {
                        lastIsDigitTwo = false;
                        break;
                    }
                }
                if (!lastIsDigitOne || !lastIsDigitTwo)
                {
                    continue;
                }
                var inputArray = input.ToArray();


                var lenghtValid = true;
                if (input.Count > 8 || input.Count < 4) //ако има под 4 елемента или над 8
                {
                    lenghtValid = false;
                }
                if (!lenghtValid)
                {
                    continue;
                }

                var venue = inputArray[indexOfA..^2];
                if (venue.Length > 3)
                {
                    continue;
                }
                var ticketPrice = inputArray[^2];
                var ticketsCount = inputArray[^1];
                var singerName = inputArray[..indexOfA];
                if (singerName.Length == 0 || singerName.Length > 3)
                {
                    continue;
                }

                var finalVenue = String.Join(" ", venue).ToString().TrimStart('@');
                long finalTicketPrice = long.Parse(ticketPrice);
                long finalTicketsCount = long.Parse(ticketsCount);
                var finalSingerName = String.Join(" ", singerName).ToString();

                //място / (певец)(пари)
                if (info.ContainsKey(finalVenue)) //ако има такова място
                {
                    if (info[finalVenue].ContainsKey(finalSingerName)) //ако има такъв певец на такова място
                    {
                        info[finalVenue][finalSingerName] += finalTicketPrice * finalTicketsCount; //само увеличаваме парите
                    }
                    else
                    {
                        info[finalVenue].Add(finalSingerName, finalTicketPrice * finalTicketsCount); //създаваме нов певец
                    }
                }
                else // ако няма такова място
                {
                    Dictionary<string, long> currentDict = new Dictionary<string, long>();
                    info.Add(finalVenue, new Dictionary<string, long> { { finalSingerName, finalTicketPrice * finalTicketsCount } });
                }
            }

            foreach (var kvp in info)
            {
                Console.WriteLine(kvp.Key);

                foreach (var name in kvp.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine($"#  {name.Key} -> {name.Value}");
                }
            }


        }
    }
}