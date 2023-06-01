using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(String.Join(Environment.NewLine, Console.ReadLine().Split(' ').Where(word => !string.IsNullOrEmpty(word) && char.IsUpper(word[0]))));
    }
}
