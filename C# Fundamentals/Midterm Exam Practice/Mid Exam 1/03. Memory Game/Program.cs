using System;
using System.Linq;

namespace _03._Memory_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sequence = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            int moves = 0;
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "end")
                {
                    if (sequence.Count > 0)
                    {
                        Console.WriteLine("Sorry you lose :(");
                        Console.WriteLine(String.Join(" ", sequence));
                        return;
                    }
                }
                moves++;
                var x = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
                if (x[0] < 0 || x[0] > sequence.Count - 1 ||
                    x[1] < 0 || x[1] > sequence.Count - 1 ||
                    x[0] == x[1]
                    )
                {
                    Console.WriteLine("Invalid input! Adding additional elements to the board");
                    sequence.Insert(sequence.Count / 2, "-" + moves + "a");
                    sequence.Insert(sequence.Count / 2, "-" + moves + "a");

                }
                else if (sequence[x[0]] == sequence[x[1]])
                {
                    Console.WriteLine($"Congrats! You have found matching elements - {sequence[x[0]]}!");
                    sequence.RemoveAt(x[0]); 
                    if(x[1] == 0)
                    {
                        sequence.RemoveAt(x[1]);
                    }
                    else
                    {
                        sequence.RemoveAt(x[1] - 1);
                    }
                    if(sequence.Count == 0)
                    {
                        Console.WriteLine($"You have won in {moves} turns!");
                        return;
                    }
                }else if (sequence[x[0]] != sequence[x[1]])
                {
                    Console.WriteLine("Try again!");
                }
            }
        }
    }
}
