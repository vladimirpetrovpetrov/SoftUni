using System;

namespace _03._Text_Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            var input = Console.ReadLine();
            for (int i = 0; i < bannedWords.Length; i++)
            {
                var changer = new string('*', bannedWords[i].Length);
                input = input.Replace(bannedWords[i], changer);
            }
            Console.WriteLine(input);
        }
    }
}
