using System;

namespace _04._Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {


            var ballsCount = int.Parse(Console.ReadLine());
            double points = 0;
            int redCount = 0;
            int orangeCount = 0;
            int yellowCount = 0;
            int whiteCount = 0;
            int blackCount = 0;
            int otherCount = 0;

            for (int i = 0; i < ballsCount; i++)
            {
                var ballColor = Console.ReadLine();
                switch (ballColor)
                {
                    case "red":
                        points += 5;
                        redCount++;
                        break;
                    case "orange":
                        points += 10;
                        orangeCount++;
                        break;
                    case "yellow":
                        yellowCount++;
                        points += 15;
                        break;
                    case "white":
                        whiteCount++;
                        points += 20;
                        break;
                    case "black":
                        blackCount++;
                        points = Math.Floor(points / 2); //TODO към по малкото
                        break;
                    default:
                        otherCount++;
                        break;
                }
            }

            Console.WriteLine($"Total points: {points}");
            Console.WriteLine($"Red balls: {redCount}");
            Console.WriteLine($"Orange balls: {orangeCount}");
            Console.WriteLine($"Yellow balls: {yellowCount}");
            Console.WriteLine($"White balls: {whiteCount}");
            Console.WriteLine($"Other colors picked: {otherCount}");
            Console.WriteLine($"Divides from black balls: {blackCount}");
        }
    }
}
