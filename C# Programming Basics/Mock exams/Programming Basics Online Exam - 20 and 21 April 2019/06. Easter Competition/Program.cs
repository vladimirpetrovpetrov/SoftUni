using System;

namespace _06._Easter_Competition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var easternBreadsCount = int.Parse(Console.ReadLine());
            var score = "";
            int scoreInInt = 0;
            var totalScore = 0;
            var maxScore = int.MinValue;
            var maxBaker = "";

            for (int i = 0; i < easternBreadsCount; i++)
            {
                var bakerName = Console.ReadLine();
                while (score != "Stop")
                {
                    score = Console.ReadLine();
                    if (score == "Stop")
                    {
                        Console.WriteLine($"{bakerName} has {totalScore} points.");
                        if (totalScore > maxScore)
                        {
                            maxScore = totalScore;
                            maxBaker = bakerName;
                            Console.WriteLine($"{maxBaker} is the new number 1!");
                            totalScore = 0;
                            score = "";
                            break;
                        }
                        totalScore = 0;
                        score = "";
                        break;
                    }
                    scoreInInt = Convert.ToInt32(score);
                    totalScore += scoreInInt;
                }
            }
            Console.WriteLine($"{maxBaker} won competition with {maxScore} points!");
        }
    }
}
