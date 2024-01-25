using System;

namespace _05._Best_Player
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var playerName = "";
            var goals = 0;
            bool hattrick = false;
            string bestPlayer = "";
            var maxGoals = int.MinValue;

            while (playerName != "END" && goals < 10)
            {
                playerName = Console.ReadLine();
                if (playerName == "END")
                {
                    break;
                }
                goals = int.Parse(Console.ReadLine());
                
                if (goals > maxGoals)
                {
                    maxGoals = goals;
                    bestPlayer = playerName;
                }
                if (goals > 10)
                {
                    break;
                }
            }

            if(maxGoals >= 3)
            {
                hattrick = true;
            }

            if (hattrick)
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}
