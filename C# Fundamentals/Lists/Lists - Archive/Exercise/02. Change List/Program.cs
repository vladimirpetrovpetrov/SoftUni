using System;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(x=>int.Parse(x)).ToList();

            while (1 == 1)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (input[0] == "Even")
                {
                    list.RemoveAll(x=>x%2!=0);
                    break;
                }else if (input[0] == "Odd")
                {
                    list.RemoveAll(x => x % 2 == 0);
                    break;
                }
                if (input[0] == "Delete")
                {
                    list.RemoveAll(x => x == int.Parse(input[1]));

                }
                else if (input[0] == "Insert")
                {
                    list.Insert(int.Parse(input[2]), int.Parse(input[1]));
                }
            }
            Console.WriteLine(String.Join(" ",list));
        }
    }
}
