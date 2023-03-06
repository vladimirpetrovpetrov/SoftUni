using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Hands_of_Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();
            var power = new Dictionary<string, int> 
            {
                { "2", 2 },
                { "3", 3 },
                { "4", 4 },
                { "5", 5 },
                { "6", 6 },
                { "7", 7 },
                { "8", 8 },
                { "9", 9 },
                { "10", 10 },
                { "J", 11 },
                { "Q", 12 },
                { "K", 13 },
                { "A", 14 },
            };      
            var type = new Dictionary<string, int>
            {
                { "S", 4 },
                { "H", 3 },
                { "D", 2 },
                { "C", 1 },
                
            };
            while (true)
            {
                var input = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "JOKER")
                {
                    break;
                }

                var name = input[0];
                HashSet<string> cards = input[1].Split(", ").ToHashSet();
                List<string> cardsToList = cards.ToList();
                if (!dict.ContainsKey(name))
                {
                    dict.Add(name, cardsToList);
                }
                else
                {
                    var tempList = new List<string>();
                    for (int i = 0; i < cardsToList.Count; i++)
                    {
                        tempList.Add(cardsToList[i]);
                    }
                    var tempList2 = dict[name];
                    tempList2.AddRange(tempList);
                    HashSet<string> extraCards = new HashSet<string>();
                    extraCards = tempList2.ToHashSet();
                    dict[name] = extraCards.ToList();
                }
            }

            foreach (var (key,value) in dict)
            {
                var totalPoints = 0;
                var powerNow = 0;
                var typeNow = 0;
                for (int i = 0; i < value.Count; i++)
                {
                    
                    if (value[i].Length <= 2)
                    {
                        var pw = value[i][0].ToString();
                        var ty = value[i][1].ToString();
                        powerNow = power.First(x=>x.Key.Equals(pw)).Value;
                        typeNow = type.First(x => x.Key.Equals(ty)).Value;
                        totalPoints += (powerNow * typeNow);
                    }
                    else
                    {
                        powerNow = 10;
                        var ty = value[i][2].ToString();
                        typeNow = type.First(x => x.Key.Equals(ty)).Value;
                        totalPoints += (powerNow * typeNow);
                    }
                }
                Console.WriteLine($"{key}: {totalPoints}");
            }
        }
    }
}
