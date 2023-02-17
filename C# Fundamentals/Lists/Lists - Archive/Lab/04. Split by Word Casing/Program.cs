using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Split_by_Word_Casing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] separators = { ".", ",", ";", ":", "!", "(", ")", "\"", "\'", "\\", "/", "[", "]"," "};
            var command = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();
            List<string> lCase = new List<string>();
            List<string> uCase = new List<string>();
            List<string> mCase = new List<string>();

            foreach (var item in command)
            {
                int length = item.Length;
                int countL = 0;
                int countU = 0;
                for (int i = 0; i < item.Length; i++)
                {
                    if (Char.IsUpper(item[i]))
                    {
                        countU++;
                    }
                    else if (Char.IsLower(item[i]))
                    {
                        countL++;
                    }
                    if (countU > 0 && countL > 0)
                    {
                        break;
                    }
                }
                if (countL == length)
                {
                    lCase.Add(item);
                }
                else if (countU == length)
                {
                    uCase.Add(item);
                }
                else
                {
                    mCase.Add(item);
                }
            }
            Console.WriteLine($"Lower-case: {String.Join(", ", lCase)}");
            Console.WriteLine($"Mixed-case: {String.Join(", ", mCase)}");
            Console.WriteLine($"Upper-case: {String.Join(", ", uCase)}");
        }
    }
}
