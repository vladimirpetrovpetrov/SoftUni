using System;

namespace _05._Challenge_the_Wedding
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var men = int.Parse(Console.ReadLine());
            var women = int.Parse(Console.ReadLine());
            var availableTables = int.Parse(Console.ReadLine());
            var count = 0;

            for (int i = 1; i <= men; i++) //мъже
            {
                for (int j = 1; j <= women; j++) //жени
                {
                    
                    Console.Write($"({i} <-> {j}) ");

                    count++;
                    if (count >= availableTables)
                    {
                        return;
                    }
                }
            }
        }
    }
}
