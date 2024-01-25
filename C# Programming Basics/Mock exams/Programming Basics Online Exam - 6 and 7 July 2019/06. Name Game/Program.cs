using System;

namespace _06._Name_Game
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int points = 0;
            int maxPoints = int.MinValue;
            string playerWithTheMostPoints = "";
            while (true)
            {
                string playerName = Console.ReadLine();
                if (playerName == "Stop")
                {
                    Console.WriteLine($"The winner is {playerWithTheMostPoints} with {maxPoints} points!");
                    break;
                }
                int loop = playerName.Length;
                for (int i = 0; i < loop; i++)
                {
                    int number = int.Parse(Console.ReadLine());
                    if (number == playerName[i])
                    {
                        points += 10;
                    }
                    else
                    {
                        points += 2;
                    }
                }
                if (points >= maxPoints)
                {
                    maxPoints = points;
                    playerWithTheMostPoints = playerName;
                }
                points = 0;
            }
        }
    }
}

