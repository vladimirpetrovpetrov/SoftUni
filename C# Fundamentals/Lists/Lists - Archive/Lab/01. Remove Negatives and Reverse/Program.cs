using System;
using System.Linq;

namespace _01._Remove_Negatives_and_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(double.Parse).Where(x=>x>=0).Reverse().ToList();
            if (list.Count == 0) 
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", list));
            }
        }
    }
}
