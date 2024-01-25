using System;

namespace _12._The_song_of_the_wheels
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int controlNumber = int.Parse(Console.ReadLine());
            int count = 0;
            string theChosenPassword = "";

            for (int a = 1; a < 9; a++)
            {
                for (int b = 1; b <= 9; b++)
                {
                    for (int c = 1; c <= 9; c++)
                    {
                        for (int d = 1; d < c; d++)
                        {

                            bool cond1 = (a * b) + (c * d) == controlNumber;
                            bool cond2 = a < b && c > d;
                            if (cond1 && cond2)
                            {
                                Console.Write($"{a}{b}{c}{d} ");
                                count++;
                                if (count == 4)
                                {
                                    theChosenPassword = " " + a + b + c + d;
                                }
                            }
                        }
                    }
                }
            }
            if (count >= 4)
            {
                Console.WriteLine();
                Console.WriteLine($"Password:{theChosenPassword}");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("No!");
            }







        }
    }
}
