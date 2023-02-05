using System;

namespace _09.Index_of_letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] array = new char[26];
            int k = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                array[k++] = i;
            }
            string input = Console.ReadLine()!;
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (input[i] == array[j])
                    {
                        Console.WriteLine($"{input[i]} -> {j}");
                    }
                }
            }
        }
    }
}
