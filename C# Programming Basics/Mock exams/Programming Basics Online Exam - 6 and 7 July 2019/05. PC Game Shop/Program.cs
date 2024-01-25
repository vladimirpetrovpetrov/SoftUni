using System;

namespace _05._PC_Game_Shop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int soldGames = int.Parse(Console.ReadLine());
            int hearthStone = 0;
            int fornite = 0;
            int overwatch = 0;
            int others = 0;
            int total = soldGames;
            while (soldGames > 0)
            {
                string gameName = Console.ReadLine();
                switch (gameName)
                {
                    case "Hearthstone":
                        hearthStone++;
                        break;
                    case "Fornite":
                        fornite++;
                        break;
                    case "Overwatch":
                        overwatch++;
                        break;
                    default:
                        others++;
                        break;
                }
                soldGames--;
            }
            double hearthstoneP = (double)hearthStone / total * 100;
            double forniteP = (double)fornite / total * 100;
            double overwatchP = (double)overwatch / total * 100;
            double othersP = (double)others / total * 100;
            Console.WriteLine($"Hearthstone - {hearthstoneP:0.00}%");
            Console.WriteLine($"Fornite - {forniteP:0.00}%");
            Console.WriteLine($"Overwatch - {overwatchP:0.00}%");
            Console.WriteLine($"Others - {othersP:0.00}%");
        }
    }
}
