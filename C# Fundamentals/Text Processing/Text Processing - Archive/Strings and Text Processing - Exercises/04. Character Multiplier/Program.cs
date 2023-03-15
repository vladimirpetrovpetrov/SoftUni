using System;

namespace _04._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var sum = 0;
            if (input[0].Length == input[1].Length)
            {
                for (int i = 0; i < input[0].Length; i++)
                {
                    sum += input[0][i] * input[1][i];
                }
            }
            else
            {
                bool firstIsBigger = input[0].Length > input[1].Length;
                if (firstIsBigger)
                {
                    var startingIndex = input[1].Length;
                    for (int i = 0; i < input[1].Length; i++)
                    {
                        sum += input[0][i] * input[1][i];
                    }
                    for (int i = startingIndex; i < input[0].Length; i++)
                    {
                        sum += input[0][i];
                    }
                }
                else
                {
                    var startingIndex = input[0].Length;
                    for (int i = 0; i < input[0].Length; i++)
                    {
                        sum += input[0][i] * input[1][i];
                    }
                    for (int i = startingIndex; i < input[1].Length; i++)
                    {
                        sum += input[1][i];
                    }

                }
            }
            Console.WriteLine(sum);





        }
    }
}
