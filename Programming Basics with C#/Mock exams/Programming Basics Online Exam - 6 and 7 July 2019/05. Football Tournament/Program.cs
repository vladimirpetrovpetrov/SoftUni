using System;

namespace _05._Football_Tournament
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            const int win = 3;
            const int draw = 1;
            string teamName = Console.ReadLine();
            int matchPlayed = int.Parse(Console.ReadLine());
            if (matchPlayed == 0)
            {
                Console.WriteLine($"{teamName} hasn't played any games during this season.");
            }
            else
            {
                int wins = 0;
                int draws = 0;
                int total = matchPlayed;

                while (matchPlayed > 0)
                {
                    string result = Console.ReadLine();
                    switch (result)
                    {
                        case "W":
                            wins++;
                            break;
                        case "D":
                            draws++;
                            break;
                        case "L":
                            break;
                        default:
                            break;
                    }
                    matchPlayed--;
                }
                int pointsAcquired = (wins * win) + (draws * draw); //общо точки
                Console.WriteLine($"{teamName} has won {pointsAcquired} points during this season.");
                Console.WriteLine("Total stats:");
                Console.WriteLine($"## W: {wins}");
                Console.WriteLine($"## D: {draws}");
                Console.WriteLine($"## L: {total - (wins + draws)}");
                Console.WriteLine($"Win rate: {(double)wins / total * 100:0.00}%");



            }





        }
    }
}
