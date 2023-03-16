using System;

namespace _09._Melrah_Shake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var pattern = Console.ReadLine();
            while (true)
            {
                int firstIndexOf = input.IndexOf(pattern);
                int lastIndexOf = input.LastIndexOf(pattern);
                if (firstIndexOf!= -1 && lastIndexOf != -1 && pattern.Length>0)
                {
                    input = input.Remove(lastIndexOf, pattern.Length);
                    input = input.Remove(firstIndexOf, pattern.Length);
                    Console.WriteLine("Shaked it.");
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    Console.WriteLine("No shake.");
                    Console.WriteLine(input);
                    break;
                }
            }
        }
    }
}
