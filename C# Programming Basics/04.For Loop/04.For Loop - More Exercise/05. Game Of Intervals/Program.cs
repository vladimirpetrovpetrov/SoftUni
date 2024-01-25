using System;

namespace _05._Game_Of_Intervals
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int moves = int.Parse(Console.ReadLine());
            double score = 0.0;
            double count1 = 0; double count2 = 0; double count3 = 0; double count4 = 0; double count5 = 0; double count6 = 0;
            
            for (int i = 0; i < moves; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (number >= 0 && number <= 9)
                {
                    score += number * 0.20;
                    count1++;
                }
                else if (number >= 10 && number <= 19)
                {
                    score += number * 0.30;
                    count2++;
                }
                else if (number >= 20 && number <= 29)
                {
                    score += number * 0.40;
                    count3++;
                }
                else if (number >= 30 && number <= 39)
                {
                    score += 50;
                    count4++;
                }
                else if (number >= 40 && number <= 50)
                {
                    score += 100;
                    count5++;
                }
                else
                {
                    score *= 0.50;
                    count6++;
                }
            }
            Console.WriteLine($"{score:0.00}");
            Console.WriteLine($"From 0 to 9: {count1 / moves * 100:0.00}%");
            Console.WriteLine($"From 10 to 19: {count2 / moves * 100:0.00}%");
            Console.WriteLine($"From 20 to 29: {count3 / moves * 100:0.00}%");
            Console.WriteLine($"From 30 to 39: {count4 / moves * 100:0.00}%");
            Console.WriteLine($"From 40 to 50: {count5 / moves * 100:0.00}%");
            Console.WriteLine($"Invalid numbers: {count6 / moves * 100:0.00}%");
        }
    }
}
