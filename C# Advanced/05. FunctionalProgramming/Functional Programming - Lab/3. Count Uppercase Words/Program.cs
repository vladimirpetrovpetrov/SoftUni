using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        Func<string, bool> isUpper = word =>
        {
            return Char.IsUpper(word[0]);
        };
        var text = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Where(x => isUpper(x))
            .ToArray();
        Console.WriteLine(String.Join(Environment.NewLine,text));
    }
}
